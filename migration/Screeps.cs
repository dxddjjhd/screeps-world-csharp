// Optional bindings for source files from ScreepsSharp v1.
using Transpose;

namespace Screeps
{
    public static class Game
    {
        public static int Time => Script.Write<int>("Game.time");
        public static Creep[] Creeps => Script.Write<Creep[]>("Object.values(Game.creeps)");
        public static Spawn[] Spawns => Script.Write<Spawn[]>("Object.values(Game.spawns)");
    }

    [Enum(Emit.StringName)] public enum Resource { Energy }
    public enum Find { SourcesActive = 104 }
    [Enum(Emit.StringName)] public enum BodyPart { Work, Carry, Move }

    public static class Result
    {
        public const int Ok = 0;
        public const int NotInRange = -9;
    }

    [External]
    public abstract class Target { }
    [External]
    public abstract class Source : Target { }
    [External]
    public abstract class Controller : Target { }

    [External]
    public abstract class Room
    {
        [Name("controller")] public abstract Controller Controller { get; }
    }

    [External]
    public abstract class WorkerMemory
    {
        [Name("working")] public abstract bool Working { get; set; }
    }

    [External]
    public abstract class Store
    {
        [Name("getUsedCapacity")] public abstract int GetUsedCapacity(Resource resource);
        [Name("getFreeCapacity")] public abstract int GetFreeCapacity(Resource resource);
    }

    [External]
    public abstract class Position
    {
        [Name("findClosestByPath")] public abstract Source FindClosestByPath(Find find);
    }

    [External]
    public abstract class Creep : Target
    {
        [Name("store")] public abstract Store Store { get; }
        [Name("room")] public abstract Room Room { get; }
        [Name("pos")] public abstract Position Pos { get; }
        [Name("memory")] public abstract WorkerMemory Memory { get; }
        [Name("name")] public abstract string Name { get; }
        [Name("spawning")] public abstract bool Spawning { get; }
        [Name("harvest")] public abstract int Harvest(Source source);
        [Name("moveTo")] public abstract int MoveTo(Target target);
        [Name("transfer")] public abstract int Transfer(Spawn target, Resource resource);
        [Name("upgradeController")] public abstract int UpgradeController(Controller controller);
        [Name("say")] public abstract int Say(string message);
    }

    [External]
    public abstract class Spawn : Target
    {
        [Name("store")] public abstract Store Store { get; }
        [Name("name")] public abstract string Name { get; }
        [Name("spawnCreep")] public abstract int SpawnCreep(BodyPart[] body, string name);
    }
}
