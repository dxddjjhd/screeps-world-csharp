"""Compile a WorldKit project to a single Screeps: World main module."""
import argparse
import os
from pathlib import Path
import subprocess
import sys
import tempfile

ROOT = Path(__file__).resolve().parent
PROJECT = ROOT / "Bot/Colony.csproj"
RUNTIME = ("tps.min.js", "tps.shim.min.js", "tps.meta.min.js", "colony.min.js")
LIMIT = 5_000_000  # Conservative deployment budget for this single-module packager.


def build(project, destination, offline):
    # A fresh staging directory prevents stale modules from surviving failed builds.
    def run(args):
        subprocess.run(args, cwd=ROOT, check=True)

    if not offline:
        run(["dotnet", "tool", "restore"])
        run(["dotnet", "tool", "run", "tps", "--", "restore", str(project)])
    with tempfile.TemporaryDirectory() as temporary:
        site = Path(temporary) / "site"
        run(["dotnet", "tool", "run", "tps", "--", str(project),
             "-c", "Release", "--site-dir", str(site)])
        extra = {p.relative_to(site).as_posix() for p in site.rglob("*") if p.is_file()} - set(RUNTIME) - {'.tps-manifest.Colony.json'}
        if extra:
            raise ValueError("此单模块构建不能装载额外资源：" + ", ".join(sorted(extra)))
        parts = [(site / filename).read_bytes() for filename in RUNTIME]
        # The upstream runtime can export itself as CommonJS. Isolate that branch
        # while giving it the real world globals, then export the game loop.
        module = (b'if (typeof process !== "undefined" && process.versions && process.versions.node) '
                  b'{ throw Error("WorldKit targets Screeps: World. Use node tests/world.cjs for a local run."); }\n'
                  + b"(function(module, exports) {\n" + b"\n;\n".join(parts)
                  + b"\n}).call(globalThis);\nmodule.exports.loop = function() { Player.Entry.tick(); };\n")
        if len(module) > LIMIT:
            raise ValueError(f"脚本为 {len(module)} 字节，超过本工具的 {LIMIT} 字节预算")
        destination.parent.mkdir(parents=True, exist_ok=True)
        with tempfile.NamedTemporaryFile(dir=destination.parent, delete=False) as temp:
            staged = Path(temp.name)
        try:
            staged.write_bytes(module)
            os.replace(staged, destination)
        finally:
            staged.unlink(missing_ok=True)
        print(f"{destination} ({len(module):,} bytes)")


if __name__ == "__main__":
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--offline", action="store_true", help="use previously restored tools and packages")
    args = parser.parse_args()
    try:
        build(PROJECT, ROOT / "dist/main.js", args.offline)
    except FileNotFoundError as exc:
        sys.exit("缺少构建文件或工具。请确认已安装 .NET 10 SDK。\n" + str(exc))
    except (OSError, ValueError, subprocess.CalledProcessError) as exc:
        sys.exit(str(exc))
