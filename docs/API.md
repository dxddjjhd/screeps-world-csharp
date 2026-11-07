# C# 与 Screeps JavaScript API 对照

这里给出常用操作的对应写法。左侧是游戏原生 JavaScript，右侧是本仓库的 C#。C# 文件先写 `using WorldKit;`，全局对象通过 `World` 访问。表中的 creep、room、spawn、tower、target 等变量都表示当前 tick 已获取、类型匹配且可用的游戏对象。具体规则、返回码和使用距离以官方文档为准。[World API](https://docs.screeps.com/api/)

所有已生成的全局名称、成员签名和重载可在 [完整绑定对照表](API-REFERENCE.md) 按类型查找。表格对应当前仓库实际声明，调用方法名保留官方大小写。

## 全局对象、集合与常量

| 用途 | JavaScript | C# |
| --- | --- | --- |
| 当前 tick | `Game.time` | `World.Game.time` |
| 所有 creep | `Object.values(Game.creeps)` | `World.Game.creeps.Values()` |
| creep 名称 | `Object.keys(Game.creeps)` | `World.Game.creeps.Keys()` |
| 按名称取 creep | `Game.creeps["Bob"]` | `World.Game.creeps["Bob"]` |
| 按名称取 spawn | `Game.spawns["Spawn1"]` | `World.Game.spawns["Spawn1"]` |
| 按名称取房间 | `Game.rooms["W1N1"]` | `World.Game.rooms["W1N1"]` |
| 自有结构集合 | `Object.values(Game.structures)` | `World.Game.structures.Values()` |
| 按 ID 取对象 | `Game.getObjectById(id)` | `World.Game.getObjectById(id)` |
| 已确认是 Source 的对象 | `Game.getObjectById(id)` | `Native.As<Source>((object)World.Game.getObjectById(id))` |
| 能量常量 | `RESOURCE_ENERGY` | `World.RESOURCE_ENERGY` |
| 工作部件 | `WORK` | `World.WORK` |
| 成功 | `OK` | `World.OK` |
| 距离不足 | `ERR_NOT_IN_RANGE` | `World.ERR_NOT_IN_RANGE` |
| 已用 CPU | `Game.cpu.getUsed()` | `World.Game.cpu.getUsed()` |
| CPU bucket | `Game.cpu.bucket` | `World.Game.cpu.bucket` |

`Native.As<T>` 会让 C# 按 T 使用原对象，调用者需要先确认实际类型。不存在的对象要先检查是否为 null。`getObjectById` 返回 dynamic，示例中的 `(object)` 用于让后续泛型方法在编译时绑定。

## 房间、位置与查找

| 用途 | JavaScript | C# |
| --- | --- | --- |
| controller | `room.controller` | `room.controller` |
| 房间可用能量 | `room.energyAvailable` | `room.energyAvailable` |
| 活跃矿源 | `room.find(FIND_SOURCES_ACTIVE)` | `Native.Find<Source>(room, World.FIND_SOURCES_ACTIVE)` |
| 自有 creep | `room.find(FIND_MY_CREEPS)` | `Native.Find<Creep>(room, World.FIND_MY_CREEPS)` |
| 自有工地 | `room.find(FIND_MY_CONSTRUCTION_SITES)` | `Native.Find<ConstructionSite>(room, World.FIND_MY_CONSTRUCTION_SITES)` |
| 所有结构 | `room.find(FIND_STRUCTURES)` | `Native.Find<Structure>(room, World.FIND_STRUCTURES)` |
| 敌方 creep | `room.find(FIND_HOSTILE_CREEPS)` | `Native.Find<Creep>(room, World.FIND_HOSTILE_CREEPS)` |
| 最近可达矿源 | `creep.pos.findClosestByPath(FIND_SOURCES_ACTIVE)` | `Native.Closest<Source>(creep.pos, World.FIND_SOURCES_ACTIVE)` |
| 坐标 | `new RoomPosition(20, 21, "W1N1")` | `World.Position(20, 21, "W1N1")` |
| 距离 | `creep.pos.getRangeTo(target)` | `creep.pos.getRangeTo(target)` |
| 放置道路工地 | `room.createConstructionSite(20, 21, STRUCTURE_ROAD)` | `room.createConstructionSite(20, 21, World.STRUCTURE_ROAD)` |
| 跨房间路线 | `Game.map.findRoute("W1N1", "W2N1")` | `World.Game.map.findRoute("W1N1", "W2N1")` |
| 房间间距离 | `Game.map.getRoomLinearDistance("W1N1", "W2N1")` | `World.Game.map.getRoomLinearDistance("W1N1", "W2N1")` |
| 房间地形 | `new Room.Terrain("W1N1")` | `World.Terrain("W1N1")` |
| 地形格 | `terrain.get(20, 21)` | `terrain.get(20, 21)` |

## Creep 动作与 Store

| 用途 | JavaScript | C# |
| --- | --- | --- |
| 孵化工蜂 | `spawn.spawnCreep([WORK,CARRY,MOVE], name)` | `spawn.spawnCreep(new[] { World.WORK, World.CARRY, World.MOVE }, name)` |
| 移动 | `creep.moveTo(target)` | `creep.moveTo(target)` |
| 采集 | `creep.harvest(source)` | `creep.harvest(source)` |
| 转移能量 | `creep.transfer(target, RESOURCE_ENERGY)` | `creep.transfer(target, World.RESOURCE_ENERGY)` |
| 提取能量 | `creep.withdraw(target, RESOURCE_ENERGY)` | `creep.withdraw(target, World.RESOURCE_ENERGY)` |
| 捡资源 | `creep.pickup(resource)` | `creep.pickup(resource)` |
| 建造 | `creep.build(site)` | `creep.build(site)` |
| 维修 | `creep.repair(structure)` | `creep.repair(structure)` |
| 升级 | `creep.upgradeController(controller)` | `creep.upgradeController(controller)` |
| 预定房间 | `creep.reserveController(controller)` | `creep.reserveController(controller)` |
| 占领房间 | `creep.claimController(controller)` | `creep.claimController(controller)` |
| 近战 | `creep.attack(target)` | `creep.attack(target)` |
| 远程攻击 | `creep.rangedAttack(target)` | `creep.rangedAttack(target)` |
| 治疗 | `creep.heal(friend)` | `creep.heal(friend)` |
| 拆除 | `creep.dismantle(structure)` | `creep.dismantle(structure)` |
| 发言 | `creep.say("working")` | `creep.say("working")` |
| 当前能量 | `creep.store[RESOURCE_ENERGY]` | `creep.store[World.RESOURCE_ENERGY]` |
| 已使用容量 | `creep.store.getUsedCapacity(RESOURCE_ENERGY)` | `creep.store.getUsedCapacity(World.RESOURCE_ENERGY)` |
| 剩余容量 | `creep.store.getFreeCapacity(RESOURCE_ENERGY)` | `creep.store.getFreeCapacity(World.RESOURCE_ENERGY)` |

Store 的容量查询可返回 `double?`。传入适用于该容器的资源类型，并处理空值。例如 `double free = creep.store.getFreeCapacity(World.RESOURCE_ENERGY) ?? 0;`。游戏动作常返回数字状态码，按 `World.OK`、`World.ERR_NOT_IN_RANGE` 等判断。

## 建筑、市场和 Power

| 用途 | JavaScript | C# |
| --- | --- | --- |
| 塔攻击 | `tower.attack(enemy)` | `tower.attack(enemy)` |
| 塔治疗 | `tower.heal(friend)` | `tower.heal(friend)` |
| 塔维修 | `tower.repair(structure)` | `tower.repair(structure)` |
| link 传能 | `link.transferEnergy(otherLink)` | `link.transferEnergy(otherLink)` |
| lab 反应 | `lab.runReaction(lab1, lab2)` | `lab.runReaction(lab1, lab2)` |
| 工厂生产 | `factory.produce("wire")` | `factory.produce("wire")` |
| terminal 运输 | `terminal.send(RESOURCE_ENERGY, 100, "W2N1")` | `terminal.send(World.RESOURCE_ENERGY, 100, "W2N1")` |
| 处理 Power | `powerSpawn.processPower()` | `powerSpawn.processPower()` |
| 观察房间 | `observer.observeRoom("W2N1")` | `observer.observeRoom("W2N1")` |
| 查询订单 | `Game.market.getAllOrders()` | `World.Game.market.getAllOrders()` |
| 成交 | `Game.market.deal(orderId, 100, "W1N1")` | `World.Game.market.deal(orderId, 100, "W1N1")` |
| 运费 | `Game.market.calcTransactionCost(100, "W1N1", "W2N1")` | `World.Game.market.calcTransactionCost(100, "W1N1", "W2N1")` |
| 取得 Power Creep | `Game.powerCreeps["operator"]` | `World.Game.powerCreeps["operator"]` |
| 使用 Power | `powerCreep.usePower(PWR_GENERATE_OPS)` | `powerCreep.usePower(World.PWR_GENERATE_OPS)` |

混合结构集合先用 `Native.Get<string>(structure, "structureType")` 判断类型，例如等于 `World.STRUCTURE_TOWER` 后再调用 `Native.As<StructureTower>(structure).attack(enemy)`。

## Memory、选项与回调

| 用途 | JavaScript | C# |
| --- | --- | --- |
| 写角色 | `creep.memory.role = "builder"` | `Native.Set(creep.memory, "role", "builder")` |
| 读角色 | `creep.memory.role` | `Native.Get<string>(creep.memory, "role")` |
| 删除记忆 | `delete creep.memory.targetId` | `Native.Delete(creep.memory, "targetId")` |
| 可选数值 | `Memory.count ?? 0` | `Native.Get<double?>(World.Memory, "count") ?? 0` |
| 可选布尔 | `creep.memory.working ?? false` | `Native.Get<bool?>(creep.memory, "working") ?? false` |
| 新建原生配置 | `{}` | `Native.Options<SpawnOptions>()` |
| 激活分段 | `RawMemory.setActiveSegments([2,3])` | `World.RawMemory.setActiveSegments(new double[] { 2, 3 })` |
| 读已激活分段 | `RawMemory.segments[2]` | `World.RawMemory.segments["2"]` |
| 写已激活分段 | `RawMemory.segments[2] = "data"` | `World.RawMemory.segments["2"] = "data"` |
| 本 shard 数据 | `InterShardMemory.getLocal()` | `World.InterShardMemory.getLocal()` |
| 写本 shard 数据 | `InterShardMemory.setLocal("data")` | `World.InterShardMemory.setLocal("data")` |
| 读其他 shard | `InterShardMemory.getRemote("shard1")` | `World.InterShardMemory.getRemote("shard1")` |

Memory 中存 ID、名称和可序列化的数据。分段激活要等待游戏在后续 tick 提供相应分段。每 tick 获取最新游戏对象。[Memory 与对象生命周期](https://docs.screeps.com/global-objects.html) · [RawMemory](https://docs.screeps.com/api/#RawMemory)

下面的片段放在持有 `StructureSpawn spawn` 的方法中。

```csharp
var memory = Native.Options<CreepMemory>();
Native.Set(memory, "role", "builder");
var options = Native.Options<SpawnOptions>();
options.memory = memory;
spawn.spawnCreep(new[] { World.WORK, World.CARRY, World.MOVE },
    "builder-" + World.Game.time, options);
```

可选参数通过省略参数的重载表达；配置对象只设置需要的成员。路径选项的 `roomCallback` 在当前绑定里声明为方法，设置回调应使用 `Native.Set`。下面的片段需要 `using System;` 以及 `RoomPosition origin`、`RoomPosition goal`。

```csharp
var options = Native.Options<PathFinderOpts>();
options.maxOps = 2000;
Func<string, CostMatrix> callback = roomName => World.Costs();
Native.Set(options, "roomCallback", callback);
var path = World.PathFinder.search(origin, goal, options);
```

`World.Costs()` 创建空 CostMatrix；这个回调示例用于展示接入方式。实际寻路策略可以在矩阵中设置道路和障碍成本。

## 构造器、可视化与扩展接口

| 用途 | JavaScript | C# |
| --- | --- | --- |
| CostMatrix | `new PathFinder.CostMatrix()` | `World.Costs()` |
| 设置格子成本 | `costs.set(20, 21, 5)` | `costs.set(20, 21, 5)` |
| 搜索路径 | `PathFinder.search(origin, goal)` | `World.PathFinder.search(origin, goal)` |
| 房间可视化 | `new RoomVisual("W1N1")` | `World.Visual("W1N1")` |
| 写可视化文字 | `visual.text("hello", 20, 21)` | `visual.text("hello", 20, 21)` |
| 任意原生属性 | `target[key]` | `Native.Get<T>(target, key)` |
| 任意原生方法 | `target[name](...args)` | `Native.Call<T>(target, name, new object[] { ... })` |
| 任意全局对象 | `globalThis[name]` | `Native.Global<T>(name)` |
| 原生构造器 | `Reflect.construct(ctor, args)` | `Native.New<T>(ctor, new object[] { ... })` |

`T` 表示预期返回类型，需要用实际类型替换。无返回值的动态调用可使用 `Native.Call<object>` 并忽略结果。配置对象字段、动态 API 的名称和参数在运行时由游戏检查。

## 类型约定

| API 数据 | C# 声明与使用方式 |
| --- | --- |
| JavaScript number | 通常为 `double`，可选数值可能为 `double?` |
| 原生数组 | `T[]`，在 C# 中使用 `Length` 和 `foreach` |
| 名称到对象的映射 | `NativeMap<T>`，使用字符串下标、`Keys()`、`Values()` |
| 字符串常量 | 例如 `World.RESOURCE_ENERGY` 为 string |
| 复杂联合或条件类型 | 可能为 `object`、`dynamic` 或 `dynamic[]` |
| 配置对象 | 用 `Native.Options<T>()` 创建，按需设置属性 |
| 对象类型视图 | 用 `Native.As<T>`，由调用者确认实际类型 |
| 游戏 C# 关键字成员 | 可写为 `visual.@export()`、`visual.@import(data)` |

API 对照表描述当前生成绑定的调用表面。语言兼容范围、CPU 和宿主限制见 [首页](../README.md#接口覆盖和运行边界)。
