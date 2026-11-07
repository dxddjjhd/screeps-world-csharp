// Compiled in a separate test project. None of these actions run in the sample bot.
using System;
using System.Collections.Generic;
using System.Linq;
using WorldKit;

namespace Player
{
    interface IScore { int Value(); }
    sealed class Score : IScore { public int Value() => 3; }

    public static class Colony
    {
        public static void Tick()
        {
            var numbers = new List<int> { 1, 2, 3, 4 };
            int sum = numbers.Where(x => x % 2 == 0).Sum();
            IScore score = new Score();
            for (var i = 0; i < 2; ++i) sum += score.Value();
            while (sum < 15) sum++;
            try { throw new Exception("probe"); }
            catch (Exception) { sum++; }

            var target = World.Position(20, 21, "W1N1");
            var costs = World.Costs();
            costs.set(20, 21, 4);
            var route = World.PathFinder.search(target, target);
            var fee = World.Game.market.calcTransactionCost(100, "W1N1", "W2N1");
            var distance = World.Game.map.getRoomLinearDistance("W1N1", "W2N1");
            var lab = Native.As<StructureLab>((object)World.Game.getObjectById("lab"));
            lab.runReaction(lab, lab);
            Native.As<StructureFactory>((object)World.Game.getObjectById("factory")).produce("wire");
            Native.As<StructureTerminal>((object)World.Game.getObjectById("terminal")).send("energy", 100, "W2N1");
            World.Game.powerCreeps["operator"].usePower(1);
            World.RawMemory.setActiveSegments(new double[] { 2, 3 });
            World.InterShardMemory.setLocal("hello");
            var plugin = Native.Global<object>("SeasonExtension");
            int value = Native.Call<int>(plugin, "custom", new object[] { "W1N1" });
            Native.Set(World.Memory, "answer", sum + fee + distance + route.ops + value);
        }
    }
}
