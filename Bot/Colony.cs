using System.Collections.Generic;
using WorldKit;
using static WorldKit.World;

namespace Player
{
    public static class Colony
    {
        // One invocation per World tick. Game objects are local to this call.
        public static void Tick()
        {
            var counts = new Dictionary<string, int>();
            foreach (var creep in World.Game.creeps.Values())
            {
                if (Native.Get<string>(creep.memory, "role") != "wk-worker") continue;
                var home = Native.Get<string>(creep.memory, "home");
                if (home == null) continue;
                counts.TryGetValue(home, out int n);
                counts[home] = n + 1;
                if (!creep.spawning) Worker.Run(creep);
            }

            foreach (var room in World.Game.rooms.Values())
            {
                if (room.controller == null || !room.controller.my) continue;
                counts.TryGetValue(room.name, out int workers);
                foreach (var spawn in Native.Find<StructureSpawn>(room, FIND_MY_SPAWNS))
                {
                    if (workers >= 3 || room.energyAvailable < 200) break;
                    if (spawn.spawning != null) continue;
                    var memory = Native.Options<CreepMemory>();
                    Native.Set(memory, "role", "wk-worker");
                    Native.Set(memory, "home", room.name);
                    var opts = Native.Options<SpawnOptions>();
                    opts.memory = memory;
                    var code = spawn.spawnCreep(new[] { WORK, CARRY, MOVE }, "wk-" + spawn.name + "-" + World.Game.time, opts);
                    if (code == OK) workers++;
                }

                var enemies = Native.Find<Creep>(room, FIND_HOSTILE_CREEPS);
                if (enemies.Length == 0) continue;
                foreach (var s in Native.Find<Structure>(room, FIND_MY_STRUCTURES))
                {
                    if (Native.Get<string>(s, "structureType") == STRUCTURE_TOWER)
                        Native.As<StructureTower>(s).attack(enemies[0]);
                }
            }
        }
    }
}
