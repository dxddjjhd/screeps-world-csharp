# 安装、编译与部署

本指南使用仓库中的 WorldKit。第一次接触时，先让预编译示例在 Simulation 里运行，再开始修改 C#。

## 1. 下载项目

打开仓库首页，选择 **Code → Download ZIP**，解压到一个方便找到的目录。打开后应能看到 `README.md`、`build.py`、`Bot` 和 `dist`。后面的构建命令都在这个目录执行。

熟悉 Git 的用户也可以执行下面的命令。

```sh
git clone https://github.com/dxddjjhd/screeps-world-csharp.git
cd screeps-world-csharp
```

## 2. 先运行现成的机器人

1. 进入 Screeps: World 的 Simulation，准备自己的房间并放置一个 spawn。
2. 用文本编辑器打开本项目的 `dist/main.js`，复制整个文件。
3. 打开游戏代码编辑器，选择准备运行的脚本分支，将内容粘贴到 `main` 模块，提交代码。在线房间需要确认所选分支已设为运行分支。
4. 观察 spawn。房间有至少 200 能量时，示例会尝试孵化工蜂；孵化需要多个 tick。每个有 spawn 的自有房间目标为 3 只。
5. 工蜂采满后会依次选择补能、建造现有工地、升级控制器。你可以手工放置道路或 extension 工地，观察建造行为。已有 tower 会在发现敌人时攻击。

已有策略时，先在独立测试分支试跑本示例。示例以 `memory.role = "wk-worker"` 管理自己的工蜂。它还会使用自有 spawn 和 tower 发出指令。

## 3. 安装本地编译工具

| 工具 | 用途 | 要求 |
| --- | --- | --- |
| .NET SDK | 运行 C# 编译器 | 10.x，选择页面的 SDK 安装包 |
| Python | 执行打包命令 | 3.9 及以上 |
| Node.js | 可选，本地验证生成的游戏脚本 | 18 及以上 |
| C# 编辑器 | 编辑源码、查看类型声明 | 可用 VS Code 的 C# 扩展或支持项目的 IDE |

.NET SDK 包含编译所需工具。按电脑的系统和处理器选择对应安装包。Python 可从官网获取。[.NET 10 下载](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) · [Python 下载](https://www.python.org/downloads/)

安装后重新打开终端。Windows PowerShell 检查命令如下。

```powershell
dotnet --list-sdks
py -3 --version
```

macOS / Linux 检查命令如下。

```sh
dotnet --list-sdks
python3 --version
```

SDK 列表应包含 10.x。打开项目根目录后，Windows 执行 `py -3 build.py`，macOS / Linux 执行 `python3 build.py`。首次构建需要联网还原 NuGet 工具和依赖。成功时终端显示 `dist/main.js` 路径和字节数。

依赖已还原时，可执行 `python3 build.py --offline`，Windows 对应 `py -3 build.py --offline`。

## 4. 修改第一个参数

在 `Bot/Colony.cs` 中找到 `workers >= 3`，把 `3` 改成 `5`，保存并重新构建。将新生成的 `dist/main.js` 重新提交到游戏，房间有足够资源时，目标工蜂数会增加到 5。

保存 C# 后要重新编译和提交 JavaScript，游戏才能执行新策略。

## 5. 写自己的每 tick 逻辑

游戏调用顺序如下。

```text
module.exports.loop() → Player.Entry.Tick() → Player.Colony.Tick()
```

`Bot/Entry.cs` 负责连接游戏入口。日常策略写在 `Bot/Colony.cs`，工蜂逻辑位于 `Bot/Worker.cs`。你可以在 `Bot/` 添加新的 `.cs` 文件，构建工具会一起编译。

下面是一份可替换 `Bot/Colony.cs` 的完整示例。它统计可见的自有房间，并写入 Memory。运行此示例后，可在游戏控制台输入 `Memory.ownedRooms` 查看结果。

```csharp
using WorldKit;

namespace Player
{
    public static class Colony
    {
        public static void Tick()
        {
            int owned = 0;
            foreach (var room in World.Game.rooms.Values())
            {
                if (room.controller != null && room.controller.my)
                    owned++;
            }
            Native.Set(World.Memory, "ownedRooms", owned);
        }
    }
}
```

这个示例只负责统计。继续运行工蜂策略时，保留或恢复原 Colony 内容。调用游戏动作的写法见 [常用 API 对照表](API.md)。

## 6. 部署自己的更改

每次更改都按“保存 C# → 构建 → 提交 main.js → 观察游戏控制台”执行。若使用游戏客户端的本地文件同步，把 `dist/main.js` 复制到客户端显示的目标分支同步目录，再确认该分支正在运行。

工具会报告 C# 编译错误。构建失败后 `dist/main.js` 仍是上次成功的版本，先修复报错再提交。当前工具通过手工提交或客户端同步部署代码。

## 7. 本地检查

根目录执行 `python3 tests/verify.py`，Windows 用 `py -3 tests/verify.py`。这需要已还原的 .NET 工具、Python 和 Node.js。它会重新编译示例、验证产物行为，并测试一次预期失败的 C# 编译，因此末尾出现故意制造的语法错误诊断属于测试流程；最终应显示 `Compile error preserved prior module.` 且命令成功退出。

只检查仓库自带的产物，可执行 `node tests/world.cjs`。该命令提供模拟游戏环境。`node dist/main.js` 会提示使用测试入口。

官方开源引擎测试在 `tests/engine` 目录中执行。

```sh
cd tests/engine
npm install --ignore-scripts
npm test
```

本地测试检查脚本和引擎是否接受动作。真实房间的经济效率、复杂地形及 CPU 使用需要在游戏中观察。

## 常见问题

| 现象 | 处理方式 |
| --- | --- |
| 找不到 dotnet | 安装 .NET 10 SDK 后重新打开终端，检查 `dotnet --list-sdks` |
| 找不到 python3 | Windows 试用 `py -3`；其他系统检查 Python 安装与命令路径 |
| 找不到 build.py | 进入包含 README、Bot、dist 的项目根目录 |
| NuGet 下载失败 | 检查网络与代理；首次还原完成后才能使用 `--offline` |
| C# 报 CS 开头的错误 | 按终端的文件名和行号修复源码，再执行构建 |
| IDE 中 Game / Memory 名称冲突 | 使用 `World.Game`、`World.Memory`，避免与同名类型混淆 |
| 不孵化 | 检查 spawn 所有权、房间能量、孵化状态和现有工蜂数量 |
| 不建造 | 先放置可达的自有工地；示例优先为 spawn、extension、tower 补能 |
| 采矿后移动很慢 | 检查 creep 的疲劳、身体配置和地形，移动需要游戏 tick 推进 |
| 读取对象为 null | 房间可能不可见、对象已销毁或名称不匹配，动作前检查目标 |
| 修改 C# 后游戏行为没变 | 核对本次构建是否成功、提交了哪个 main.js、当前运行分支 |
| 全局重置后自定义状态消失 | 将任务阶段和对象 ID 保存在 Memory 中，每 tick 重新读取游戏对象 |

项目的语言、基础库和运行边界在 [首页](../README.md#接口覆盖和运行边界)。每 tick 重新生成的 Game 与持久化的 Memory 行为详见官方说明。[Game 与 Memory](https://docs.screeps.com/global-objects.html)
