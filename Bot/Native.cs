using Transpose;

namespace WorldKit
{
    [External]
    public class NativeMap<T>
    {
        public extern T this[string key] { get; set; }
        [Template("Object.keys({this})")] public extern string[] Keys();
        [Template("Object.values({this})")] public extern T[] Values();
    }

    public static partial class World
    {
        [Template("new RoomPosition({x}, {y}, {room})")]
        public static extern RoomPosition Position(int x, int y, string room);
        [Template("new PathFinder.CostMatrix()")] public static extern CostMatrix Costs();
        [Template("new Room.Terrain({room})")] public static extern RoomTerrain Terrain(string room);
        [Template("new RoomVisual()")] public static extern RoomVisual Visual();
        [Template("new RoomVisual({room})")] public static extern RoomVisual Visual(string room);
    }

    // These operations use the actual game object each time and preserve method receivers.
    [External]
    public static class Native
    {
        [Template("globalThis[{name}]")] public static extern T Global<T>(string name);
        [Template("{target}[{key}]")] public static extern T Get<T>(object target, string key);
        [Template("({target}[{key}] = {value})")] public static extern void Set(object target, string key, object value);
        [Template("(delete {target}[{key}])")] public static extern void Delete(object target, string key);
        [Template("{target}[{name}](...{args})")]
        public static extern T Call<T>(object target, string name, object[] args);
        [Template("Reflect.construct({ctor}, {args})")] public static extern T New<T>(object ctor, object[] args);
        [Template("({})")] public static extern T Options<T>();
        [Template("({target})")] public static extern T As<T>(object target);
        [Template("{room}.find({kind})")] public static extern T[] Find<T>(Room room, double kind);
        [Template("{pos}.findClosestByPath({kind})")] public static extern T Closest<T>(RoomPosition pos, double kind);
    }
}
