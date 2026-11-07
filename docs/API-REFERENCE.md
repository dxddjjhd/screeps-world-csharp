# 完整绑定对照表

按当前 `Bot/World.generated.cs` 提取。此页记录全部 451 个全局投影和 144 个声明类型中的 720 个成员签名。继承成员在基类章节列出。每行的 `obj` 表示该类型的原生对象；参数以当前 C# 声明为准。

先查 [常用操作与类型约定](API.md)，或阅读 [安装和部署指南](GETTING-STARTED.md)。游戏规则见 [官方 World API](https://docs.screeps.com/api/)。

## 全局名称

C# 使用 `World.名称` 获取原生全局对象或常量。

| JavaScript | C# | 返回类型 |
| --- | --- | --- |
| `OK` | `World.OK` | `double` |
| `ERR_NOT_OWNER` | `World.ERR_NOT_OWNER` | `double` |
| `ERR_NO_PATH` | `World.ERR_NO_PATH` | `double` |
| `ERR_NAME_EXISTS` | `World.ERR_NAME_EXISTS` | `double` |
| `ERR_BUSY` | `World.ERR_BUSY` | `double` |
| `ERR_NOT_FOUND` | `World.ERR_NOT_FOUND` | `double` |
| `ERR_NOT_ENOUGH_RESOURCES` | `World.ERR_NOT_ENOUGH_RESOURCES` | `double` |
| `ERR_NOT_ENOUGH_ENERGY` | `World.ERR_NOT_ENOUGH_ENERGY` | `double` |
| `ERR_INVALID_TARGET` | `World.ERR_INVALID_TARGET` | `double` |
| `ERR_FULL` | `World.ERR_FULL` | `double` |
| `ERR_NOT_IN_RANGE` | `World.ERR_NOT_IN_RANGE` | `double` |
| `ERR_INVALID_ARGS` | `World.ERR_INVALID_ARGS` | `double` |
| `ERR_TIRED` | `World.ERR_TIRED` | `double` |
| `ERR_NO_BODYPART` | `World.ERR_NO_BODYPART` | `double` |
| `ERR_NOT_ENOUGH_EXTENSIONS` | `World.ERR_NOT_ENOUGH_EXTENSIONS` | `double` |
| `ERR_RCL_NOT_ENOUGH` | `World.ERR_RCL_NOT_ENOUGH` | `double` |
| `ERR_GCL_NOT_ENOUGH` | `World.ERR_GCL_NOT_ENOUGH` | `double` |
| `ERR_ACCESS_DENIED` | `World.ERR_ACCESS_DENIED` | `double` |
| `FIND_EXIT_TOP` | `World.FIND_EXIT_TOP` | `double` |
| `FIND_EXIT_RIGHT` | `World.FIND_EXIT_RIGHT` | `double` |
| `FIND_EXIT_BOTTOM` | `World.FIND_EXIT_BOTTOM` | `double` |
| `FIND_EXIT_LEFT` | `World.FIND_EXIT_LEFT` | `double` |
| `FIND_EXIT` | `World.FIND_EXIT` | `double` |
| `FIND_CREEPS` | `World.FIND_CREEPS` | `double` |
| `FIND_MY_CREEPS` | `World.FIND_MY_CREEPS` | `double` |
| `FIND_HOSTILE_CREEPS` | `World.FIND_HOSTILE_CREEPS` | `double` |
| `FIND_SOURCES_ACTIVE` | `World.FIND_SOURCES_ACTIVE` | `double` |
| `FIND_SOURCES` | `World.FIND_SOURCES` | `double` |
| `FIND_DROPPED_RESOURCES` | `World.FIND_DROPPED_RESOURCES` | `double` |
| `FIND_STRUCTURES` | `World.FIND_STRUCTURES` | `double` |
| `FIND_MY_STRUCTURES` | `World.FIND_MY_STRUCTURES` | `double` |
| `FIND_HOSTILE_STRUCTURES` | `World.FIND_HOSTILE_STRUCTURES` | `double` |
| `FIND_FLAGS` | `World.FIND_FLAGS` | `double` |
| `FIND_CONSTRUCTION_SITES` | `World.FIND_CONSTRUCTION_SITES` | `double` |
| `FIND_MY_SPAWNS` | `World.FIND_MY_SPAWNS` | `double` |
| `FIND_HOSTILE_SPAWNS` | `World.FIND_HOSTILE_SPAWNS` | `double` |
| `FIND_MY_CONSTRUCTION_SITES` | `World.FIND_MY_CONSTRUCTION_SITES` | `double` |
| `FIND_HOSTILE_CONSTRUCTION_SITES` | `World.FIND_HOSTILE_CONSTRUCTION_SITES` | `double` |
| `FIND_MINERALS` | `World.FIND_MINERALS` | `double` |
| `FIND_NUKES` | `World.FIND_NUKES` | `double` |
| `FIND_TOMBSTONES` | `World.FIND_TOMBSTONES` | `double` |
| `FIND_POWER_CREEPS` | `World.FIND_POWER_CREEPS` | `double` |
| `FIND_MY_POWER_CREEPS` | `World.FIND_MY_POWER_CREEPS` | `double` |
| `FIND_HOSTILE_POWER_CREEPS` | `World.FIND_HOSTILE_POWER_CREEPS` | `double` |
| `FIND_DEPOSITS` | `World.FIND_DEPOSITS` | `double` |
| `FIND_RUINS` | `World.FIND_RUINS` | `double` |
| `TOP` | `World.TOP` | `double` |
| `TOP_RIGHT` | `World.TOP_RIGHT` | `double` |
| `RIGHT` | `World.RIGHT` | `double` |
| `BOTTOM_RIGHT` | `World.BOTTOM_RIGHT` | `double` |
| `BOTTOM` | `World.BOTTOM` | `double` |
| `BOTTOM_LEFT` | `World.BOTTOM_LEFT` | `double` |
| `LEFT` | `World.LEFT` | `double` |
| `TOP_LEFT` | `World.TOP_LEFT` | `double` |
| `COLOR_RED` | `World.COLOR_RED` | `double` |
| `COLOR_PURPLE` | `World.COLOR_PURPLE` | `double` |
| `COLOR_BLUE` | `World.COLOR_BLUE` | `double` |
| `COLOR_CYAN` | `World.COLOR_CYAN` | `double` |
| `COLOR_GREEN` | `World.COLOR_GREEN` | `double` |
| `COLOR_YELLOW` | `World.COLOR_YELLOW` | `double` |
| `COLOR_ORANGE` | `World.COLOR_ORANGE` | `double` |
| `COLOR_BROWN` | `World.COLOR_BROWN` | `double` |
| `COLOR_GREY` | `World.COLOR_GREY` | `double` |
| `COLOR_WHITE` | `World.COLOR_WHITE` | `double` |
| `COLORS_ALL` | `World.COLORS_ALL` | `double[]` |
| `CREEP_SPAWN_TIME` | `World.CREEP_SPAWN_TIME` | `double` |
| `CREEP_LIFE_TIME` | `World.CREEP_LIFE_TIME` | `double` |
| `CREEP_CLAIM_LIFE_TIME` | `World.CREEP_CLAIM_LIFE_TIME` | `double` |
| `CREEP_CORPSE_RATE` | `World.CREEP_CORPSE_RATE` | `double` |
| `OBSTACLE_OBJECT_TYPES` | `World.OBSTACLE_OBJECT_TYPES` | `dynamic` |
| `ENERGY_REGEN_TIME` | `World.ENERGY_REGEN_TIME` | `double` |
| `ENERGY_DECAY` | `World.ENERGY_DECAY` | `double` |
| `REPAIR_COST` | `World.REPAIR_COST` | `double` |
| `RAMPART_DECAY_AMOUNT` | `World.RAMPART_DECAY_AMOUNT` | `double` |
| `RAMPART_DECAY_TIME` | `World.RAMPART_DECAY_TIME` | `double` |
| `RAMPART_HITS` | `World.RAMPART_HITS` | `double` |
| `RAMPART_HITS_MAX` | `World.RAMPART_HITS_MAX` | `dynamic` |
| `SPAWN_HITS` | `World.SPAWN_HITS` | `double` |
| `SPAWN_ENERGY_START` | `World.SPAWN_ENERGY_START` | `double` |
| `SPAWN_ENERGY_CAPACITY` | `World.SPAWN_ENERGY_CAPACITY` | `double` |
| `SOURCE_ENERGY_CAPACITY` | `World.SOURCE_ENERGY_CAPACITY` | `double` |
| `SOURCE_ENERGY_NEUTRAL_CAPACITY` | `World.SOURCE_ENERGY_NEUTRAL_CAPACITY` | `double` |
| `SOURCE_ENERGY_KEEPER_CAPACITY` | `World.SOURCE_ENERGY_KEEPER_CAPACITY` | `double` |
| `WALL_HITS` | `World.WALL_HITS` | `double` |
| `WALL_HITS_MAX` | `World.WALL_HITS_MAX` | `double` |
| `EXTENSION_HITS` | `World.EXTENSION_HITS` | `double` |
| `EXTENSION_ENERGY_CAPACITY` | `World.EXTENSION_ENERGY_CAPACITY` | `dynamic` |
| `ROAD_HITS` | `World.ROAD_HITS` | `double` |
| `ROAD_WEAROUT` | `World.ROAD_WEAROUT` | `double` |
| `ROAD_WEAROUT_POWER_CREEP` | `World.ROAD_WEAROUT_POWER_CREEP` | `double` |
| `ROAD_DECAY_AMOUNT` | `World.ROAD_DECAY_AMOUNT` | `double` |
| `ROAD_DECAY_TIME` | `World.ROAD_DECAY_TIME` | `double` |
| `LINK_HITS` | `World.LINK_HITS` | `double` |
| `LINK_HITS_MAX` | `World.LINK_HITS_MAX` | `double` |
| `LINK_CAPACITY` | `World.LINK_CAPACITY` | `double` |
| `LINK_COOLDOWN` | `World.LINK_COOLDOWN` | `double` |
| `LINK_LOSS_RATIO` | `World.LINK_LOSS_RATIO` | `double` |
| `STORAGE_CAPACITY` | `World.STORAGE_CAPACITY` | `double` |
| `STORAGE_HITS` | `World.STORAGE_HITS` | `double` |
| `FACTORY_HITS` | `World.FACTORY_HITS` | `double` |
| `FACTORY_CAPACITY` | `World.FACTORY_CAPACITY` | `double` |
| `BODYPART_COST` | `World.BODYPART_COST` | `dynamic` |
| `BODYPARTS_ALL` | `World.BODYPARTS_ALL` | `string[]` |
| `CARRY_CAPACITY` | `World.CARRY_CAPACITY` | `double` |
| `HARVEST_POWER` | `World.HARVEST_POWER` | `double` |
| `HARVEST_MINERAL_POWER` | `World.HARVEST_MINERAL_POWER` | `double` |
| `HARVEST_DEPOSIT_POWER` | `World.HARVEST_DEPOSIT_POWER` | `double` |
| `REPAIR_POWER` | `World.REPAIR_POWER` | `double` |
| `DISMANTLE_POWER` | `World.DISMANTLE_POWER` | `double` |
| `BUILD_POWER` | `World.BUILD_POWER` | `double` |
| `ATTACK_POWER` | `World.ATTACK_POWER` | `double` |
| `UPGRADE_CONTROLLER_POWER` | `World.UPGRADE_CONTROLLER_POWER` | `double` |
| `RANGED_ATTACK_POWER` | `World.RANGED_ATTACK_POWER` | `double` |
| `HEAL_POWER` | `World.HEAL_POWER` | `double` |
| `RANGED_HEAL_POWER` | `World.RANGED_HEAL_POWER` | `double` |
| `DISMANTLE_COST` | `World.DISMANTLE_COST` | `double` |
| `MOVE` | `World.MOVE` | `string` |
| `WORK` | `World.WORK` | `string` |
| `CARRY` | `World.CARRY` | `string` |
| `ATTACK` | `World.ATTACK` | `string` |
| `RANGED_ATTACK` | `World.RANGED_ATTACK` | `string` |
| `TOUGH` | `World.TOUGH` | `string` |
| `HEAL` | `World.HEAL` | `string` |
| `CLAIM` | `World.CLAIM` | `string` |
| `CONSTRUCTION_COST` | `World.CONSTRUCTION_COST` | `dynamic` |
| `CONSTRUCTION_COST_ROAD_SWAMP_RATIO` | `World.CONSTRUCTION_COST_ROAD_SWAMP_RATIO` | `double` |
| `CONSTRUCTION_COST_ROAD_WALL_RATIO` | `World.CONSTRUCTION_COST_ROAD_WALL_RATIO` | `double` |
| `STRUCTURE_EXTENSION` | `World.STRUCTURE_EXTENSION` | `string` |
| `STRUCTURE_RAMPART` | `World.STRUCTURE_RAMPART` | `string` |
| `STRUCTURE_ROAD` | `World.STRUCTURE_ROAD` | `string` |
| `STRUCTURE_SPAWN` | `World.STRUCTURE_SPAWN` | `string` |
| `STRUCTURE_LINK` | `World.STRUCTURE_LINK` | `string` |
| `STRUCTURE_WALL` | `World.STRUCTURE_WALL` | `string` |
| `STRUCTURE_KEEPER_LAIR` | `World.STRUCTURE_KEEPER_LAIR` | `string` |
| `STRUCTURE_CONTROLLER` | `World.STRUCTURE_CONTROLLER` | `string` |
| `STRUCTURE_STORAGE` | `World.STRUCTURE_STORAGE` | `string` |
| `STRUCTURE_TOWER` | `World.STRUCTURE_TOWER` | `string` |
| `STRUCTURE_OBSERVER` | `World.STRUCTURE_OBSERVER` | `string` |
| `STRUCTURE_POWER_BANK` | `World.STRUCTURE_POWER_BANK` | `string` |
| `STRUCTURE_POWER_SPAWN` | `World.STRUCTURE_POWER_SPAWN` | `string` |
| `STRUCTURE_EXTRACTOR` | `World.STRUCTURE_EXTRACTOR` | `string` |
| `STRUCTURE_LAB` | `World.STRUCTURE_LAB` | `string` |
| `STRUCTURE_TERMINAL` | `World.STRUCTURE_TERMINAL` | `string` |
| `STRUCTURE_CONTAINER` | `World.STRUCTURE_CONTAINER` | `string` |
| `STRUCTURE_NUKER` | `World.STRUCTURE_NUKER` | `string` |
| `STRUCTURE_FACTORY` | `World.STRUCTURE_FACTORY` | `string` |
| `STRUCTURE_INVADER_CORE` | `World.STRUCTURE_INVADER_CORE` | `string` |
| `STRUCTURE_PORTAL` | `World.STRUCTURE_PORTAL` | `string` |
| `RESOURCE_ENERGY` | `World.RESOURCE_ENERGY` | `string` |
| `RESOURCE_POWER` | `World.RESOURCE_POWER` | `string` |
| `RESOURCE_OPS` | `World.RESOURCE_OPS` | `string` |
| `RESOURCE_UTRIUM` | `World.RESOURCE_UTRIUM` | `string` |
| `RESOURCE_LEMERGIUM` | `World.RESOURCE_LEMERGIUM` | `string` |
| `RESOURCE_KEANIUM` | `World.RESOURCE_KEANIUM` | `string` |
| `RESOURCE_GHODIUM` | `World.RESOURCE_GHODIUM` | `string` |
| `RESOURCE_ZYNTHIUM` | `World.RESOURCE_ZYNTHIUM` | `string` |
| `RESOURCE_OXYGEN` | `World.RESOURCE_OXYGEN` | `string` |
| `RESOURCE_HYDROGEN` | `World.RESOURCE_HYDROGEN` | `string` |
| `RESOURCE_CATALYST` | `World.RESOURCE_CATALYST` | `string` |
| `RESOURCE_HYDROXIDE` | `World.RESOURCE_HYDROXIDE` | `string` |
| `RESOURCE_ZYNTHIUM_KEANITE` | `World.RESOURCE_ZYNTHIUM_KEANITE` | `string` |
| `RESOURCE_UTRIUM_LEMERGITE` | `World.RESOURCE_UTRIUM_LEMERGITE` | `string` |
| `RESOURCE_UTRIUM_HYDRIDE` | `World.RESOURCE_UTRIUM_HYDRIDE` | `string` |
| `RESOURCE_UTRIUM_OXIDE` | `World.RESOURCE_UTRIUM_OXIDE` | `string` |
| `RESOURCE_KEANIUM_HYDRIDE` | `World.RESOURCE_KEANIUM_HYDRIDE` | `string` |
| `RESOURCE_KEANIUM_OXIDE` | `World.RESOURCE_KEANIUM_OXIDE` | `string` |
| `RESOURCE_LEMERGIUM_HYDRIDE` | `World.RESOURCE_LEMERGIUM_HYDRIDE` | `string` |
| `RESOURCE_LEMERGIUM_OXIDE` | `World.RESOURCE_LEMERGIUM_OXIDE` | `string` |
| `RESOURCE_ZYNTHIUM_HYDRIDE` | `World.RESOURCE_ZYNTHIUM_HYDRIDE` | `string` |
| `RESOURCE_ZYNTHIUM_OXIDE` | `World.RESOURCE_ZYNTHIUM_OXIDE` | `string` |
| `RESOURCE_GHODIUM_HYDRIDE` | `World.RESOURCE_GHODIUM_HYDRIDE` | `string` |
| `RESOURCE_GHODIUM_OXIDE` | `World.RESOURCE_GHODIUM_OXIDE` | `string` |
| `RESOURCE_UTRIUM_ACID` | `World.RESOURCE_UTRIUM_ACID` | `string` |
| `RESOURCE_UTRIUM_ALKALIDE` | `World.RESOURCE_UTRIUM_ALKALIDE` | `string` |
| `RESOURCE_KEANIUM_ACID` | `World.RESOURCE_KEANIUM_ACID` | `string` |
| `RESOURCE_KEANIUM_ALKALIDE` | `World.RESOURCE_KEANIUM_ALKALIDE` | `string` |
| `RESOURCE_LEMERGIUM_ACID` | `World.RESOURCE_LEMERGIUM_ACID` | `string` |
| `RESOURCE_LEMERGIUM_ALKALIDE` | `World.RESOURCE_LEMERGIUM_ALKALIDE` | `string` |
| `RESOURCE_ZYNTHIUM_ACID` | `World.RESOURCE_ZYNTHIUM_ACID` | `string` |
| `RESOURCE_ZYNTHIUM_ALKALIDE` | `World.RESOURCE_ZYNTHIUM_ALKALIDE` | `string` |
| `RESOURCE_GHODIUM_ACID` | `World.RESOURCE_GHODIUM_ACID` | `string` |
| `RESOURCE_GHODIUM_ALKALIDE` | `World.RESOURCE_GHODIUM_ALKALIDE` | `string` |
| `RESOURCE_CATALYZED_UTRIUM_ACID` | `World.RESOURCE_CATALYZED_UTRIUM_ACID` | `string` |
| `RESOURCE_CATALYZED_UTRIUM_ALKALIDE` | `World.RESOURCE_CATALYZED_UTRIUM_ALKALIDE` | `string` |
| `RESOURCE_CATALYZED_KEANIUM_ACID` | `World.RESOURCE_CATALYZED_KEANIUM_ACID` | `string` |
| `RESOURCE_CATALYZED_KEANIUM_ALKALIDE` | `World.RESOURCE_CATALYZED_KEANIUM_ALKALIDE` | `string` |
| `RESOURCE_CATALYZED_LEMERGIUM_ACID` | `World.RESOURCE_CATALYZED_LEMERGIUM_ACID` | `string` |
| `RESOURCE_CATALYZED_LEMERGIUM_ALKALIDE` | `World.RESOURCE_CATALYZED_LEMERGIUM_ALKALIDE` | `string` |
| `RESOURCE_CATALYZED_ZYNTHIUM_ACID` | `World.RESOURCE_CATALYZED_ZYNTHIUM_ACID` | `string` |
| `RESOURCE_CATALYZED_ZYNTHIUM_ALKALIDE` | `World.RESOURCE_CATALYZED_ZYNTHIUM_ALKALIDE` | `string` |
| `RESOURCE_CATALYZED_GHODIUM_ACID` | `World.RESOURCE_CATALYZED_GHODIUM_ACID` | `string` |
| `RESOURCE_CATALYZED_GHODIUM_ALKALIDE` | `World.RESOURCE_CATALYZED_GHODIUM_ALKALIDE` | `string` |
| `RESOURCE_BIOMASS` | `World.RESOURCE_BIOMASS` | `string` |
| `RESOURCE_METAL` | `World.RESOURCE_METAL` | `string` |
| `RESOURCE_MIST` | `World.RESOURCE_MIST` | `string` |
| `RESOURCE_SILICON` | `World.RESOURCE_SILICON` | `string` |
| `RESOURCE_UTRIUM_BAR` | `World.RESOURCE_UTRIUM_BAR` | `string` |
| `RESOURCE_LEMERGIUM_BAR` | `World.RESOURCE_LEMERGIUM_BAR` | `string` |
| `RESOURCE_ZYNTHIUM_BAR` | `World.RESOURCE_ZYNTHIUM_BAR` | `string` |
| `RESOURCE_KEANIUM_BAR` | `World.RESOURCE_KEANIUM_BAR` | `string` |
| `RESOURCE_GHODIUM_MELT` | `World.RESOURCE_GHODIUM_MELT` | `string` |
| `RESOURCE_OXIDANT` | `World.RESOURCE_OXIDANT` | `string` |
| `RESOURCE_REDUCTANT` | `World.RESOURCE_REDUCTANT` | `string` |
| `RESOURCE_PURIFIER` | `World.RESOURCE_PURIFIER` | `string` |
| `RESOURCE_BATTERY` | `World.RESOURCE_BATTERY` | `string` |
| `RESOURCE_COMPOSITE` | `World.RESOURCE_COMPOSITE` | `string` |
| `RESOURCE_CRYSTAL` | `World.RESOURCE_CRYSTAL` | `string` |
| `RESOURCE_LIQUID` | `World.RESOURCE_LIQUID` | `string` |
| `RESOURCE_WIRE` | `World.RESOURCE_WIRE` | `string` |
| `RESOURCE_SWITCH` | `World.RESOURCE_SWITCH` | `string` |
| `RESOURCE_TRANSISTOR` | `World.RESOURCE_TRANSISTOR` | `string` |
| `RESOURCE_MICROCHIP` | `World.RESOURCE_MICROCHIP` | `string` |
| `RESOURCE_CIRCUIT` | `World.RESOURCE_CIRCUIT` | `string` |
| `RESOURCE_DEVICE` | `World.RESOURCE_DEVICE` | `string` |
| `RESOURCE_CELL` | `World.RESOURCE_CELL` | `string` |
| `RESOURCE_PHLEGM` | `World.RESOURCE_PHLEGM` | `string` |
| `RESOURCE_TISSUE` | `World.RESOURCE_TISSUE` | `string` |
| `RESOURCE_MUSCLE` | `World.RESOURCE_MUSCLE` | `string` |
| `RESOURCE_ORGANOID` | `World.RESOURCE_ORGANOID` | `string` |
| `RESOURCE_ORGANISM` | `World.RESOURCE_ORGANISM` | `string` |
| `RESOURCE_ALLOY` | `World.RESOURCE_ALLOY` | `string` |
| `RESOURCE_TUBE` | `World.RESOURCE_TUBE` | `string` |
| `RESOURCE_FIXTURES` | `World.RESOURCE_FIXTURES` | `string` |
| `RESOURCE_FRAME` | `World.RESOURCE_FRAME` | `string` |
| `RESOURCE_HYDRAULICS` | `World.RESOURCE_HYDRAULICS` | `string` |
| `RESOURCE_MACHINE` | `World.RESOURCE_MACHINE` | `string` |
| `RESOURCE_CONDENSATE` | `World.RESOURCE_CONDENSATE` | `string` |
| `RESOURCE_CONCENTRATE` | `World.RESOURCE_CONCENTRATE` | `string` |
| `RESOURCE_EXTRACT` | `World.RESOURCE_EXTRACT` | `string` |
| `RESOURCE_SPIRIT` | `World.RESOURCE_SPIRIT` | `string` |
| `RESOURCE_EMANATION` | `World.RESOURCE_EMANATION` | `string` |
| `RESOURCE_ESSENCE` | `World.RESOURCE_ESSENCE` | `string` |
| `RESOURCES_ALL` | `World.RESOURCES_ALL` | `string[]` |
| `SUBSCRIPTION_TOKEN` | `World.SUBSCRIPTION_TOKEN` | `string` |
| `CPU_UNLOCK` | `World.CPU_UNLOCK` | `string` |
| `PIXEL` | `World.PIXEL` | `string` |
| `ACCESS_KEY` | `World.ACCESS_KEY` | `string` |
| `PIXEL_CPU_COST` | `World.PIXEL_CPU_COST` | `double` |
| `CONTROLLER_LEVELS` | `World.CONTROLLER_LEVELS` | `NativeMap<double>` |
| `CONTROLLER_STRUCTURES` | `World.CONTROLLER_STRUCTURES` | `dynamic` |
| `CONTROLLER_DOWNGRADE` | `World.CONTROLLER_DOWNGRADE` | `NativeMap<double>` |
| `CONTROLLER_DOWNGRADE_RESTORE` | `World.CONTROLLER_DOWNGRADE_RESTORE` | `double` |
| `CONTROLLER_DOWNGRADE_SAFEMODE_THRESHOLD` | `World.CONTROLLER_DOWNGRADE_SAFEMODE_THRESHOLD` | `double` |
| `CONTROLLER_CLAIM_DOWNGRADE` | `World.CONTROLLER_CLAIM_DOWNGRADE` | `double` |
| `CONTROLLER_RESERVE` | `World.CONTROLLER_RESERVE` | `double` |
| `CONTROLLER_RESERVE_MAX` | `World.CONTROLLER_RESERVE_MAX` | `double` |
| `CONTROLLER_MAX_UPGRADE_PER_TICK` | `World.CONTROLLER_MAX_UPGRADE_PER_TICK` | `double` |
| `CONTROLLER_ATTACK_BLOCKED_UPGRADE` | `World.CONTROLLER_ATTACK_BLOCKED_UPGRADE` | `double` |
| `CONTROLLER_NUKE_BLOCKED_UPGRADE` | `World.CONTROLLER_NUKE_BLOCKED_UPGRADE` | `double` |
| `SAFE_MODE_DURATION` | `World.SAFE_MODE_DURATION` | `double` |
| `SAFE_MODE_COOLDOWN` | `World.SAFE_MODE_COOLDOWN` | `double` |
| `SAFE_MODE_COST` | `World.SAFE_MODE_COST` | `double` |
| `TOWER_HITS` | `World.TOWER_HITS` | `double` |
| `TOWER_CAPACITY` | `World.TOWER_CAPACITY` | `double` |
| `TOWER_ENERGY_COST` | `World.TOWER_ENERGY_COST` | `double` |
| `TOWER_POWER_ATTACK` | `World.TOWER_POWER_ATTACK` | `double` |
| `TOWER_POWER_HEAL` | `World.TOWER_POWER_HEAL` | `double` |
| `TOWER_POWER_REPAIR` | `World.TOWER_POWER_REPAIR` | `double` |
| `TOWER_OPTIMAL_RANGE` | `World.TOWER_OPTIMAL_RANGE` | `double` |
| `TOWER_FALLOFF_RANGE` | `World.TOWER_FALLOFF_RANGE` | `double` |
| `TOWER_FALLOFF` | `World.TOWER_FALLOFF` | `double` |
| `OBSERVER_HITS` | `World.OBSERVER_HITS` | `double` |
| `OBSERVER_RANGE` | `World.OBSERVER_RANGE` | `double` |
| `POWER_BANK_HITS` | `World.POWER_BANK_HITS` | `double` |
| `POWER_BANK_CAPACITY_MAX` | `World.POWER_BANK_CAPACITY_MAX` | `double` |
| `POWER_BANK_CAPACITY_MIN` | `World.POWER_BANK_CAPACITY_MIN` | `double` |
| `POWER_BANK_CAPACITY_CRIT` | `World.POWER_BANK_CAPACITY_CRIT` | `double` |
| `POWER_BANK_DECAY` | `World.POWER_BANK_DECAY` | `double` |
| `POWER_BANK_HIT_BACK` | `World.POWER_BANK_HIT_BACK` | `double` |
| `POWER_SPAWN_HITS` | `World.POWER_SPAWN_HITS` | `double` |
| `POWER_SPAWN_ENERGY_CAPACITY` | `World.POWER_SPAWN_ENERGY_CAPACITY` | `double` |
| `POWER_SPAWN_POWER_CAPACITY` | `World.POWER_SPAWN_POWER_CAPACITY` | `double` |
| `POWER_SPAWN_ENERGY_RATIO` | `World.POWER_SPAWN_ENERGY_RATIO` | `double` |
| `EXTRACTOR_HITS` | `World.EXTRACTOR_HITS` | `double` |
| `EXTRACTOR_COOLDOWN` | `World.EXTRACTOR_COOLDOWN` | `double` |
| `LAB_HITS` | `World.LAB_HITS` | `double` |
| `LAB_MINERAL_CAPACITY` | `World.LAB_MINERAL_CAPACITY` | `double` |
| `LAB_ENERGY_CAPACITY` | `World.LAB_ENERGY_CAPACITY` | `double` |
| `LAB_BOOST_ENERGY` | `World.LAB_BOOST_ENERGY` | `double` |
| `LAB_BOOST_MINERAL` | `World.LAB_BOOST_MINERAL` | `double` |
| `LAB_COOLDOWN` | `World.LAB_COOLDOWN` | `double` |
| `LAB_REACTION_AMOUNT` | `World.LAB_REACTION_AMOUNT` | `double` |
| `GCL_POW` | `World.GCL_POW` | `double` |
| `GCL_MULTIPLY` | `World.GCL_MULTIPLY` | `double` |
| `GCL_NOVICE` | `World.GCL_NOVICE` | `double` |
| `MODE_SIMULATION` | `World.MODE_SIMULATION` | `dynamic` |
| `MODE_WORLD` | `World.MODE_WORLD` | `dynamic` |
| `TERRAIN_MASK_WALL` | `World.TERRAIN_MASK_WALL` | `double` |
| `TERRAIN_MASK_SWAMP` | `World.TERRAIN_MASK_SWAMP` | `double` |
| `TERRAIN_MASK_LAVA` | `World.TERRAIN_MASK_LAVA` | `double` |
| `MAX_CONSTRUCTION_SITES` | `World.MAX_CONSTRUCTION_SITES` | `double` |
| `MAX_CREEP_SIZE` | `World.MAX_CREEP_SIZE` | `double` |
| `MINERAL_REGEN_TIME` | `World.MINERAL_REGEN_TIME` | `double` |
| `MINERAL_MIN_AMOUNT` | `World.MINERAL_MIN_AMOUNT` | `dynamic` |
| `MINERAL_RANDOM_FACTOR` | `World.MINERAL_RANDOM_FACTOR` | `double` |
| `MINERAL_DENSITY` | `World.MINERAL_DENSITY` | `dynamic` |
| `MINERAL_DENSITY_PROBABILITY` | `World.MINERAL_DENSITY_PROBABILITY` | `dynamic` |
| `MINERAL_DENSITY_CHANGE` | `World.MINERAL_DENSITY_CHANGE` | `double` |
| `DENSITY_LOW` | `World.DENSITY_LOW` | `double` |
| `DENSITY_MODERATE` | `World.DENSITY_MODERATE` | `double` |
| `DENSITY_HIGH` | `World.DENSITY_HIGH` | `double` |
| `DENSITY_ULTRA` | `World.DENSITY_ULTRA` | `double` |
| `DEPOSIT_EXHAUST_MULTIPLY` | `World.DEPOSIT_EXHAUST_MULTIPLY` | `double` |
| `DEPOSIT_EXHAUST_POW` | `World.DEPOSIT_EXHAUST_POW` | `double` |
| `DEPOSIT_DECAY_TIME` | `World.DEPOSIT_DECAY_TIME` | `double` |
| `TERMINAL_CAPACITY` | `World.TERMINAL_CAPACITY` | `double` |
| `TERMINAL_COOLDOWN` | `World.TERMINAL_COOLDOWN` | `double` |
| `TERMINAL_HITS` | `World.TERMINAL_HITS` | `double` |
| `TERMINAL_SEND_COST` | `World.TERMINAL_SEND_COST` | `double` |
| `TERMINAL_MIN_SEND` | `World.TERMINAL_MIN_SEND` | `double` |
| `CONTAINER_HITS` | `World.CONTAINER_HITS` | `double` |
| `CONTAINER_CAPACITY` | `World.CONTAINER_CAPACITY` | `double` |
| `CONTAINER_DECAY` | `World.CONTAINER_DECAY` | `double` |
| `CONTAINER_DECAY_TIME` | `World.CONTAINER_DECAY_TIME` | `double` |
| `CONTAINER_DECAY_TIME_OWNED` | `World.CONTAINER_DECAY_TIME_OWNED` | `double` |
| `NUKER_HITS` | `World.NUKER_HITS` | `double` |
| `NUKER_COOLDOWN` | `World.NUKER_COOLDOWN` | `double` |
| `NUKER_ENERGY_CAPACITY` | `World.NUKER_ENERGY_CAPACITY` | `double` |
| `NUKER_GHODIUM_CAPACITY` | `World.NUKER_GHODIUM_CAPACITY` | `double` |
| `NUKE_LAND_TIME` | `World.NUKE_LAND_TIME` | `double` |
| `NUKE_RANGE` | `World.NUKE_RANGE` | `double` |
| `NUKE_DAMAGE` | `World.NUKE_DAMAGE` | `dynamic` |
| `REACTIONS` | `World.REACTIONS` | `dynamic` |
| `REACTION_TIME` | `World.REACTION_TIME` | `dynamic` |
| `BOOSTS` | `World.BOOSTS` | `dynamic` |
| `INTERSHARD_RESOURCES` | `World.INTERSHARD_RESOURCES` | `string[]` |
| `COMMODITIES` | `World.COMMODITIES` | `dynamic` |
| `LOOK_CREEPS` | `World.LOOK_CREEPS` | `string` |
| `LOOK_ENERGY` | `World.LOOK_ENERGY` | `string` |
| `LOOK_RESOURCES` | `World.LOOK_RESOURCES` | `string` |
| `LOOK_SOURCES` | `World.LOOK_SOURCES` | `string` |
| `LOOK_MINERALS` | `World.LOOK_MINERALS` | `string` |
| `LOOK_DEPOSITS` | `World.LOOK_DEPOSITS` | `string` |
| `LOOK_STRUCTURES` | `World.LOOK_STRUCTURES` | `string` |
| `LOOK_FLAGS` | `World.LOOK_FLAGS` | `string` |
| `LOOK_CONSTRUCTION_SITES` | `World.LOOK_CONSTRUCTION_SITES` | `string` |
| `LOOK_NUKES` | `World.LOOK_NUKES` | `string` |
| `LOOK_TERRAIN` | `World.LOOK_TERRAIN` | `string` |
| `LOOK_TOMBSTONES` | `World.LOOK_TOMBSTONES` | `string` |
| `LOOK_POWER_CREEPS` | `World.LOOK_POWER_CREEPS` | `string` |
| `LOOK_RUINS` | `World.LOOK_RUINS` | `string` |
| `ORDER_SELL` | `World.ORDER_SELL` | `string` |
| `ORDER_BUY` | `World.ORDER_BUY` | `string` |
| `MARKET_FEE` | `World.MARKET_FEE` | `double` |
| `MARKET_MAX_ORDERS` | `World.MARKET_MAX_ORDERS` | `double` |
| `MARKET_ORDER_LIFE_TIME` | `World.MARKET_ORDER_LIFE_TIME` | `double` |
| `INVADERS_ENERGY_GOAL` | `World.INVADERS_ENERGY_GOAL` | `double` |
| `SYSTEM_USERNAME` | `World.SYSTEM_USERNAME` | `string` |
| `TOMBSTONE_DECAY_PER_PART` | `World.TOMBSTONE_DECAY_PER_PART` | `double` |
| `TOMBSTONE_DECAY_POWER_CREEP` | `World.TOMBSTONE_DECAY_POWER_CREEP` | `double` |
| `RUIN_DECAY` | `World.RUIN_DECAY` | `double` |
| `RUIN_DECAY_STRUCTURES` | `World.RUIN_DECAY_STRUCTURES` | `dynamic` |
| `EVENT_ATTACK` | `World.EVENT_ATTACK` | `double` |
| `EVENT_OBJECT_DESTROYED` | `World.EVENT_OBJECT_DESTROYED` | `double` |
| `EVENT_ATTACK_CONTROLLER` | `World.EVENT_ATTACK_CONTROLLER` | `double` |
| `EVENT_BUILD` | `World.EVENT_BUILD` | `double` |
| `EVENT_HARVEST` | `World.EVENT_HARVEST` | `double` |
| `EVENT_HEAL` | `World.EVENT_HEAL` | `double` |
| `EVENT_REPAIR` | `World.EVENT_REPAIR` | `double` |
| `EVENT_RESERVE_CONTROLLER` | `World.EVENT_RESERVE_CONTROLLER` | `double` |
| `EVENT_UPGRADE_CONTROLLER` | `World.EVENT_UPGRADE_CONTROLLER` | `double` |
| `EVENT_EXIT` | `World.EVENT_EXIT` | `double` |
| `EVENT_POWER` | `World.EVENT_POWER` | `double` |
| `EVENT_TRANSFER` | `World.EVENT_TRANSFER` | `double` |
| `EVENT_ATTACK_TYPE_MELEE` | `World.EVENT_ATTACK_TYPE_MELEE` | `double` |
| `EVENT_ATTACK_TYPE_RANGED` | `World.EVENT_ATTACK_TYPE_RANGED` | `double` |
| `EVENT_ATTACK_TYPE_RANGED_MASS` | `World.EVENT_ATTACK_TYPE_RANGED_MASS` | `double` |
| `EVENT_ATTACK_TYPE_DISMANTLE` | `World.EVENT_ATTACK_TYPE_DISMANTLE` | `double` |
| `EVENT_ATTACK_TYPE_HIT_BACK` | `World.EVENT_ATTACK_TYPE_HIT_BACK` | `double` |
| `EVENT_ATTACK_TYPE_NUKE` | `World.EVENT_ATTACK_TYPE_NUKE` | `double` |
| `EVENT_HEAL_TYPE_MELEE` | `World.EVENT_HEAL_TYPE_MELEE` | `double` |
| `EVENT_HEAL_TYPE_RANGED` | `World.EVENT_HEAL_TYPE_RANGED` | `double` |
| `POWER_LEVEL_MULTIPLY` | `World.POWER_LEVEL_MULTIPLY` | `double` |
| `POWER_LEVEL_POW` | `World.POWER_LEVEL_POW` | `double` |
| `POWER_CREEP_SPAWN_COOLDOWN` | `World.POWER_CREEP_SPAWN_COOLDOWN` | `double` |
| `POWER_CREEP_DELETE_COOLDOWN` | `World.POWER_CREEP_DELETE_COOLDOWN` | `double` |
| `POWER_CREEP_MAX_LEVEL` | `World.POWER_CREEP_MAX_LEVEL` | `double` |
| `POWER_CREEP_LIFE_TIME` | `World.POWER_CREEP_LIFE_TIME` | `double` |
| `POWER_CLASS` | `World.POWER_CLASS` | `dynamic` |
| `PWR_GENERATE_OPS` | `World.PWR_GENERATE_OPS` | `double` |
| `PWR_OPERATE_SPAWN` | `World.PWR_OPERATE_SPAWN` | `double` |
| `PWR_OPERATE_TOWER` | `World.PWR_OPERATE_TOWER` | `double` |
| `PWR_OPERATE_STORAGE` | `World.PWR_OPERATE_STORAGE` | `double` |
| `PWR_OPERATE_LAB` | `World.PWR_OPERATE_LAB` | `double` |
| `PWR_OPERATE_EXTENSION` | `World.PWR_OPERATE_EXTENSION` | `double` |
| `PWR_OPERATE_OBSERVER` | `World.PWR_OPERATE_OBSERVER` | `double` |
| `PWR_OPERATE_TERMINAL` | `World.PWR_OPERATE_TERMINAL` | `double` |
| `PWR_DISRUPT_SPAWN` | `World.PWR_DISRUPT_SPAWN` | `double` |
| `PWR_DISRUPT_TOWER` | `World.PWR_DISRUPT_TOWER` | `double` |
| `PWR_DISRUPT_SOURCE` | `World.PWR_DISRUPT_SOURCE` | `double` |
| `PWR_SHIELD` | `World.PWR_SHIELD` | `double` |
| `PWR_REGEN_SOURCE` | `World.PWR_REGEN_SOURCE` | `double` |
| `PWR_REGEN_MINERAL` | `World.PWR_REGEN_MINERAL` | `double` |
| `PWR_DISRUPT_TERMINAL` | `World.PWR_DISRUPT_TERMINAL` | `double` |
| `PWR_OPERATE_POWER` | `World.PWR_OPERATE_POWER` | `double` |
| `PWR_FORTIFY` | `World.PWR_FORTIFY` | `double` |
| `PWR_OPERATE_CONTROLLER` | `World.PWR_OPERATE_CONTROLLER` | `double` |
| `PWR_OPERATE_FACTORY` | `World.PWR_OPERATE_FACTORY` | `double` |
| `EFFECT_INVULNERABILITY` | `World.EFFECT_INVULNERABILITY` | `double` |
| `EFFECT_COLLAPSE_TIMER` | `World.EFFECT_COLLAPSE_TIMER` | `double` |
| `INVADER_CORE_HITS` | `World.INVADER_CORE_HITS` | `double` |
| `INVADER_CORE_CREEP_SPAWN_TIME` | `World.INVADER_CORE_CREEP_SPAWN_TIME` | `dynamic` |
| `INVADER_CORE_EXPAND_TIME` | `World.INVADER_CORE_EXPAND_TIME` | `dynamic` |
| `INVADER_CORE_CONTROLLER_POWER` | `World.INVADER_CORE_CONTROLLER_POWER` | `double` |
| `INVADER_CORE_CONTROLLER_DOWNGRADE` | `World.INVADER_CORE_CONTROLLER_DOWNGRADE` | `double` |
| `STRONGHOLD_RAMPART_HITS` | `World.STRONGHOLD_RAMPART_HITS` | `dynamic` |
| `STRONGHOLD_DECAY_TICKS` | `World.STRONGHOLD_DECAY_TICKS` | `double` |
| `POWER_INFO` | `World.POWER_INFO` | `dynamic` |
| `ConstructionSite` | `World.ConstructionSite` | `ConstructionSiteConstructor` |
| `Creep` | `World.Creep` | `CreepConstructor` |
| `Deposit` | `World.Deposit` | `DepositConstructor` |
| `Flag` | `World.Flag` | `FlagConstructor` |
| `Game` | `World.Game` | `Game` |
| `InterShardMemory` | `World.InterShardMemory` | `InterShardMemory` |
| `Memory` | `World.Memory` | `Memory` |
| `Mineral` | `World.Mineral` | `MineralConstructor` |
| `Nuke` | `World.Nuke` | `NukeConstructor` |
| `PathFinder` | `World.PathFinder` | `PathFinder` |
| `PowerCreep` | `World.PowerCreep` | `PowerCreepConstructor` |
| `RawMemory` | `World.RawMemory` | `RawMemory` |
| `Resource` | `World.Resource` | `ResourceConstructor` |
| `RoomObject` | `World.RoomObject` | `RoomObjectConstructor` |
| `RoomPosition` | `World.RoomPosition` | `RoomPositionConstructor` |
| `Room` | `World.Room` | `RoomConstructor` |
| `Ruin` | `World.Ruin` | `RuinConstructor` |
| `Source` | `World.Source` | `SourceConstructor` |
| `StructureSpawn` | `World.StructureSpawn` | `StructureSpawnConstructor` |
| `Spawn` | `World.Spawn` | `StructureSpawnConstructor` |
| `Structure` | `World.Structure` | `StructureConstructor` |
| `OwnedStructure` | `World.OwnedStructure` | `OwnedStructureConstructor` |
| `StructureController` | `World.StructureController` | `StructureControllerConstructor` |
| `StructureExtension` | `World.StructureExtension` | `StructureExtensionConstructor` |
| `StructureLink` | `World.StructureLink` | `StructureLinkConstructor` |
| `StructureKeeperLair` | `World.StructureKeeperLair` | `StructureKeeperLairConstructor` |
| `StructureObserver` | `World.StructureObserver` | `StructureObserverConstructor` |
| `StructurePowerBank` | `World.StructurePowerBank` | `StructurePowerBankConstructor` |
| `StructurePowerSpawn` | `World.StructurePowerSpawn` | `StructurePowerSpawnConstructor` |
| `StructureRampart` | `World.StructureRampart` | `StructureRampartConstructor` |
| `StructureRoad` | `World.StructureRoad` | `StructureRoadConstructor` |
| `StructureStorage` | `World.StructureStorage` | `StructureStorageConstructor` |
| `StructureTower` | `World.StructureTower` | `StructureTowerConstructor` |
| `StructureWall` | `World.StructureWall` | `StructureWallConstructor` |
| `StructureExtractor` | `World.StructureExtractor` | `StructureExtractorConstructor` |
| `StructureLab` | `World.StructureLab` | `StructureLabConstructor` |
| `StructureTerminal` | `World.StructureTerminal` | `StructureTerminalConstructor` |
| `StructureContainer` | `World.StructureContainer` | `StructureContainerConstructor` |
| `StructureNuker` | `World.StructureNuker` | `StructureNukerConstructor` |
| `StructurePortal` | `World.StructurePortal` | `StructurePortalConstructor` |
| `StructureFactory` | `World.StructureFactory` | `StructureFactoryConstructor` |
| `StructureInvaderCore` | `World.StructureInvaderCore` | `StructureInvaderCoreConstructor` |
| `Tombstone` | `World.Tombstone` | `TombstoneConstructor` |

## 类型目录

[CommodityEntry](#commodityentry), [ConstructionSite](#constructionsite), [ConstructionSiteConstructor](#constructionsiteconstructor), [Creep](#creep), [CreepConstructor](#creepconstructor), [Deposit](#deposit), [DepositConstructor](#depositconstructor), [Flag](#flag), [FlagConstructor](#flagconstructor), [Game](#game), [_HasId](#_hasid), [_HasRoomPosition](#_hasroomposition), [GlobalControlLevel](#globalcontrollevel), [GlobalPowerLevel](#globalpowerlevel), [Shard](#shard), [CPU](#cpu), [HeapStatistics](#heapstatistics), [Owner](#owner), [ReservationDefinition](#reservationdefinition), [SignDefinition](#signdefinition), [CPUShardLimits](#cpushardlimits), [AllLookAtTypes](#alllookattypes), [LookAtResultMatrix](#lookatresultmatrix), [LookForAtAreaResultMatrix](#lookforatarearesultmatrix), [FindTypes](#findtypes), [FindPathOpts](#findpathopts), [MoveToOpts](#movetoopts), [PathStep](#pathstep), [_Constructor](#_constructor), [_ConstructorById](#_constructorbyid), [InterShardMemory](#intershardmemory), [FilterOptions](#filteroptions), [EventData](#eventdata), [POWER_CLASS](#power_class), [RouteOptions](#routeoptions), [RoomStatusPermanent](#roomstatuspermanent), [RoomStatusTemporary](#roomstatustemporary), [GameMap](#gamemap), [MapVisual](#mapvisual), [MapLineStyle](#maplinestyle), [MapPolyStyle](#mappolystyle), [MapCircleStyle](#mapcirclestyle), [MapTextStyle](#maptextstyle), [Market](#market), [Transaction](#transaction), [Order](#order), [TransactionOrder](#transactionorder), [OrderFilter](#orderfilter), [PriceHistory](#pricehistory), [CreateOrderParam](#createorderparam), [Memory](#memory), [CreepMemory](#creepmemory), [FlagMemory](#flagmemory), [PowerCreepMemory](#powercreepmemory), [RoomMemory](#roommemory), [SpawnMemory](#spawnmemory), [Mineral](#mineral), [MineralConstructor](#mineralconstructor), [Nuke](#nuke), [NukeConstructor](#nukeconstructor), [PathFinder](#pathfinder), [PathFinderPath](#pathfinderpath), [PathFinderOpts](#pathfinderopts), [CostMatrixConstructor](#costmatrixconstructor), [CostMatrix](#costmatrix), [PowerCreep](#powercreep), [PowerCreepConstructor](#powercreepconstructor), [PowerCreepPowers](#powercreeppowers), [RawMemory](#rawmemory), [Resource](#resource), [ResourceConstructor](#resourceconstructor), [RoomObject](#roomobject), [RoomObjectConstructor](#roomobjectconstructor), [NaturalEffect](#naturaleffect), [PowerEffect](#powereffect), [RoomPosition](#roomposition), [RoomPositionConstructor](#roompositionconstructor), [RoomTerrain](#roomterrain), [RoomTerrainConstructor](#roomterrainconstructor), [RoomVisual](#roomvisual), [LineStyle](#linestyle), [PolyStyle](#polystyle), [CircleStyle](#circlestyle), [TextStyle](#textstyle), [Room](#room), [RoomConstructor](#roomconstructor), [Ruin](#ruin), [RuinConstructor](#ruinconstructor), [Source](#source), [SourceConstructor](#sourceconstructor), [StructureSpawn](#structurespawn), [StructureSpawnConstructor](#structurespawnconstructor), [Spawning](#spawning), [SpawnOptions](#spawnoptions), [SpawningConstructor](#spawningconstructor), [StoreBase](#storebase), [GenericStoreBase](#genericstorebase), [Structure](#structure), [StructureConstructor](#structureconstructor), [OwnedStructure](#ownedstructure), [OwnedStructureConstructor](#ownedstructureconstructor), [StructureController](#structurecontroller), [StructureControllerConstructor](#structurecontrollerconstructor), [StructureExtension](#structureextension), [StructureExtensionConstructor](#structureextensionconstructor), [StructureLink](#structurelink), [StructureLinkConstructor](#structurelinkconstructor), [StructureKeeperLair](#structurekeeperlair), [StructureKeeperLairConstructor](#structurekeeperlairconstructor), [StructureObserver](#structureobserver), [StructureObserverConstructor](#structureobserverconstructor), [StructurePowerBank](#structurepowerbank), [StructurePowerBankConstructor](#structurepowerbankconstructor), [StructurePowerSpawn](#structurepowerspawn), [StructurePowerSpawnConstructor](#structurepowerspawnconstructor), [StructureRampart](#structurerampart), [StructureRampartConstructor](#structurerampartconstructor), [StructureRoad](#structureroad), [StructureRoadConstructor](#structureroadconstructor), [StructureStorage](#structurestorage), [StructureStorageConstructor](#structurestorageconstructor), [StructureTower](#structuretower), [StructureTowerConstructor](#structuretowerconstructor), [StructureWall](#structurewall), [StructureWallConstructor](#structurewallconstructor), [StructureExtractor](#structureextractor), [StructureExtractorConstructor](#structureextractorconstructor), [StructureLab](#structurelab), [StructureLabConstructor](#structurelabconstructor), [StructureTerminal](#structureterminal), [StructureTerminalConstructor](#structureterminalconstructor), [StructureContainer](#structurecontainer), [StructureContainerConstructor](#structurecontainerconstructor), [StructureNuker](#structurenuker), [StructureNukerConstructor](#structurenukerconstructor), [StructurePortal](#structureportal), [StructurePortalConstructor](#structureportalconstructor), [StructureFactory](#structurefactory), [StructureFactoryConstructor](#structurefactoryconstructor), [StructureInvaderCore](#structureinvadercore), [StructureInvaderCoreConstructor](#structureinvadercoreconstructor), [ConcreteStructureMap](#concretestructuremap), [Tombstone](#tombstone), [TombstoneConstructor](#tombstoneconstructor)

## CommodityEntry

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.level` | `obj.level` | `double?，可赋值` |
| `obj.amount` | `obj.amount` | `double，可赋值` |
| `obj.cooldown` | `obj.cooldown` | `double，可赋值` |
| `obj.components` | `obj.components` | `dynamic，可赋值` |

## ConstructionSite

继承 [RoomObject](#roomobject)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `ConstructionSite，只读` |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.my` | `obj.my` | `bool，可赋值` |
| `obj.owner` | `obj.owner` | `Owner，可赋值` |
| `obj.progress` | `obj.progress` | `double，可赋值` |
| `obj.progressTotal` | `obj.progressTotal` | `double，可赋值` |
| `obj.structureType` | `obj.structureType` | `dynamic，可赋值` |
| `obj.remove()` | `obj.remove()` | `double` |

## ConstructionSiteConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `ConstructionSite` |

## Creep

继承 [RoomObject](#roomobject)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `Creep，只读` |
| `obj.body` | `obj.body` | `dynamic[]，可赋值` |
| `obj.carry` | `obj.carry` | `GenericStoreBase，可赋值` |
| `obj.carryCapacity` | `obj.carryCapacity` | `double，可赋值` |
| `obj.fatigue` | `obj.fatigue` | `double，可赋值` |
| `obj.hits` | `obj.hits` | `double，可赋值` |
| `obj.hitsMax` | `obj.hitsMax` | `double，可赋值` |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.memory` | `obj.memory` | `CreepMemory，可赋值` |
| `obj.my` | `obj.my` | `bool，可赋值` |
| `obj.name` | `obj.name` | `string，可赋值` |
| `obj.owner` | `obj.owner` | `Owner，可赋值` |
| `obj.room` | `obj.room` | `Room，可赋值` |
| `obj.spawning` | `obj.spawning` | `bool，可赋值` |
| `obj.saying` | `obj.saying` | `string，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.ticksToLive` | `obj.ticksToLive` | `double?，可赋值` |
| `obj.attack(target)` | `obj.attack(object target)` | `double` |
| `obj.attackController(target)` | `obj.attackController(StructureController target)` | `double` |
| `obj.build(target)` | `obj.build(ConstructionSite target)` | `double` |
| `obj.cancelOrder(methodName)` | `obj.cancelOrder(string methodName)` | `double` |
| `obj.claimController(target)` | `obj.claimController(StructureController target)` | `double` |
| `obj.dismantle(target)` | `obj.dismantle(Structure target)` | `double` |
| `obj.drop(resourceType)` | `obj.drop(string resourceType)` | `double` |
| `obj.drop(resourceType, amount)` | `obj.drop(string resourceType, double amount)` | `double` |
| `obj.generateSafeMode(target)` | `obj.generateSafeMode(StructureController target)` | `double` |
| `obj.getActiveBodyparts(type)` | `obj.getActiveBodyparts(string type)` | `double` |
| `obj.harvest(target)` | `obj.harvest(object target)` | `double` |
| `obj.heal(target)` | `obj.heal(object target)` | `double` |
| `obj.move(direction)` | `obj.move(object direction)` | `double` |
| `obj.moveByPath(path)` | `obj.moveByPath(object path)` | `double` |
| `obj.moveTo(x, y)` | `obj.moveTo(object x, object y)` | `double` |
| `obj.moveTo(x, y, opts)` | `obj.moveTo(double x, double y, MoveToOpts opts)` | `double` |
| `obj.moveTo(target)` | `obj.moveTo(object target)` | `double` |
| `obj.notifyWhenAttacked(enabled)` | `obj.notifyWhenAttacked(bool enabled)` | `double` |
| `obj.pickup(target)` | `obj.pickup(Resource target)` | `double` |
| `obj.pull(target)` | `obj.pull(Creep target)` | `double` |
| `obj.rangedAttack(target)` | `obj.rangedAttack(object target)` | `double` |
| `obj.rangedHeal(target)` | `obj.rangedHeal(object target)` | `double` |
| `obj.rangedMassAttack()` | `obj.rangedMassAttack()` | `double` |
| `obj.repair(target)` | `obj.repair(Structure target)` | `double` |
| `obj.reserveController(target)` | `obj.reserveController(StructureController target)` | `double` |
| `obj.say(message)` | `obj.say(string message)` | `double` |
| `obj.say(message, toPublic)` | `obj.say(string message, bool toPublic)` | `double` |
| `obj.signController(target, text)` | `obj.signController(StructureController target, string text)` | `double` |
| `obj.suicide()` | `obj.suicide()` | `double` |
| `obj.transfer(target, resourceType)` | `obj.transfer(object target, string resourceType)` | `double` |
| `obj.transfer(target, resourceType, amount)` | `obj.transfer(object target, string resourceType, double amount)` | `double` |
| `obj.upgradeController(target)` | `obj.upgradeController(StructureController target)` | `double` |
| `obj.withdraw(target, resourceType)` | `obj.withdraw(object target, string resourceType)` | `double` |
| `obj.withdraw(target, resourceType, amount)` | `obj.withdraw(object target, string resourceType, double amount)` | `double` |

## CreepConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `Creep` |

## Deposit

继承 [RoomObject](#roomobject)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.depositType` | `obj.depositType` | `string，可赋值` |
| `obj.cooldown` | `obj.cooldown` | `double，可赋值` |
| `obj.lastCooldown` | `obj.lastCooldown` | `double，可赋值` |
| `obj.ticksToDecay` | `obj.ticksToDecay` | `double，可赋值` |

## DepositConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `Deposit` |

## Flag

继承 [RoomObject](#roomobject)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `Flag，只读` |
| `obj.color` | `obj.color` | `double，可赋值` |
| `obj.memory` | `obj.memory` | `FlagMemory，可赋值` |
| `obj.name` | `obj.name` | `string，可赋值` |
| `obj.secondaryColor` | `obj.secondaryColor` | `double，可赋值` |
| `obj.remove()` | `obj.remove()` | `double` |
| `obj.setColor(color)` | `obj.setColor(double color)` | `double` |
| `obj.setColor(color, secondaryColor)` | `obj.setColor(double color, double secondaryColor)` | `double` |
| `obj.setPosition(x, y)` | `obj.setPosition(double x, double y)` | `double` |
| `obj.setPosition(pos)` | `obj.setPosition(object pos)` | `double` |

## FlagConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(name, color, secondaryColor, roomName, x, y)` | `ctor.New(string name, double color, double secondaryColor, string roomName, double x, double y)` | `Flag` |

## Game

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.cpu` | `obj.cpu` | `CPU，可赋值` |
| `obj.creeps` | `obj.creeps` | `NativeMap<Creep>，可赋值` |
| `obj.flags` | `obj.flags` | `NativeMap<Flag>，可赋值` |
| `obj.gcl` | `obj.gcl` | `GlobalControlLevel，可赋值` |
| `obj.gpl` | `obj.gpl` | `GlobalPowerLevel，可赋值` |
| `obj.map` | `obj.map` | `GameMap，可赋值` |
| `obj.market` | `obj.market` | `Market，可赋值` |
| `obj.powerCreeps` | `obj.powerCreeps` | `NativeMap<PowerCreep>，可赋值` |
| `obj.resources` | `obj.resources` | `NativeMap<dynamic>，可赋值` |
| `obj.rooms` | `obj.rooms` | `NativeMap<Room>，可赋值` |
| `obj.spawns` | `obj.spawns` | `NativeMap<StructureSpawn>，可赋值` |
| `obj.structures` | `obj.structures` | `NativeMap<OwnedStructure>，可赋值` |
| `obj.constructionSites` | `obj.constructionSites` | `NativeMap<ConstructionSite>，可赋值` |
| `obj.shard` | `obj.shard` | `Shard，可赋值` |
| `obj.time` | `obj.time` | `double，可赋值` |
| `obj.getObjectById(id)` | `obj.getObjectById(object id)` | `dynamic` |
| `obj.notify(message)` | `obj.notify(string message)` | `double` |
| `obj.notify(message, groupInterval)` | `obj.notify(string message, double groupInterval)` | `double` |

## _HasId

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.id` | `obj.id` | `string，可赋值` |

## _HasRoomPosition

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.pos` | `obj.pos` | `RoomPosition，可赋值` |

## GlobalControlLevel

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.level` | `obj.level` | `double，可赋值` |
| `obj.progress` | `obj.progress` | `double，可赋值` |
| `obj.progressTotal` | `obj.progressTotal` | `double，可赋值` |

## GlobalPowerLevel

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.level` | `obj.level` | `double，可赋值` |
| `obj.progress` | `obj.progress` | `double，可赋值` |
| `obj.progressTotal` | `obj.progressTotal` | `double，可赋值` |

## Shard

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.name` | `obj.name` | `string，可赋值` |
| `obj.type` | `obj.type` | `string，可赋值` |
| `obj.ptr` | `obj.ptr` | `bool，可赋值` |
| `obj.access` | `obj.access` | `bool?，可赋值` |
| `obj.accessTime` | `obj.accessTime` | `double?，可赋值` |
| `obj.activateAccess()` | `obj.activateAccess()` | `double` |

## CPU

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.limit` | `obj.limit` | `double，可赋值` |
| `obj.tickLimit` | `obj.tickLimit` | `double，可赋值` |
| `obj.bucket` | `obj.bucket` | `double，可赋值` |
| `obj.shardLimits` | `obj.shardLimits` | `CPUShardLimits，可赋值` |
| `obj.unlocked` | `obj.unlocked` | `bool，可赋值` |
| `obj.unlockedTime` | `obj.unlockedTime` | `double?，可赋值` |
| `obj.getUsed()` | `obj.getUsed()` | `double` |
| `obj.setShardLimits(limits)` | `obj.setShardLimits(CPUShardLimits limits)` | `double` |
| `obj.getHeapStatistics()` | `obj.getHeapStatistics()` | `HeapStatistics` |
| `obj.halt()` | `obj.halt()` | `dynamic` |
| `obj.generatePixel()` | `obj.generatePixel()` | `double` |
| `obj.unlock()` | `obj.unlock()` | `double` |

## HeapStatistics

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.total_heap_size` | `obj.total_heap_size` | `double，可赋值` |
| `obj.total_heap_size_executable` | `obj.total_heap_size_executable` | `double，可赋值` |
| `obj.total_physical_size` | `obj.total_physical_size` | `double，可赋值` |
| `obj.total_available_size` | `obj.total_available_size` | `double，可赋值` |
| `obj.used_heap_size` | `obj.used_heap_size` | `double，可赋值` |
| `obj.heap_size_limit` | `obj.heap_size_limit` | `double，可赋值` |
| `obj.malloced_memory` | `obj.malloced_memory` | `double，可赋值` |
| `obj.peak_malloced_memory` | `obj.peak_malloced_memory` | `double，可赋值` |
| `obj.does_zap_garbage` | `obj.does_zap_garbage` | `double，可赋值` |
| `obj.externally_allocated_size` | `obj.externally_allocated_size` | `double，可赋值` |

## Owner

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.username` | `obj.username` | `string，可赋值` |

## ReservationDefinition

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.username` | `obj.username` | `string，可赋值` |
| `obj.ticksToEnd` | `obj.ticksToEnd` | `double，可赋值` |

## SignDefinition

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.username` | `obj.username` | `string，可赋值` |
| `obj.text` | `obj.text` | `string，可赋值` |
| `obj.time` | `obj.time` | `double，可赋值` |
| `obj.datetime` | `obj.datetime` | `dynamic，可赋值` |

## CPUShardLimits

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj[key]` | `obj[string key]` | `double` |

## AllLookAtTypes

该类型用于原生对象视图；成员可能来自基类或动态访问。

## LookAtResultMatrix

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj[key]` | `obj[double key]` | `NativeMap<dynamic[]>` |

## LookForAtAreaResultMatrix

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj[key]` | `obj[double key]` | `NativeMap<dynamic[]>` |

## FindTypes

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj[key]` | `obj[double key]` | `dynamic` |

## FindPathOpts

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.ignoreCreeps` | `obj.ignoreCreeps` | `bool?，可赋值` |
| `obj.ignoreDestructibleStructures` | `obj.ignoreDestructibleStructures` | `bool?，可赋值` |
| `obj.ignoreRoads` | `obj.ignoreRoads` | `bool?，可赋值` |
| `obj.costCallback` | `obj.costCallback` | `dynamic，可赋值` |
| `obj.ignore` | `obj.ignore` | `dynamic，可赋值` |
| `obj.avoid` | `obj.avoid` | `dynamic，可赋值` |
| `obj.maxOps` | `obj.maxOps` | `double?，可赋值` |
| `obj.heuristicWeight` | `obj.heuristicWeight` | `double?，可赋值` |
| `obj.serialize` | `obj.serialize` | `bool?，可赋值` |
| `obj.maxRooms` | `obj.maxRooms` | `double?，可赋值` |
| `obj.range` | `obj.range` | `double?，可赋值` |
| `obj.plainCost` | `obj.plainCost` | `double?，可赋值` |
| `obj.swampCost` | `obj.swampCost` | `double?，可赋值` |

配置回调赋值用 `Native.Set(options, "回调名称", callback)`，详见 [回调写法](API.md#memory选项与回调)。

## MoveToOpts

继承 [FindPathOpts](#findpathopts)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.reusePath` | `obj.reusePath` | `double?，可赋值` |
| `obj.serializeMemory` | `obj.serializeMemory` | `bool?，可赋值` |
| `obj.noPathFinding` | `obj.noPathFinding` | `bool?，可赋值` |
| `obj.visualizePathStyle` | `obj.visualizePathStyle` | `PolyStyle，可赋值` |

## PathStep

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.x` | `obj.x` | `double，可赋值` |
| `obj.dx` | `obj.dx` | `double，可赋值` |
| `obj.y` | `obj.y` | `double，可赋值` |
| `obj.dy` | `obj.dy` | `double，可赋值` |
| `obj.direction` | `obj.direction` | `double，可赋值` |

## _Constructor

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `dynamic，只读` |

## _ConstructorById

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `dynamic` |

## InterShardMemory

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj[key]` | `obj[string key]` | `dynamic` |
| `obj.getLocal()` | `obj.getLocal()` | `string` |
| `obj.setLocal(value)` | `obj.setLocal(string value)` | `void` |
| `obj.getRemote(shard)` | `obj.getRemote(string shard)` | `string` |

## FilterOptions

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.filter` | `obj.filter` | `dynamic，可赋值` |

## EventData

该类型用于原生对象视图；成员可能来自基类或动态访问。

## POWER_CLASS

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.OPERATOR` | `obj.OPERATOR` | `string，可赋值` |

## RouteOptions

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.routeCallback` | `obj.routeCallback` | `dynamic，可赋值` |

配置回调赋值用 `Native.Set(options, "回调名称", callback)`，详见 [回调写法](API.md#memory选项与回调)。

## RoomStatusPermanent

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.status` | `obj.status` | `string，可赋值` |
| `obj.timestamp` | `obj.timestamp` | `dynamic，可赋值` |

## RoomStatusTemporary

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.status` | `obj.status` | `string，可赋值` |
| `obj.timestamp` | `obj.timestamp` | `double，可赋值` |

## GameMap

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.visual` | `obj.visual` | `MapVisual，可赋值` |
| `obj.describeExits(roomName)` | `obj.describeExits(string roomName)` | `dynamic` |
| `obj.findExit(fromRoom, toRoom)` | `obj.findExit(object fromRoom, object toRoom)` | `double` |
| `obj.findExit(fromRoom, toRoom, opts)` | `obj.findExit(object fromRoom, object toRoom, RouteOptions opts)` | `double` |
| `obj.findRoute(fromRoom, toRoom)` | `obj.findRoute(object fromRoom, object toRoom)` | `dynamic` |
| `obj.findRoute(fromRoom, toRoom, opts)` | `obj.findRoute(object fromRoom, object toRoom, RouteOptions opts)` | `dynamic` |
| `obj.getRoomLinearDistance(roomName1, roomName2)` | `obj.getRoomLinearDistance(string roomName1, string roomName2)` | `double` |
| `obj.getRoomLinearDistance(roomName1, roomName2, continuous)` | `obj.getRoomLinearDistance(string roomName1, string roomName2, bool continuous)` | `double` |
| `obj.getTerrainAt(x, y, roomName)` | `obj.getTerrainAt(double x, double y, string roomName)` | `string` |
| `obj.getTerrainAt(pos)` | `obj.getTerrainAt(RoomPosition pos)` | `string` |
| `obj.getRoomTerrain(roomName)` | `obj.getRoomTerrain(string roomName)` | `RoomTerrain` |
| `obj.getWorldSize()` | `obj.getWorldSize()` | `double` |
| `obj.isRoomAvailable(roomName)` | `obj.isRoomAvailable(string roomName)` | `bool` |
| `obj.getRoomStatus(roomName)` | `obj.getRoomStatus(string roomName)` | `dynamic` |

## MapVisual

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.line(pos1, pos2)` | `obj.line(RoomPosition pos1, RoomPosition pos2)` | `MapVisual` |
| `obj.line(pos1, pos2, style)` | `obj.line(RoomPosition pos1, RoomPosition pos2, MapLineStyle style)` | `MapVisual` |
| `obj.circle(pos)` | `obj.circle(RoomPosition pos)` | `MapVisual` |
| `obj.circle(pos, style)` | `obj.circle(RoomPosition pos, MapCircleStyle style)` | `MapVisual` |
| `obj.rect(topLeftPos, width, height)` | `obj.rect(RoomPosition topLeftPos, double width, double height)` | `MapVisual` |
| `obj.rect(topLeftPos, width, height, style)` | `obj.rect(RoomPosition topLeftPos, double width, double height, MapPolyStyle style)` | `MapVisual` |
| `obj.poly(points)` | `obj.poly(RoomPosition[] points)` | `MapVisual` |
| `obj.poly(points, style)` | `obj.poly(RoomPosition[] points, MapPolyStyle style)` | `MapVisual` |
| `obj.text(text, pos)` | `obj.text(string text, RoomPosition pos)` | `MapVisual` |
| `obj.text(text, pos, style)` | `obj.text(string text, RoomPosition pos, MapTextStyle style)` | `MapVisual` |
| `obj.clear()` | `obj.clear()` | `MapVisual` |
| `obj.getSize()` | `obj.getSize()` | `double` |
| `obj.export()` | `obj.export()` | `string` |
| `obj.import(data)` | `obj.import(string data)` | `MapVisual` |

## MapLineStyle

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.width` | `obj.width` | `double?，可赋值` |
| `obj.color` | `obj.color` | `string，可赋值` |
| `obj.opacity` | `obj.opacity` | `double?，可赋值` |
| `obj.lineStyle` | `obj.lineStyle` | `string，可赋值` |

## MapPolyStyle

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.fill` | `obj.fill` | `string，可赋值` |
| `obj.opacity` | `obj.opacity` | `double?，可赋值` |
| `obj.stroke` | `obj.stroke` | `string，可赋值` |
| `obj.strokeWidth` | `obj.strokeWidth` | `double?，可赋值` |
| `obj.lineStyle` | `obj.lineStyle` | `string，可赋值` |

## MapCircleStyle

继承 [MapPolyStyle](#mappolystyle)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.radius` | `obj.radius` | `double?，可赋值` |

## MapTextStyle

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.color` | `obj.color` | `string，可赋值` |
| `obj.fontFamily` | `obj.fontFamily` | `string，可赋值` |
| `obj.fontSize` | `obj.fontSize` | `double?，可赋值` |
| `obj.fontStyle` | `obj.fontStyle` | `string，可赋值` |
| `obj.fontVariant` | `obj.fontVariant` | `string，可赋值` |
| `obj.stroke` | `obj.stroke` | `string，可赋值` |
| `obj.strokeWidth` | `obj.strokeWidth` | `double?，可赋值` |
| `obj.backgroundColor` | `obj.backgroundColor` | `string，可赋值` |
| `obj.backgroundPadding` | `obj.backgroundPadding` | `double?，可赋值` |
| `obj.align` | `obj.align` | `string，可赋值` |
| `obj.opacity` | `obj.opacity` | `double?，可赋值` |

## Market

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.credits` | `obj.credits` | `double，可赋值` |
| `obj.incomingTransactions` | `obj.incomingTransactions` | `Transaction[]，可赋值` |
| `obj.orders` | `obj.orders` | `NativeMap<Order>，可赋值` |
| `obj.outgoingTransactions` | `obj.outgoingTransactions` | `Transaction[]，可赋值` |
| `obj.calcTransactionCost(amount, roomName1, roomName2)` | `obj.calcTransactionCost(double amount, string roomName1, string roomName2)` | `double` |
| `obj.cancelOrder(orderId)` | `obj.cancelOrder(string orderId)` | `double` |
| `obj.changeOrderPrice(orderId, newPrice)` | `obj.changeOrderPrice(string orderId, double newPrice)` | `double` |
| `obj.createOrder(params)` | `obj.createOrder(CreateOrderParam params)` | `double` |
| `obj.deal(orderId, amount)` | `obj.deal(string orderId, double amount)` | `double` |
| `obj.deal(orderId, amount, yourRoomName)` | `obj.deal(string orderId, double amount, string yourRoomName)` | `double` |
| `obj.extendOrder(orderId, addAmount)` | `obj.extendOrder(string orderId, double addAmount)` | `double` |
| `obj.getAllOrders()` | `obj.getAllOrders()` | `Order[]` |
| `obj.getAllOrders(filter)` | `obj.getAllOrders(object filter)` | `Order[]` |
| `obj.getHistory()` | `obj.getHistory()` | `PriceHistory[]` |
| `obj.getHistory(resource)` | `obj.getHistory(object resource)` | `PriceHistory[]` |
| `obj.getOrderById(id)` | `obj.getOrderById(string id)` | `Order` |

## Transaction

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.transactionId` | `obj.transactionId` | `string，可赋值` |
| `obj.time` | `obj.time` | `double，可赋值` |
| `obj.sender` | `obj.sender` | `dynamic，可赋值` |
| `obj.recipient` | `obj.recipient` | `dynamic，可赋值` |
| `obj.resourceType` | `obj.resourceType` | `dynamic，可赋值` |
| `obj.amount` | `obj.amount` | `double，可赋值` |
| `obj.from` | `obj.from` | `string，可赋值` |
| `obj.to` | `obj.to` | `string，可赋值` |
| `obj.description` | `obj.description` | `string，可赋值` |
| `obj.order` | `obj.order` | `TransactionOrder，可赋值` |

## Order

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.created` | `obj.created` | `double，可赋值` |
| `obj.active` | `obj.active` | `bool?，可赋值` |
| `obj.type` | `obj.type` | `string，可赋值` |
| `obj.resourceType` | `obj.resourceType` | `dynamic，可赋值` |
| `obj.roomName` | `obj.roomName` | `string，可赋值` |
| `obj.amount` | `obj.amount` | `double，可赋值` |
| `obj.remainingAmount` | `obj.remainingAmount` | `double，可赋值` |
| `obj.totalAmount` | `obj.totalAmount` | `double?，可赋值` |
| `obj.price` | `obj.price` | `double，可赋值` |

## TransactionOrder

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.type` | `obj.type` | `string，可赋值` |
| `obj.price` | `obj.price` | `double，可赋值` |

## OrderFilter

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.created` | `obj.created` | `double?，可赋值` |
| `obj.type` | `obj.type` | `string，可赋值` |
| `obj.resourceType` | `obj.resourceType` | `dynamic，可赋值` |
| `obj.roomName` | `obj.roomName` | `string，可赋值` |
| `obj.amount` | `obj.amount` | `double?，可赋值` |
| `obj.remainingAmount` | `obj.remainingAmount` | `double?，可赋值` |
| `obj.price` | `obj.price` | `double?，可赋值` |

## PriceHistory

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.resourceType` | `obj.resourceType` | `dynamic，可赋值` |
| `obj.date` | `obj.date` | `string，可赋值` |
| `obj.transactions` | `obj.transactions` | `double，可赋值` |
| `obj.volume` | `obj.volume` | `double，可赋值` |
| `obj.avgPrice` | `obj.avgPrice` | `double，可赋值` |
| `obj.stddevPrice` | `obj.stddevPrice` | `double，可赋值` |

## CreateOrderParam

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.type` | `obj.type` | `string，可赋值` |
| `obj.resourceType` | `obj.resourceType` | `dynamic，可赋值` |
| `obj.price` | `obj.price` | `double，可赋值` |
| `obj.totalAmount` | `obj.totalAmount` | `double，可赋值` |
| `obj.roomName` | `obj.roomName` | `string，可赋值` |

## Memory

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.creeps` | `obj.creeps` | `NativeMap<CreepMemory>，可赋值` |
| `obj.powerCreeps` | `obj.powerCreeps` | `NativeMap<PowerCreepMemory>，可赋值` |
| `obj.flags` | `obj.flags` | `NativeMap<FlagMemory>，可赋值` |
| `obj.rooms` | `obj.rooms` | `NativeMap<RoomMemory>，可赋值` |
| `obj.spawns` | `obj.spawns` | `NativeMap<SpawnMemory>，可赋值` |
| `obj[key]` | `obj[string key]` | `dynamic` |

## CreepMemory

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj[key]` | `obj[string key]` | `dynamic` |

## FlagMemory

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj[key]` | `obj[string key]` | `dynamic` |

## PowerCreepMemory

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj[key]` | `obj[string key]` | `dynamic` |

## RoomMemory

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj[key]` | `obj[string key]` | `dynamic` |

## SpawnMemory

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj[key]` | `obj[string key]` | `dynamic` |

## Mineral

继承 [RoomObject](#roomobject)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `Mineral，只读` |
| `obj.density` | `obj.density` | `double，可赋值` |
| `obj.mineralAmount` | `obj.mineralAmount` | `double，可赋值` |
| `obj.mineralType` | `obj.mineralType` | `dynamic，可赋值` |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.ticksToRegeneration` | `obj.ticksToRegeneration` | `double?，可赋值` |

## MineralConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `Mineral` |

## Nuke

继承 [RoomObject](#roomobject)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `Nuke，只读` |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.launchRoomName` | `obj.launchRoomName` | `string，可赋值` |
| `obj.timeToLand` | `obj.timeToLand` | `double，可赋值` |

## NukeConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `Nuke` |

## PathFinder

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.CostMatrix` | `obj.CostMatrix` | `CostMatrixConstructor，可赋值` |
| `obj.search(origin, goal)` | `obj.search(RoomPosition origin, object goal)` | `PathFinderPath` |
| `obj.search(origin, goal, opts)` | `obj.search(RoomPosition origin, object goal, PathFinderOpts opts)` | `PathFinderPath` |
| `obj.use(isEnabled)` | `obj.use(bool isEnabled)` | `dynamic` |

## PathFinderPath

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.path` | `obj.path` | `RoomPosition[]，可赋值` |
| `obj.ops` | `obj.ops` | `double，可赋值` |
| `obj.cost` | `obj.cost` | `double，可赋值` |
| `obj.incomplete` | `obj.incomplete` | `bool，可赋值` |

## PathFinderOpts

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.plainCost` | `obj.plainCost` | `double?，可赋值` |
| `obj.swampCost` | `obj.swampCost` | `double?，可赋值` |
| `obj.flee` | `obj.flee` | `bool?，可赋值` |
| `obj.maxOps` | `obj.maxOps` | `double?，可赋值` |
| `obj.maxRooms` | `obj.maxRooms` | `double?，可赋值` |
| `obj.maxCost` | `obj.maxCost` | `double?，可赋值` |
| `obj.heuristicWeight` | `obj.heuristicWeight` | `double?，可赋值` |
| `obj.roomCallback(roomName)` | `obj.roomCallback(string roomName)` | `dynamic` |

配置回调赋值用 `Native.Set(options, "回调名称", callback)`，详见 [回调写法](API.md#memory选项与回调)。

## CostMatrixConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)()` | `ctor.New()` | `CostMatrix` |
| `obj.deserialize(val)` | `obj.deserialize(double[] val)` | `CostMatrix` |

## CostMatrix

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.set(x, y, cost)` | `obj.set(double x, double y, double cost)` | `dynamic` |
| `obj.get(x, y)` | `obj.get(double x, double y)` | `double` |
| `obj.clone()` | `obj.clone()` | `CostMatrix` |
| `obj.serialize()` | `obj.serialize()` | `double[]` |

## PowerCreep

继承 [RoomObject](#roomobject)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.carry` | `obj.carry` | `GenericStoreBase，可赋值` |
| `obj.carryCapacity` | `obj.carryCapacity` | `double，可赋值` |
| `obj.className` | `obj.className` | `dynamic，可赋值` |
| `obj.deleteTime` | `obj.deleteTime` | `double?，可赋值` |
| `obj.hits` | `obj.hits` | `double，可赋值` |
| `obj.hitsMax` | `obj.hitsMax` | `double，可赋值` |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.level` | `obj.level` | `double，可赋值` |
| `obj.memory` | `obj.memory` | `PowerCreepMemory，可赋值` |
| `obj.my` | `obj.my` | `bool，可赋值` |
| `obj.name` | `obj.name` | `string，可赋值` |
| `obj.owner` | `obj.owner` | `Owner，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.powers` | `obj.powers` | `PowerCreepPowers，可赋值` |
| `obj.saying` | `obj.saying` | `string，可赋值` |
| `obj.shard` | `obj.shard` | `string，可赋值` |
| `obj.spawnCooldownTime` | `obj.spawnCooldownTime` | `double?，可赋值` |
| `obj.ticksToLive` | `obj.ticksToLive` | `double?，可赋值` |
| `obj.cancelOrder(methodName)` | `obj.cancelOrder(string methodName)` | `double` |
| `obj.delete()` | `obj.delete()` | `double` |
| `obj.delete(cancel)` | `obj.delete(bool cancel)` | `double` |
| `obj.drop(resourceType)` | `obj.drop(string resourceType)` | `double` |
| `obj.drop(resourceType, amount)` | `obj.drop(string resourceType, double amount)` | `double` |
| `obj.enableRoom(controller)` | `obj.enableRoom(StructureController controller)` | `double` |
| `obj.move(direction)` | `obj.move(object direction)` | `double` |
| `obj.moveByPath(path)` | `obj.moveByPath(object path)` | `double` |
| `obj.moveTo(x, y)` | `obj.moveTo(object x, object y)` | `double` |
| `obj.moveTo(x, y, opts)` | `obj.moveTo(double x, double y, MoveToOpts opts)` | `double` |
| `obj.moveTo(target)` | `obj.moveTo(object target)` | `double` |
| `obj.notifyWhenAttacked(enabled)` | `obj.notifyWhenAttacked(bool enabled)` | `double` |
| `obj.pickup(target)` | `obj.pickup(Resource target)` | `double` |
| `obj.rename(name)` | `obj.rename(string name)` | `double` |
| `obj.renew(target)` | `obj.renew(object target)` | `double` |
| `obj.say(message)` | `obj.say(string message)` | `double` |
| `obj.say(message, toPublic)` | `obj.say(string message, bool toPublic)` | `double` |
| `obj.spawn(powerSpawn)` | `obj.spawn(StructurePowerSpawn powerSpawn)` | `double` |
| `obj.suicide()` | `obj.suicide()` | `double` |
| `obj.transfer(target, resourceType)` | `obj.transfer(object target, string resourceType)` | `double` |
| `obj.transfer(target, resourceType, amount)` | `obj.transfer(object target, string resourceType, double amount)` | `double` |
| `obj.upgrade(power)` | `obj.upgrade(double power)` | `double` |
| `obj.usePower(power)` | `obj.usePower(double power)` | `double` |
| `obj.usePower(power, target)` | `obj.usePower(double power, RoomObject target)` | `double` |
| `obj.withdraw(target, resourceType)` | `obj.withdraw(object target, string resourceType)` | `double` |
| `obj.withdraw(target, resourceType, amount)` | `obj.withdraw(object target, string resourceType, double amount)` | `double` |

## PowerCreepConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `PowerCreep` |
| `obj.create(name, className)` | `obj.create(string name, object className)` | `double` |

## PowerCreepPowers

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj[key]` | `obj[double key]` | `dynamic` |

## RawMemory

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.segments` | `obj.segments` | `NativeMap<string>，可赋值` |
| `obj.foreignSegment` | `obj.foreignSegment` | `dynamic，可赋值` |
| `obj.interShardSegment` | `obj.interShardSegment` | `string，可赋值` |
| `obj[key]` | `obj[string key]` | `dynamic` |
| `obj.get()` | `obj.get()` | `string` |
| `obj.set(value)` | `obj.set(string value)` | `dynamic` |
| `obj.setActiveSegments(ids)` | `obj.setActiveSegments(double[] ids)` | `dynamic` |
| `obj.setActiveForeignSegment(username)` | `obj.setActiveForeignSegment(string username)` | `dynamic` |
| `obj.setActiveForeignSegment(username, id)` | `obj.setActiveForeignSegment(string username, double id)` | `dynamic` |
| `obj.setDefaultPublicSegment(id)` | `obj.setDefaultPublicSegment(double? id)` | `dynamic` |
| `obj.setPublicSegments(ids)` | `obj.setPublicSegments(double[] ids)` | `dynamic` |

## Resource

继承 [RoomObject](#roomobject)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `Resource，只读` |
| `obj.amount` | `obj.amount` | `double，可赋值` |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.resourceType` | `obj.resourceType` | `dynamic，可赋值` |

## ResourceConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `Resource` |

## RoomObject

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `RoomObject，只读` |
| `obj.effects` | `obj.effects` | `dynamic[]，可赋值` |
| `obj.pos` | `obj.pos` | `RoomPosition，可赋值` |
| `obj.room` | `obj.room` | `Room，可赋值` |

## RoomObjectConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(x, y, roomName)` | `ctor.New(double x, double y, string roomName)` | `RoomObject` |

## NaturalEffect

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.effect` | `obj.effect` | `double，可赋值` |
| `obj.ticksRemaining` | `obj.ticksRemaining` | `double，可赋值` |

## PowerEffect

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.level` | `obj.level` | `double，可赋值` |
| `obj.effect` | `obj.effect` | `double，可赋值` |
| `obj.power` | `obj.power` | `double，可赋值` |
| `obj.ticksRemaining` | `obj.ticksRemaining` | `double，可赋值` |

## RoomPosition

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `RoomPosition，只读` |
| `obj.roomName` | `obj.roomName` | `string，可赋值` |
| `obj.x` | `obj.x` | `double，可赋值` |
| `obj.y` | `obj.y` | `double，可赋值` |
| `obj.createConstructionSite(structureType)` | `obj.createConstructionSite(string structureType)` | `double` |
| `obj.createConstructionSite(structureType, name)` | `obj.createConstructionSite(string structureType, string name)` | `double` |
| `obj.createFlag()` | `obj.createFlag()` | `dynamic` |
| `obj.createFlag(name)` | `obj.createFlag(string name)` | `dynamic` |
| `obj.createFlag(name, color)` | `obj.createFlag(string name, double color)` | `dynamic` |
| `obj.createFlag(name, color, secondaryColor)` | `obj.createFlag(string name, double color, double secondaryColor)` | `dynamic` |
| `obj.findClosestByPath(type)` | `obj.findClosestByPath(object type)` | `dynamic` |
| `obj.findClosestByPath(type, opts)` | `obj.findClosestByPath(object type, object opts)` | `dynamic` |
| `obj.findClosestByRange(type)` | `obj.findClosestByRange(object type)` | `dynamic` |
| `obj.findClosestByRange(type, opts)` | `obj.findClosestByRange(object type, FilterOptions opts)` | `dynamic` |
| `obj.findInRange(type, range)` | `obj.findInRange(object type, double range)` | `dynamic[]` |
| `obj.findInRange(type, range, opts)` | `obj.findInRange(object type, double range, FilterOptions opts)` | `dynamic[]` |
| `obj.findPathTo(x, y)` | `obj.findPathTo(object x, object y)` | `PathStep[]` |
| `obj.findPathTo(x, y, opts)` | `obj.findPathTo(double x, double y, FindPathOpts opts)` | `PathStep[]` |
| `obj.findPathTo(target)` | `obj.findPathTo(object target)` | `PathStep[]` |
| `obj.getDirectionTo(x, y)` | `obj.getDirectionTo(double x, double y)` | `double` |
| `obj.getDirectionTo(target)` | `obj.getDirectionTo(object target)` | `double` |
| `obj.getRangeTo(x, y)` | `obj.getRangeTo(double x, double y)` | `double` |
| `obj.getRangeTo(target)` | `obj.getRangeTo(object target)` | `double` |
| `obj.inRangeTo(x, y, range)` | `obj.inRangeTo(double x, double y, double range)` | `bool` |
| `obj.inRangeTo(target, range)` | `obj.inRangeTo(object target, double range)` | `bool` |
| `obj.isEqualTo(x, y)` | `obj.isEqualTo(double x, double y)` | `bool` |
| `obj.isEqualTo(target)` | `obj.isEqualTo(object target)` | `bool` |
| `obj.isNearTo(x, y)` | `obj.isNearTo(double x, double y)` | `bool` |
| `obj.isNearTo(target)` | `obj.isNearTo(object target)` | `bool` |
| `obj.look()` | `obj.look()` | `dynamic[]` |
| `obj.lookFor(type)` | `obj.lookFor(object type)` | `dynamic[]` |

## RoomPositionConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(x, y, roomName)` | `ctor.New(double x, double y, string roomName)` | `RoomPosition` |

## RoomTerrain

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.get(x, y)` | `obj.get(double x, double y)` | `double` |
| `obj.getRawBuffer(destinationArray)` | `obj.getRawBuffer(object destinationArray)` | `dynamic` |
| `obj.getRawBuffer()` | `obj.getRawBuffer()` | `dynamic` |

## RoomTerrainConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(roomName)` | `ctor.New(string roomName)` | `RoomTerrain` |

## RoomVisual

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.roomName` | `obj.roomName` | `string，可赋值` |
| `obj.line(x1, y1, x2, y2)` | `obj.line(double x1, double y1, double x2, double y2)` | `RoomVisual` |
| `obj.line(x1, y1, x2, y2, style)` | `obj.line(double x1, double y1, double x2, double y2, LineStyle style)` | `RoomVisual` |
| `obj.line(pos1, pos2)` | `obj.line(RoomPosition pos1, RoomPosition pos2)` | `RoomVisual` |
| `obj.line(pos1, pos2, style)` | `obj.line(RoomPosition pos1, RoomPosition pos2, LineStyle style)` | `RoomVisual` |
| `obj.circle(x, y)` | `obj.circle(object x, object y)` | `RoomVisual` |
| `obj.circle(x, y, style)` | `obj.circle(double x, double y, CircleStyle style)` | `RoomVisual` |
| `obj.circle(pos)` | `obj.circle(RoomPosition pos)` | `RoomVisual` |
| `obj.rect(x, y, w, h)` | `obj.rect(object x, double y, double w, object h)` | `RoomVisual` |
| `obj.rect(x, y, w, h, style)` | `obj.rect(double x, double y, double w, double h, PolyStyle style)` | `RoomVisual` |
| `obj.rect(topLeftPos, width, height)` | `obj.rect(RoomPosition topLeftPos, double width, double height)` | `RoomVisual` |
| `obj.poly(points)` | `obj.poly(dynamic[] points)` | `RoomVisual` |
| `obj.poly(points, style)` | `obj.poly(dynamic[] points, PolyStyle style)` | `RoomVisual` |
| `obj.text(text, x, y)` | `obj.text(string text, object x, object y)` | `RoomVisual` |
| `obj.text(text, x, y, style)` | `obj.text(string text, double x, double y, TextStyle style)` | `RoomVisual` |
| `obj.text(text, pos)` | `obj.text(string text, RoomPosition pos)` | `RoomVisual` |
| `obj.clear()` | `obj.clear()` | `RoomVisual` |
| `obj.getSize()` | `obj.getSize()` | `double` |
| `obj.export()` | `obj.export()` | `string` |
| `obj.import(data)` | `obj.import(string data)` | `RoomVisual` |

## LineStyle

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.width` | `obj.width` | `double?，可赋值` |
| `obj.color` | `obj.color` | `string，可赋值` |
| `obj.opacity` | `obj.opacity` | `double?，可赋值` |
| `obj.lineStyle` | `obj.lineStyle` | `string，可赋值` |

## PolyStyle

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.fill` | `obj.fill` | `string，可赋值` |
| `obj.opacity` | `obj.opacity` | `double?，可赋值` |
| `obj.stroke` | `obj.stroke` | `string，可赋值` |
| `obj.strokeWidth` | `obj.strokeWidth` | `double?，可赋值` |
| `obj.lineStyle` | `obj.lineStyle` | `string，可赋值` |

## CircleStyle

继承 [PolyStyle](#polystyle)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.radius` | `obj.radius` | `double?，可赋值` |

## TextStyle

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.color` | `obj.color` | `string，可赋值` |
| `obj.font` | `obj.font` | `dynamic，可赋值` |
| `obj.stroke` | `obj.stroke` | `string，可赋值` |
| `obj.strokeWidth` | `obj.strokeWidth` | `double?，可赋值` |
| `obj.backgroundColor` | `obj.backgroundColor` | `string，可赋值` |
| `obj.backgroundPadding` | `obj.backgroundPadding` | `double?，可赋值` |
| `obj.align` | `obj.align` | `string，可赋值` |
| `obj.opacity` | `obj.opacity` | `double?，可赋值` |

## Room

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `Room，只读` |
| `obj.controller` | `obj.controller` | `StructureController，可赋值` |
| `obj.energyAvailable` | `obj.energyAvailable` | `double，可赋值` |
| `obj.energyCapacityAvailable` | `obj.energyCapacityAvailable` | `double，可赋值` |
| `obj.memory` | `obj.memory` | `RoomMemory，可赋值` |
| `obj.name` | `obj.name` | `string，只读` |
| `obj.storage` | `obj.storage` | `StructureStorage，可赋值` |
| `obj.terminal` | `obj.terminal` | `StructureTerminal，可赋值` |
| `obj.visual` | `obj.visual` | `RoomVisual，可赋值` |
| `obj.getEventLog()` | `obj.getEventLog()` | `dynamic[]` |
| `obj.getEventLog(raw)` | `obj.getEventLog(bool raw)` | `dynamic` |
| `obj.createConstructionSite(x, y, structureType)` | `obj.createConstructionSite(object x, object y, string structureType)` | `double` |
| `obj.createConstructionSite(pos, structureType)` | `obj.createConstructionSite(object pos, string structureType)` | `double` |
| `obj.createConstructionSite(x, y, structureType, name)` | `obj.createConstructionSite(double x, double y, string structureType, string name)` | `double` |
| `obj.createFlag(x, y)` | `obj.createFlag(object x, object y)` | `dynamic` |
| `obj.createFlag(x, y, name)` | `obj.createFlag(object x, object y, object name)` | `dynamic` |
| `obj.createFlag(x, y, name, color)` | `obj.createFlag(object x, object y, object name, double color)` | `dynamic` |
| `obj.createFlag(x, y, name, color, secondaryColor)` | `obj.createFlag(double x, double y, string name, double color, double secondaryColor)` | `dynamic` |
| `obj.createFlag(pos)` | `obj.createFlag(object pos)` | `dynamic` |
| `obj.find(type)` | `obj.find(object type)` | `dynamic[]` |
| `obj.find(type, opts)` | `obj.find(object type, FilterOptions opts)` | `dynamic[]` |
| `obj.findExitTo(room)` | `obj.findExitTo(object room)` | `double` |
| `obj.findPath(fromPos, toPos)` | `obj.findPath(RoomPosition fromPos, RoomPosition toPos)` | `PathStep[]` |
| `obj.findPath(fromPos, toPos, opts)` | `obj.findPath(RoomPosition fromPos, RoomPosition toPos, FindPathOpts opts)` | `PathStep[]` |
| `obj.getPositionAt(x, y)` | `obj.getPositionAt(double x, double y)` | `RoomPosition` |
| `obj.getTerrain()` | `obj.getTerrain()` | `RoomTerrain` |
| `obj.lookAt(x, y)` | `obj.lookAt(double x, double y)` | `dynamic[]` |
| `obj.lookAt(target)` | `obj.lookAt(object target)` | `dynamic[]` |
| `obj.lookAtArea(top, left, bottom, right)` | `obj.lookAtArea(double top, double left, double bottom, double right)` | `LookAtResultMatrix` |
| `obj.lookAtArea(top, left, bottom, right, asArray)` | `obj.lookAtArea(double top, double left, double bottom, double right, bool asArray)` | `dynamic` |
| `obj.lookForAt(type, x, y)` | `obj.lookForAt(object type, double x, double y)` | `dynamic[]` |
| `obj.lookForAt(type, target)` | `obj.lookForAt(object type, object target)` | `dynamic[]` |
| `obj.lookForAtArea(type, top, left, bottom, right)` | `obj.lookForAtArea(object type, double top, double left, double bottom, double right)` | `LookForAtAreaResultMatrix` |
| `obj.lookForAtArea(type, top, left, bottom, right, asArray)` | `obj.lookForAtArea(object type, double top, double left, double bottom, double right, bool asArray)` | `dynamic` |

## RoomConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.Terrain` | `obj.Terrain` | `RoomTerrainConstructor，可赋值` |
| `new (ctor)(id)` | `ctor.New(string id)` | `Room` |
| `obj.serializePath(path)` | `obj.serializePath(PathStep[] path)` | `string` |
| `obj.deserializePath(path)` | `obj.deserializePath(string path)` | `PathStep[]` |

## Ruin

继承 [RoomObject](#roomobject)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.destroyTime` | `obj.destroyTime` | `double，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.ticksToDecay` | `obj.ticksToDecay` | `double，可赋值` |
| `obj.structure` | `obj.structure` | `dynamic，可赋值` |

## RuinConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `Ruin` |

## Source

继承 [RoomObject](#roomobject)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `Source，只读` |
| `obj.energy` | `obj.energy` | `double，可赋值` |
| `obj.energyCapacity` | `obj.energyCapacity` | `double，可赋值` |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.room` | `obj.room` | `Room，可赋值` |
| `obj.ticksToRegeneration` | `obj.ticksToRegeneration` | `double，可赋值` |

## SourceConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `Source` |

## StructureSpawn

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureSpawn，只读` |
| `obj.energy` | `obj.energy` | `double，可赋值` |
| `obj.energyCapacity` | `obj.energyCapacity` | `double，可赋值` |
| `obj.memory` | `obj.memory` | `SpawnMemory，可赋值` |
| `obj.name` | `obj.name` | `string，可赋值` |
| `obj.spawning` | `obj.spawning` | `Spawning，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.canCreateCreep(body)` | `obj.canCreateCreep(string[] body)` | `double` |
| `obj.canCreateCreep(body, name)` | `obj.canCreateCreep(string[] body, string name)` | `double` |
| `obj.createCreep(body)` | `obj.createCreep(string[] body)` | `dynamic` |
| `obj.createCreep(body, name)` | `obj.createCreep(string[] body, string name)` | `dynamic` |
| `obj.createCreep(body, name, memory)` | `obj.createCreep(string[] body, string name, CreepMemory memory)` | `dynamic` |
| `obj.spawnCreep(body, name)` | `obj.spawnCreep(string[] body, string name)` | `double` |
| `obj.spawnCreep(body, name, opts)` | `obj.spawnCreep(string[] body, string name, SpawnOptions opts)` | `double` |
| `obj.renewCreep(target)` | `obj.renewCreep(Creep target)` | `double` |
| `obj.recycleCreep(target)` | `obj.recycleCreep(Creep target)` | `double` |

## StructureSpawnConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.Spawning` | `obj.Spawning` | `SpawningConstructor，可赋值` |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureSpawn` |

## Spawning

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `Spawning，只读` |
| `obj.directions` | `obj.directions` | `double[]，可赋值` |
| `obj.name` | `obj.name` | `string，可赋值` |
| `obj.needTime` | `obj.needTime` | `double，可赋值` |
| `obj.remainingTime` | `obj.remainingTime` | `double，可赋值` |
| `obj.spawn` | `obj.spawn` | `StructureSpawn，可赋值` |
| `obj.cancel()` | `obj.cancel()` | `dynamic` |
| `obj.setDirections(directions)` | `obj.setDirections(double[] directions)` | `dynamic` |

## SpawnOptions

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.memory` | `obj.memory` | `CreepMemory，可赋值` |
| `obj.energyStructures` | `obj.energyStructures` | `dynamic[]，可赋值` |
| `obj.dryRun` | `obj.dryRun` | `bool?，可赋值` |
| `obj.directions` | `obj.directions` | `double[]，可赋值` |

## SpawningConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `Spawning` |

## StoreBase

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.getCapacity()` | `obj.getCapacity()` | `dynamic` |
| `obj.getCapacity(resource)` | `obj.getCapacity(object resource)` | `dynamic` |
| `obj.getUsedCapacity()` | `obj.getUsedCapacity()` | `dynamic` |
| `obj.getUsedCapacity(resource)` | `obj.getUsedCapacity(object resource)` | `dynamic` |
| `obj.getFreeCapacity()` | `obj.getFreeCapacity()` | `dynamic` |
| `obj.getFreeCapacity(resource)` | `obj.getFreeCapacity(object resource)` | `dynamic` |

## GenericStoreBase

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj[key]` | `obj[string key]` | `double` |
| `obj.getCapacity()` | `obj.getCapacity()` | `double?` |
| `obj.getCapacity(resource)` | `obj.getCapacity(string resource)` | `double?` |
| `obj.getUsedCapacity()` | `obj.getUsedCapacity()` | `double?` |
| `obj.getUsedCapacity(resource)` | `obj.getUsedCapacity(string resource)` | `double?` |
| `obj.getFreeCapacity()` | `obj.getFreeCapacity()` | `double?` |
| `obj.getFreeCapacity(resource)` | `obj.getFreeCapacity(string resource)` | `double?` |

## Structure

继承 [RoomObject](#roomobject)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `Structure，只读` |
| `obj.hits` | `obj.hits` | `double，可赋值` |
| `obj.hitsMax` | `obj.hitsMax` | `double，可赋值` |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.room` | `obj.room` | `Room，可赋值` |
| `obj.structureType` | `obj.structureType` | `dynamic，可赋值` |
| `obj.destroy()` | `obj.destroy()` | `double` |
| `obj.isActive()` | `obj.isActive()` | `bool` |
| `obj.notifyWhenAttacked(enabled)` | `obj.notifyWhenAttacked(bool enabled)` | `double` |

## StructureConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `Structure` |

## OwnedStructure

继承 [Structure](#structure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `OwnedStructure，只读` |
| `obj.my` | `obj.my` | `bool，可赋值` |
| `obj.owner` | `obj.owner` | `dynamic，可赋值` |
| `obj.room` | `obj.room` | `Room，可赋值` |

## OwnedStructureConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `OwnedStructure` |

## StructureController

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureController，只读` |
| `obj.isPowerEnabled` | `obj.isPowerEnabled` | `bool，可赋值` |
| `obj.level` | `obj.level` | `double，可赋值` |
| `obj.progress` | `obj.progress` | `double，可赋值` |
| `obj.progressTotal` | `obj.progressTotal` | `double，可赋值` |
| `obj.reservation` | `obj.reservation` | `ReservationDefinition，可赋值` |
| `obj.safeMode` | `obj.safeMode` | `double?，可赋值` |
| `obj.safeModeAvailable` | `obj.safeModeAvailable` | `double，可赋值` |
| `obj.safeModeCooldown` | `obj.safeModeCooldown` | `double?，可赋值` |
| `obj.sign` | `obj.sign` | `SignDefinition，可赋值` |
| `obj.ticksToDowngrade` | `obj.ticksToDowngrade` | `double，可赋值` |
| `obj.upgradeBlocked` | `obj.upgradeBlocked` | `double，可赋值` |
| `obj.activateSafeMode()` | `obj.activateSafeMode()` | `double` |
| `obj.unclaim()` | `obj.unclaim()` | `double` |

## StructureControllerConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureController` |

## StructureExtension

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureExtension，只读` |
| `obj.energy` | `obj.energy` | `double，可赋值` |
| `obj.energyCapacity` | `obj.energyCapacity` | `double，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |

## StructureExtensionConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureExtension` |

## StructureLink

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureLink，只读` |
| `obj.cooldown` | `obj.cooldown` | `double，可赋值` |
| `obj.energy` | `obj.energy` | `double，可赋值` |
| `obj.energyCapacity` | `obj.energyCapacity` | `double，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.transferEnergy(target)` | `obj.transferEnergy(StructureLink target)` | `double` |
| `obj.transferEnergy(target, amount)` | `obj.transferEnergy(StructureLink target, double amount)` | `double` |

## StructureLinkConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureLink` |

## StructureKeeperLair

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureKeeperLair，只读` |
| `obj.ticksToSpawn` | `obj.ticksToSpawn` | `double?，可赋值` |

## StructureKeeperLairConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureKeeperLair` |

## StructureObserver

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureObserver，只读` |
| `obj.observeRoom(roomName)` | `obj.observeRoom(string roomName)` | `double` |

## StructureObserverConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureObserver` |

## StructurePowerBank

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructurePowerBank，只读` |
| `obj.power` | `obj.power` | `double，可赋值` |
| `obj.ticksToDecay` | `obj.ticksToDecay` | `double，可赋值` |

## StructurePowerBankConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructurePowerBank` |

## StructurePowerSpawn

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructurePowerSpawn，只读` |
| `obj.energy` | `obj.energy` | `double，可赋值` |
| `obj.energyCapacity` | `obj.energyCapacity` | `double，可赋值` |
| `obj.power` | `obj.power` | `double，可赋值` |
| `obj.powerCapacity` | `obj.powerCapacity` | `double，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.processPower()` | `obj.processPower()` | `double` |

## StructurePowerSpawnConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructurePowerSpawn` |

## StructureRampart

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureRampart，只读` |
| `obj.ticksToDecay` | `obj.ticksToDecay` | `double，可赋值` |
| `obj.isPublic` | `obj.isPublic` | `bool，可赋值` |
| `obj.setPublic(isPublic)` | `obj.setPublic(bool isPublic)` | `dynamic` |

## StructureRampartConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureRampart` |

## StructureRoad

继承 [Structure](#structure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureRoad，只读` |
| `obj.ticksToDecay` | `obj.ticksToDecay` | `double，可赋值` |

## StructureRoadConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureRoad` |

## StructureStorage

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureStorage，只读` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.storeCapacity` | `obj.storeCapacity` | `double，可赋值` |

## StructureStorageConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureStorage` |

## StructureTower

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureTower，只读` |
| `obj.energy` | `obj.energy` | `double，可赋值` |
| `obj.energyCapacity` | `obj.energyCapacity` | `double，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.attack(target)` | `obj.attack(object target)` | `double` |
| `obj.heal(target)` | `obj.heal(object target)` | `double` |
| `obj.repair(target)` | `obj.repair(Structure target)` | `double` |

## StructureTowerConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureTower` |

## StructureWall

继承 [Structure](#structure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureWall，只读` |
| `obj.ticksToLive` | `obj.ticksToLive` | `double，可赋值` |

## StructureWallConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureWall` |

## StructureExtractor

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureExtractor，只读` |
| `obj.cooldown` | `obj.cooldown` | `double，可赋值` |

## StructureExtractorConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureExtractor` |

## StructureLab

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureLab，只读` |
| `obj.cooldown` | `obj.cooldown` | `double，可赋值` |
| `obj.energy` | `obj.energy` | `double，可赋值` |
| `obj.energyCapacity` | `obj.energyCapacity` | `double，可赋值` |
| `obj.mineralAmount` | `obj.mineralAmount` | `double，可赋值` |
| `obj.mineralType` | `obj.mineralType` | `string，可赋值` |
| `obj.mineralCapacity` | `obj.mineralCapacity` | `double，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.boostCreep(creep)` | `obj.boostCreep(Creep creep)` | `double` |
| `obj.boostCreep(creep, bodyPartsCount)` | `obj.boostCreep(Creep creep, double bodyPartsCount)` | `double` |
| `obj.unboostCreep(creep)` | `obj.unboostCreep(Creep creep)` | `double` |
| `obj.reverseReaction(lab1, lab2)` | `obj.reverseReaction(StructureLab lab1, StructureLab lab2)` | `double` |
| `obj.runReaction(lab1, lab2)` | `obj.runReaction(StructureLab lab1, StructureLab lab2)` | `double` |

## StructureLabConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureLab` |

## StructureTerminal

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureTerminal，只读` |
| `obj.cooldown` | `obj.cooldown` | `double，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.storeCapacity` | `obj.storeCapacity` | `double，可赋值` |
| `obj.send(resourceType, amount, destination)` | `obj.send(string resourceType, double amount, string destination)` | `double` |
| `obj.send(resourceType, amount, destination, description)` | `obj.send(string resourceType, double amount, string destination, string description)` | `double` |

## StructureTerminalConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureTerminal` |

## StructureContainer

继承 [Structure](#structure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureContainer，只读` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.storeCapacity` | `obj.storeCapacity` | `double，可赋值` |
| `obj.ticksToDecay` | `obj.ticksToDecay` | `double，可赋值` |

## StructureContainerConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureContainer` |

## StructureNuker

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureNuker，只读` |
| `obj.energy` | `obj.energy` | `double，可赋值` |
| `obj.energyCapacity` | `obj.energyCapacity` | `double，可赋值` |
| `obj.ghodium` | `obj.ghodium` | `double，可赋值` |
| `obj.ghodiumCapacity` | `obj.ghodiumCapacity` | `double，可赋值` |
| `obj.cooldown` | `obj.cooldown` | `double，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.launchNuke(pos)` | `obj.launchNuke(RoomPosition pos)` | `double` |

## StructureNukerConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureNuker` |

## StructurePortal

继承 [Structure](#structure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructurePortal，只读` |
| `obj.destination` | `obj.destination` | `dynamic，可赋值` |
| `obj.ticksToDecay` | `obj.ticksToDecay` | `double?，可赋值` |

## StructurePortalConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructurePortal` |

## StructureFactory

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureFactory，只读` |
| `obj.cooldown` | `obj.cooldown` | `double，可赋值` |
| `obj.level` | `obj.level` | `double?，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.produce(resource)` | `obj.produce(string resource)` | `double` |

## StructureFactoryConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureFactory` |

## StructureInvaderCore

继承 [OwnedStructure](#ownedstructure)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.prototype` | `obj.prototype` | `StructureInvaderCore，只读` |
| `obj.level` | `obj.level` | `double，可赋值` |
| `obj.ticksToDeploy` | `obj.ticksToDeploy` | `double，可赋值` |
| `obj.spawning` | `obj.spawning` | `Spawning，可赋值` |

## StructureInvaderCoreConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `StructureInvaderCore` |

## ConcreteStructureMap

该类型用于原生对象视图；成员可能来自基类或动态访问。

## Tombstone

继承 [RoomObject](#roomobject)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `obj.id` | `obj.id` | `string，可赋值` |
| `obj.deathTime` | `obj.deathTime` | `double，可赋值` |
| `obj.store` | `obj.store` | `GenericStoreBase，可赋值` |
| `obj.ticksToDecay` | `obj.ticksToDecay` | `double，可赋值` |
| `obj.creep` | `obj.creep` | `dynamic，可赋值` |

## TombstoneConstructor

继承 [_Constructor](#_constructor)。

| JavaScript | C# 调用或访问签名 | 返回类型 / 属性说明 |
| --- | --- | --- |
| `new (ctor)(id)` | `ctor.New(string id)` | `Tombstone` |
