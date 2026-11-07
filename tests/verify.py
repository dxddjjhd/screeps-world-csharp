"""After a first build, verify the colony and an independent C# strategy offline."""
from pathlib import Path
import tempfile
import shutil
import subprocess
import sys

ROOT = Path(__file__).resolve().parents[1]
sys.path.insert(0, str(ROOT))
from build import build

with tempfile.TemporaryDirectory() as temp:
    root = Path(temp)
    dest = root / "main.js"
    project = root / "Bot/Colony.csproj"
    shutil.copytree(ROOT / "Bot", project.parent, ignore=shutil.ignore_patterns("bin", "obj"))
    build(project, dest, True)
    subprocess.run(["node", str(ROOT / "tests/world.cjs"), str(root)], check=True)
    shutil.copy(ROOT / "tests/ApiProbe.cs", project.parent / "Colony.cs")
    build(project, dest, True)
    subprocess.run(["node", str(ROOT / "tests/probe.cjs"), str(dest)], check=True)
    good = dest.read_bytes()
    (project.parent / "Colony.cs").write_text("this is invalid C#")
    try:
        build(project, dest, True)
    except subprocess.CalledProcessError:
        assert dest.read_bytes() == good
    else:
        raise AssertionError("compiler accepted invalid C#")
    print("Compile error preserved prior module.")
