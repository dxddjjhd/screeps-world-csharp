using WorldKit;
using static WorldKit.World;

namespace Player
{
    internal static class Worker
    {
        public static void Run(Creep creep)
        {
            if (creep.store.getUsedCapacity(RESOURCE_ENERGY) == 0)
                Native.Set(creep.memory, "working", false);
            if (creep.store.getFreeCapacity(RESOURCE_ENERGY) == 0)
                Native.Set(creep.memory, "working", true);

            if (!Native.Get<bool>(creep.memory, "working"))
            {
                var src = Native.Closest<Source>(creep.pos, FIND_SOURCES_ACTIVE);
                if (src != null) Approach(creep, src, creep.harvest(src));
                return;
            }

            foreach (var s in Native.Find<Structure>(creep.room, FIND_MY_STRUCTURES))
            {
                string kind = Native.Get<string>(s, "structureType");
                if (kind != STRUCTURE_SPAWN && kind != STRUCTURE_EXTENSION && kind != STRUCTURE_TOWER)
                    continue;
                var store = Native.Get<GenericStoreBase>(s, "store");
                if (store.getFreeCapacity(RESOURCE_ENERGY) > 0)
                {
                    Approach(creep, s, creep.transfer(s, RESOURCE_ENERGY));
                    return;
                }
            }
            var site = Native.Closest<ConstructionSite>(creep.pos, FIND_MY_CONSTRUCTION_SITES);
            if (site != null)
            {
                Approach(creep, site, creep.build(site));
                return;
            }
            var controller = creep.room.controller;
            if (controller != null && controller.my)
                Approach(creep, controller, creep.upgradeController(controller));
        }

        private static void Approach(Creep creep, RoomObject target, double result)
        {
            if (result == ERR_NOT_IN_RANGE) creep.moveTo(target);
        }
    }
}
