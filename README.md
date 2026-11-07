# WorldKit · 用 C# 编写 Screeps: World

从 `Bot/Colony.cs` 开始写策略。在 `Bot/` 下添加的 C# 文件也会参与编译。WorldKit 用基于 Roslyn 的 Transpose 编译 C#，把基础库、游戏接口和你的策略打包成一个 CommonJS 模块 `dist/main.js`。游戏端只需加载 JavaScript。

## 先试跑，再改代码

1. 在 World 的 Simulation 或测试分支创建自己的房间和 spawn。
2. 压缩包中已有编译产物。将 `dist/main.js` 的全部内容放进游戏编辑器的 `main` 模块并提交。有现有策略时请先切换到测试分支。也可将这个文件复制到游戏客户端为测试分支提供的本地同步目录。
3. 示例会在每个有 spawn 的自有房间尝试维持 3 只工蜂，每只需要 200 能量。它用 creep 的 `memory.role` 和 `memory.home` 识别自己的工蜂。采满后先给 spawn、extension 或 tower 补能，然后建造已有工地，最后升级控制器。房间出现敌人时，已有的自有 tower 会攻击。样例中的工地由玩家放置。

安装 **.NET 10 SDK** 和 **Python 3.9+**。在解压出的 WorldKit 目录执行：

~~~sh
python3 build.py
~~~

Windows 可用 `py -3 build.py`。首次构建会从 NuGet 获取锁定版本的编译器和基础库。编译成功后将新的 `dist/main.js` 提交到游戏。工具与包已还原时可用 `python3 build.py --offline`。C# 语法或类型错误会显示文件和行号，构建失败会保留上次的游戏模块。

## 怎样写自己的策略

- 在 `Player.Colony.Tick()` 写每 tick 的决策。可以创建类、接口和泛型集合，将经济、建筑与战斗代码拆成多个文件。示例的工蜂行为在 `Bot/Worker.cs`。用 C# 编辑器打开 `Bot/Colony.csproj` 可查看声明。
- 游戏名沿用官方 JavaScript 大小写。例如 `World.Game.rooms["W1N1"]`、`room.controller`、`creep.build(site)`。字典提供 `Keys()`、`Values()` 和字符串下标。可按房间分别决策，通过 `World.Game.map` 处理跨房间路线。
- 当前 tick 读取 `World.Game`，跨 tick 数据写入 `World.Memory` 或对象的 `memory`。只存可以 JSON 序列化的数据，例如房间名、任务阶段和对象 ID。下一 tick 通过 ID 重新获取对象。游戏可随时重置模块级状态。
- `Native.Find<T>`、`Native.Closest<T>` 和 `Native.As<T>` 中的 T 由调用者选择。混合结构集合应先检查 `structureType`，再按具体结构调用方法。这些原生视图不会在运行时转换对象。
- 给包含可选参数的 API 传配置时，用 `Native.Options<T>()` 创建原生对象，只设置需要的字段。示例在 `spawn.spawnCreep(..., opts)` 中传入工蜂记忆。
- 查找路径可用 `World.Position(x, y, roomName)`、`World.Costs()` 和 `World.PathFinder.search(...)`。完整调用样例见 `tests/ApiProbe.cs`，涵盖市场、地图、Power Creep、工厂、实验室、终端和跨分片内存。

例如，在自己的 Tick 中统计本回合可见的自有房间并记入 Memory：

~~~csharp
int owned = 0;
foreach (var room in World.Game.rooms.Values())
{
    if (room.controller != null && room.controller.my)
        owned++;
}
Native.Set(World.Memory, "ownedRooms", owned);
~~~

## 接口覆盖和运行边界

`Bot/World.generated.cs` 从社区声明包 `@types/screeps 3.4.0` 生成，包含 451 个全局名称、144 个类型声明、720 个属性、方法重载、索引器和构造方法签名。计数按 C# 声明统计，同一游戏动作可能有多个重载。覆盖范围包括常量、资源、房间、单位、建筑、地图、寻路、市场、Power、RawMemory 和 InterShardMemory。TypeScript 的条件类型和复杂联合类型在 C# 中会放宽为 object 或 dynamic。输入声明的游戏版本、拼写和运行服的规则仍然重要。

**未收录的游戏接口也可从 C# 调用。** `Native.Global<T>` 获取全局对象，`Get<T>/Set/Delete` 访问成员，`Call<T>` 用原对象调用方法，`New<T>` 调用原生构造器。例如服务器新增 `Game.cpu` 上的方法后，可以直接用 `Native.Call<double>(World.Game.cpu, "方法的实际名称", new object[] { ... })`。动态调用的名称与参数由游戏在运行时检查。

语言和基础库的支持范围由固定的 Transpose 编译器决定。已实测类、接口分派、泛型字典和列表、LINQ、lambda、for/while/foreach、异常捕获、多文件编译。顶层语句等不受支持的语法会触发诊断。使用依赖库前应确认它支持 Transpose 的 JavaScript 后端。桌面文件系统、原生 DLL、后台线程和操作系统服务均超出游戏宿主能力。异步代码也不能代替下一 tick 的入口。大型策略需在目标服务器检查实际 CPU 开销和重置耗时。

## 验证

构建过一次后，安装 Node.js 18 或更高版本，在根目录运行：

~~~sh
python3 tests/verify.py
~~~

测试会在临时目录重新编译示例和一个独立的 C# 策略，然后在无 DOM、无 Node.js 专属接口、禁止动态生成代码的环境中运行产物。覆盖工蜂状态变更、全局重置、语言特性、多个后期接口和自定义宿主方法。最后故意编译一个有语法错误的文件，验证上次产物得到保留。

另有官方开源引擎集成测试。在 `tests/engine/` 中运行 `npm install --ignore-scripts` 和 `npm test`。它使用 `@screeps/engine 4.3.2` 与 `@screeps/common 2.16.1` 的游戏对象、动作校验和模块加载逻辑。本地驱动提供预设房间快照并记录动作请求。已验证连续四个 tick 中的孵化、能量转移、建造、升级和塔攻击。测试没有登录游戏账户，也没有测量正式服务器上的 CPU。

## 从上一版迁移

将 `migration/Screeps.cs` 和旧版 Bot.cs 复制到新版 `Bot/`，把 Entry.cs 的入口调用改为 `global::Bot.Loop()`，再构建。旧脚本依赖的 PascalCase 名称由兼容文件提供。新版游戏 API 可通过 `WorldKit.World` 逐步接入。旧版原始工蜂脚本已单独编译并通过原来的 8 tick 测试。

## 来源

- 游戏规则与接口以 [Screeps World API](https://docs.screeps.com/api/) 为准。另见 [模块加载](https://docs.screeps.com/modules.html)、[Game 与 Memory](https://docs.screeps.com/global-objects.html) 和 [CPU 限制](https://docs.screeps.com/cpu-limit.html)。
- C# 前端与 JavaScript 运行库来自 [Transpose](https://github.com/curiosity-ai/transpose)，编译工具 26.10.7419，基础库 26.10.7423，项目 SDK 26.10.7421。许可证随包放在 `licenses/`。
- 游戏接口来自 [typed-screeps](https://github.com/screepers/typed-screeps)。发布包中已包含生成的 C#。需要重新生成时，在开发环境运行 `node tools/generate-bindings.cjs <typescript.js 的绝对路径> <index.d.ts 的路径>`。
