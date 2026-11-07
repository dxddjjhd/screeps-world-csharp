// Generated from @types/screeps 3.4.0. See licenses/typed-screeps.txt.
#pragma warning disable 0108, 0626, 0824
using Transpose;
namespace WorldKit
{
    [External]
    public class CommodityEntry
    {
        protected CommodityEntry() {}
        [Name("level")] public double? @level { get; set; }
        [Name("amount")] public double @amount { get; set; }
        [Name("cooldown")] public double @cooldown { get; set; }
        [Name("components")] public dynamic @components { get; set; }
    }
    [External]
    public class ConstructionSite : RoomObject
    {
        protected ConstructionSite() {}
        [Name("prototype")] public ConstructionSite @prototype { get; }
        [Name("id")] public string @id { get; set; }
        [Name("my")] public bool @my { get; set; }
        [Name("owner")] public Owner @owner { get; set; }
        [Name("progress")] public double @progress { get; set; }
        [Name("progressTotal")] public double @progressTotal { get; set; }
        [Name("structureType")] public dynamic @structureType { get; set; }
        [Name("remove")] public extern double @remove();
    }
    [External]
    public class ConstructionSiteConstructor : _Constructor
    {
        protected ConstructionSiteConstructor() {}
        [Template("new ({this})({0})")] public extern ConstructionSite New(string id);
    }
    [External]
    public class Creep : RoomObject
    {
        protected Creep() {}
        [Name("prototype")] public Creep @prototype { get; }
        [Name("body")] public dynamic[] @body { get; set; }
        [Name("carry")] public GenericStoreBase @carry { get; set; }
        [Name("carryCapacity")] public double @carryCapacity { get; set; }
        [Name("fatigue")] public double @fatigue { get; set; }
        [Name("hits")] public double @hits { get; set; }
        [Name("hitsMax")] public double @hitsMax { get; set; }
        [Name("id")] public string @id { get; set; }
        [Name("memory")] public CreepMemory @memory { get; set; }
        [Name("my")] public bool @my { get; set; }
        [Name("name")] public string @name { get; set; }
        [Name("owner")] public Owner @owner { get; set; }
        [Name("room")] public Room @room { get; set; }
        [Name("spawning")] public bool @spawning { get; set; }
        [Name("saying")] public string @saying { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("ticksToLive")] public double? @ticksToLive { get; set; }
        [Name("attack")] public extern double @attack(object @target);
        [Name("attackController")] public extern double @attackController(StructureController @target);
        [Name("build")] public extern double @build(ConstructionSite @target);
        [Name("cancelOrder")] public extern double @cancelOrder(string @methodName);
        [Name("claimController")] public extern double @claimController(StructureController @target);
        [Name("dismantle")] public extern double @dismantle(Structure @target);
        [Name("drop")] public extern double @drop(string @resourceType);
        [Name("drop")] public extern double @drop(string @resourceType, double @amount);
        [Name("generateSafeMode")] public extern double @generateSafeMode(StructureController @target);
        [Name("getActiveBodyparts")] public extern double @getActiveBodyparts(string @type);
        [Name("harvest")] public extern double @harvest(object @target);
        [Name("heal")] public extern double @heal(object @target);
        [Name("move")] public extern double @move(object @direction);
        [Name("moveByPath")] public extern double @moveByPath(object @path);
        [Name("moveTo")] public extern double @moveTo(object @x, object @y);
        [Name("moveTo")] public extern double @moveTo(double @x, double @y, MoveToOpts @opts);
        [Name("moveTo")] public extern double @moveTo(object @target);
        [Name("notifyWhenAttacked")] public extern double @notifyWhenAttacked(bool @enabled);
        [Name("pickup")] public extern double @pickup(Resource @target);
        [Name("pull")] public extern double @pull(Creep @target);
        [Name("rangedAttack")] public extern double @rangedAttack(object @target);
        [Name("rangedHeal")] public extern double @rangedHeal(object @target);
        [Name("rangedMassAttack")] public extern double @rangedMassAttack();
        [Name("repair")] public extern double @repair(Structure @target);
        [Name("reserveController")] public extern double @reserveController(StructureController @target);
        [Name("say")] public extern double @say(string @message);
        [Name("say")] public extern double @say(string @message, bool @toPublic);
        [Name("signController")] public extern double @signController(StructureController @target, string @text);
        [Name("suicide")] public extern double @suicide();
        [Name("transfer")] public extern double @transfer(object @target, string @resourceType);
        [Name("transfer")] public extern double @transfer(object @target, string @resourceType, double @amount);
        [Name("upgradeController")] public extern double @upgradeController(StructureController @target);
        [Name("withdraw")] public extern double @withdraw(object @target, string @resourceType);
        [Name("withdraw")] public extern double @withdraw(object @target, string @resourceType, double @amount);
    }
    [External]
    public class CreepConstructor : _Constructor
    {
        protected CreepConstructor() {}
        [Template("new ({this})({0})")] public extern Creep New(string id);
    }
    [External]
    public class Deposit : RoomObject
    {
        protected Deposit() {}
        [Name("id")] public string @id { get; set; }
        [Name("depositType")] public string @depositType { get; set; }
        [Name("cooldown")] public double @cooldown { get; set; }
        [Name("lastCooldown")] public double @lastCooldown { get; set; }
        [Name("ticksToDecay")] public double @ticksToDecay { get; set; }
    }
    [External]
    public class DepositConstructor : _Constructor
    {
        protected DepositConstructor() {}
        [Template("new ({this})({0})")] public extern Deposit New(string id);
    }
    [External]
    public class Flag : RoomObject
    {
        protected Flag() {}
        [Name("prototype")] public Flag @prototype { get; }
        [Name("color")] public double @color { get; set; }
        [Name("memory")] public FlagMemory @memory { get; set; }
        [Name("name")] public string @name { get; set; }
        [Name("secondaryColor")] public double @secondaryColor { get; set; }
        [Name("remove")] public extern double @remove();
        [Name("setColor")] public extern double @setColor(double @color);
        [Name("setColor")] public extern double @setColor(double @color, double @secondaryColor);
        [Name("setPosition")] public extern double @setPosition(double @x, double @y);
        [Name("setPosition")] public extern double @setPosition(object @pos);
    }
    [External]
    public class FlagConstructor : _Constructor
    {
        protected FlagConstructor() {}
        [Template("new ({this})({0}, {1}, {2}, {3}, {4}, {5})")] public extern Flag New(string @name, double @color, double @secondaryColor, string @roomName, double @x, double @y);
    }
    [External]
    public class Game
    {
        protected Game() {}
        [Name("cpu")] public CPU @cpu { get; set; }
        [Name("creeps")] public NativeMap<Creep> @creeps { get; set; }
        [Name("flags")] public NativeMap<Flag> @flags { get; set; }
        [Name("gcl")] public GlobalControlLevel @gcl { get; set; }
        [Name("gpl")] public GlobalPowerLevel @gpl { get; set; }
        [Name("map")] public GameMap @map { get; set; }
        [Name("market")] public Market @market { get; set; }
        [Name("powerCreeps")] public NativeMap<PowerCreep> @powerCreeps { get; set; }
        [Name("resources")] public NativeMap<dynamic> @resources { get; set; }
        [Name("rooms")] public NativeMap<Room> @rooms { get; set; }
        [Name("spawns")] public NativeMap<StructureSpawn> @spawns { get; set; }
        [Name("structures")] public NativeMap<OwnedStructure> @structures { get; set; }
        [Name("constructionSites")] public NativeMap<ConstructionSite> @constructionSites { get; set; }
        [Name("shard")] public Shard @shard { get; set; }
        [Name("time")] public double @time { get; set; }
        [Name("getObjectById")] public extern dynamic @getObjectById(object @id);
        [Name("notify")] public extern double @notify(string @message);
        [Name("notify")] public extern double @notify(string @message, double @groupInterval);
    }
    [External]
    public class _HasId
    {
        protected _HasId() {}
        [Name("id")] public string @id { get; set; }
    }
    [External]
    public class _HasRoomPosition
    {
        protected _HasRoomPosition() {}
        [Name("pos")] public RoomPosition @pos { get; set; }
    }
    [External]
    public class GlobalControlLevel
    {
        protected GlobalControlLevel() {}
        [Name("level")] public double @level { get; set; }
        [Name("progress")] public double @progress { get; set; }
        [Name("progressTotal")] public double @progressTotal { get; set; }
    }
    [External]
    public class GlobalPowerLevel
    {
        protected GlobalPowerLevel() {}
        [Name("level")] public double @level { get; set; }
        [Name("progress")] public double @progress { get; set; }
        [Name("progressTotal")] public double @progressTotal { get; set; }
    }
    [External]
    public class Shard
    {
        protected Shard() {}
        [Name("name")] public string @name { get; set; }
        [Name("type")] public string @type { get; set; }
        [Name("ptr")] public bool @ptr { get; set; }
        [Name("access")] public bool? @access { get; set; }
        [Name("accessTime")] public double? @accessTime { get; set; }
        [Name("activateAccess")] public extern double @activateAccess();
    }
    [External]
    public class CPU
    {
        protected CPU() {}
        [Name("limit")] public double @limit { get; set; }
        [Name("tickLimit")] public double @tickLimit { get; set; }
        [Name("bucket")] public double @bucket { get; set; }
        [Name("shardLimits")] public CPUShardLimits @shardLimits { get; set; }
        [Name("unlocked")] public bool @unlocked { get; set; }
        [Name("unlockedTime")] public double? @unlockedTime { get; set; }
        [Name("getUsed")] public extern double @getUsed();
        [Name("setShardLimits")] public extern double @setShardLimits(CPUShardLimits @limits);
        [Name("getHeapStatistics")] public extern HeapStatistics @getHeapStatistics();
        [Name("halt")] public extern dynamic @halt();
        [Name("generatePixel")] public extern double @generatePixel();
        [Name("unlock")] public extern double @unlock();
    }
    [External]
    public class HeapStatistics
    {
        protected HeapStatistics() {}
        [Name("total_heap_size")] public double @total_heap_size { get; set; }
        [Name("total_heap_size_executable")] public double @total_heap_size_executable { get; set; }
        [Name("total_physical_size")] public double @total_physical_size { get; set; }
        [Name("total_available_size")] public double @total_available_size { get; set; }
        [Name("used_heap_size")] public double @used_heap_size { get; set; }
        [Name("heap_size_limit")] public double @heap_size_limit { get; set; }
        [Name("malloced_memory")] public double @malloced_memory { get; set; }
        [Name("peak_malloced_memory")] public double @peak_malloced_memory { get; set; }
        [Name("does_zap_garbage")] public double @does_zap_garbage { get; set; }
        [Name("externally_allocated_size")] public double @externally_allocated_size { get; set; }
    }
    [External]
    public class Owner
    {
        protected Owner() {}
        [Name("username")] public string @username { get; set; }
    }
    [External]
    public class ReservationDefinition
    {
        protected ReservationDefinition() {}
        [Name("username")] public string @username { get; set; }
        [Name("ticksToEnd")] public double @ticksToEnd { get; set; }
    }
    [External]
    public class SignDefinition
    {
        protected SignDefinition() {}
        [Name("username")] public string @username { get; set; }
        [Name("text")] public string @text { get; set; }
        [Name("time")] public double @time { get; set; }
        [Name("datetime")] public dynamic @datetime { get; set; }
    }
    [External]
    public class CPUShardLimits
    {
        protected CPUShardLimits() {}
        public extern double this[string key] { get; set; }
    }
    [External]
    public class AllLookAtTypes
    {
        protected AllLookAtTypes() {}
    }
    [External]
    public class LookAtResultMatrix
    {
        protected LookAtResultMatrix() {}
        public extern NativeMap<dynamic[]> this[double key] { get; set; }
    }
    [External]
    public class LookForAtAreaResultMatrix
    {
        protected LookForAtAreaResultMatrix() {}
        public extern NativeMap<dynamic[]> this[double key] { get; set; }
    }
    [External]
    public class FindTypes
    {
        protected FindTypes() {}
        public extern dynamic this[double key] { get; set; }
    }
    [External]
    public class FindPathOpts
    {
        protected FindPathOpts() {}
        [Name("ignoreCreeps")] public bool? @ignoreCreeps { get; set; }
        [Name("ignoreDestructibleStructures")] public bool? @ignoreDestructibleStructures { get; set; }
        [Name("ignoreRoads")] public bool? @ignoreRoads { get; set; }
        [Name("costCallback")] public dynamic @costCallback { get; set; }
        [Name("ignore")] public dynamic @ignore { get; set; }
        [Name("avoid")] public dynamic @avoid { get; set; }
        [Name("maxOps")] public double? @maxOps { get; set; }
        [Name("heuristicWeight")] public double? @heuristicWeight { get; set; }
        [Name("serialize")] public bool? @serialize { get; set; }
        [Name("maxRooms")] public double? @maxRooms { get; set; }
        [Name("range")] public double? @range { get; set; }
        [Name("plainCost")] public double? @plainCost { get; set; }
        [Name("swampCost")] public double? @swampCost { get; set; }
    }
    [External]
    public class MoveToOpts : FindPathOpts
    {
        protected MoveToOpts() {}
        [Name("reusePath")] public double? @reusePath { get; set; }
        [Name("serializeMemory")] public bool? @serializeMemory { get; set; }
        [Name("noPathFinding")] public bool? @noPathFinding { get; set; }
        [Name("visualizePathStyle")] public PolyStyle @visualizePathStyle { get; set; }
    }
    [External]
    public class PathStep
    {
        protected PathStep() {}
        [Name("x")] public double @x { get; set; }
        [Name("dx")] public double @dx { get; set; }
        [Name("y")] public double @y { get; set; }
        [Name("dy")] public double @dy { get; set; }
        [Name("direction")] public double @direction { get; set; }
    }
    [External]
    public class _Constructor
    {
        protected _Constructor() {}
        [Name("prototype")] public dynamic @prototype { get; }
    }
    [External]
    public class _ConstructorById : _Constructor
    {
        protected _ConstructorById() {}
        [Template("new ({this})({0})")] public extern dynamic New(string @id);
    }
    [External]
    public class InterShardMemory
    {
        protected InterShardMemory() {}
        public extern dynamic this[string key] { get; set; }
        [Name("getLocal")] public extern string @getLocal();
        [Name("setLocal")] public extern void @setLocal(string @value);
        [Name("getRemote")] public extern string @getRemote(string @shard);
    }
    [External]
    public class FilterOptions
    {
        protected FilterOptions() {}
        [Name("filter")] public dynamic @filter { get; set; }
    }
    [External]
    public class EventData
    {
        protected EventData() {}
    }
    [External]
    public class POWER_CLASS
    {
        protected POWER_CLASS() {}
        [Name("OPERATOR")] public string @OPERATOR { get; set; }
    }
    [External]
    public class RouteOptions
    {
        protected RouteOptions() {}
        [Name("routeCallback")] public dynamic @routeCallback { get; set; }
    }
    [External]
    public class RoomStatusPermanent
    {
        protected RoomStatusPermanent() {}
        [Name("status")] public string @status { get; set; }
        [Name("timestamp")] public dynamic @timestamp { get; set; }
    }
    [External]
    public class RoomStatusTemporary
    {
        protected RoomStatusTemporary() {}
        [Name("status")] public string @status { get; set; }
        [Name("timestamp")] public double @timestamp { get; set; }
    }
    [External]
    public class GameMap
    {
        protected GameMap() {}
        [Name("visual")] public MapVisual @visual { get; set; }
        [Name("describeExits")] public extern dynamic @describeExits(string @roomName);
        [Name("findExit")] public extern double @findExit(object @fromRoom, object @toRoom);
        [Name("findExit")] public extern double @findExit(object @fromRoom, object @toRoom, RouteOptions @opts);
        [Name("findRoute")] public extern dynamic @findRoute(object @fromRoom, object @toRoom);
        [Name("findRoute")] public extern dynamic @findRoute(object @fromRoom, object @toRoom, RouteOptions @opts);
        [Name("getRoomLinearDistance")] public extern double @getRoomLinearDistance(string @roomName1, string @roomName2);
        [Name("getRoomLinearDistance")] public extern double @getRoomLinearDistance(string @roomName1, string @roomName2, bool @continuous);
        [Name("getTerrainAt")] public extern string @getTerrainAt(double @x, double @y, string @roomName);
        [Name("getTerrainAt")] public extern string @getTerrainAt(RoomPosition @pos);
        [Name("getRoomTerrain")] public extern RoomTerrain @getRoomTerrain(string @roomName);
        [Name("getWorldSize")] public extern double @getWorldSize();
        [Name("isRoomAvailable")] public extern bool @isRoomAvailable(string @roomName);
        [Name("getRoomStatus")] public extern dynamic @getRoomStatus(string @roomName);
    }
    [External]
    public class MapVisual
    {
        protected MapVisual() {}
        [Name("line")] public extern MapVisual @line(RoomPosition @pos1, RoomPosition @pos2);
        [Name("line")] public extern MapVisual @line(RoomPosition @pos1, RoomPosition @pos2, MapLineStyle @style);
        [Name("circle")] public extern MapVisual @circle(RoomPosition @pos);
        [Name("circle")] public extern MapVisual @circle(RoomPosition @pos, MapCircleStyle @style);
        [Name("rect")] public extern MapVisual @rect(RoomPosition @topLeftPos, double @width, double @height);
        [Name("rect")] public extern MapVisual @rect(RoomPosition @topLeftPos, double @width, double @height, MapPolyStyle @style);
        [Name("poly")] public extern MapVisual @poly(RoomPosition[] @points);
        [Name("poly")] public extern MapVisual @poly(RoomPosition[] @points, MapPolyStyle @style);
        [Name("text")] public extern MapVisual @text(string @text, RoomPosition @pos);
        [Name("text")] public extern MapVisual @text(string @text, RoomPosition @pos, MapTextStyle @style);
        [Name("clear")] public extern MapVisual @clear();
        [Name("getSize")] public extern double @getSize();
        [Name("export")] public extern string @export();
        [Name("import")] public extern MapVisual @import(string @data);
    }
    [External]
    public class MapLineStyle
    {
        protected MapLineStyle() {}
        [Name("width")] public double? @width { get; set; }
        [Name("color")] public string @color { get; set; }
        [Name("opacity")] public double? @opacity { get; set; }
        [Name("lineStyle")] public string @lineStyle { get; set; }
    }
    [External]
    public class MapPolyStyle
    {
        protected MapPolyStyle() {}
        [Name("fill")] public string @fill { get; set; }
        [Name("opacity")] public double? @opacity { get; set; }
        [Name("stroke")] public string @stroke { get; set; }
        [Name("strokeWidth")] public double? @strokeWidth { get; set; }
        [Name("lineStyle")] public string @lineStyle { get; set; }
    }
    [External]
    public class MapCircleStyle : MapPolyStyle
    {
        protected MapCircleStyle() {}
        [Name("radius")] public double? @radius { get; set; }
    }
    [External]
    public class MapTextStyle
    {
        protected MapTextStyle() {}
        [Name("color")] public string @color { get; set; }
        [Name("fontFamily")] public string @fontFamily { get; set; }
        [Name("fontSize")] public double? @fontSize { get; set; }
        [Name("fontStyle")] public string @fontStyle { get; set; }
        [Name("fontVariant")] public string @fontVariant { get; set; }
        [Name("stroke")] public string @stroke { get; set; }
        [Name("strokeWidth")] public double? @strokeWidth { get; set; }
        [Name("backgroundColor")] public string @backgroundColor { get; set; }
        [Name("backgroundPadding")] public double? @backgroundPadding { get; set; }
        [Name("align")] public string @align { get; set; }
        [Name("opacity")] public double? @opacity { get; set; }
    }
    [External]
    public class Market
    {
        protected Market() {}
        [Name("credits")] public double @credits { get; set; }
        [Name("incomingTransactions")] public Transaction[] @incomingTransactions { get; set; }
        [Name("orders")] public NativeMap<Order> @orders { get; set; }
        [Name("outgoingTransactions")] public Transaction[] @outgoingTransactions { get; set; }
        [Name("calcTransactionCost")] public extern double @calcTransactionCost(double @amount, string @roomName1, string @roomName2);
        [Name("cancelOrder")] public extern double @cancelOrder(string @orderId);
        [Name("changeOrderPrice")] public extern double @changeOrderPrice(string @orderId, double @newPrice);
        [Name("createOrder")] public extern double @createOrder(CreateOrderParam @params);
        [Name("deal")] public extern double @deal(string @orderId, double @amount);
        [Name("deal")] public extern double @deal(string @orderId, double @amount, string @yourRoomName);
        [Name("extendOrder")] public extern double @extendOrder(string @orderId, double @addAmount);
        [Name("getAllOrders")] public extern Order[] @getAllOrders();
        [Name("getAllOrders")] public extern Order[] @getAllOrders(object @filter);
        [Name("getHistory")] public extern PriceHistory[] @getHistory();
        [Name("getHistory")] public extern PriceHistory[] @getHistory(object @resource);
        [Name("getOrderById")] public extern Order @getOrderById(string @id);
    }
    [External]
    public class Transaction
    {
        protected Transaction() {}
        [Name("transactionId")] public string @transactionId { get; set; }
        [Name("time")] public double @time { get; set; }
        [Name("sender")] public dynamic @sender { get; set; }
        [Name("recipient")] public dynamic @recipient { get; set; }
        [Name("resourceType")] public dynamic @resourceType { get; set; }
        [Name("amount")] public double @amount { get; set; }
        [Name("from")] public string @from { get; set; }
        [Name("to")] public string @to { get; set; }
        [Name("description")] public string @description { get; set; }
        [Name("order")] public TransactionOrder @order { get; set; }
    }
    [External]
    public class Order
    {
        protected Order() {}
        [Name("id")] public string @id { get; set; }
        [Name("created")] public double @created { get; set; }
        [Name("active")] public bool? @active { get; set; }
        [Name("type")] public string @type { get; set; }
        [Name("resourceType")] public dynamic @resourceType { get; set; }
        [Name("roomName")] public string @roomName { get; set; }
        [Name("amount")] public double @amount { get; set; }
        [Name("remainingAmount")] public double @remainingAmount { get; set; }
        [Name("totalAmount")] public double? @totalAmount { get; set; }
        [Name("price")] public double @price { get; set; }
    }
    [External]
    public class TransactionOrder
    {
        protected TransactionOrder() {}
        [Name("id")] public string @id { get; set; }
        [Name("type")] public string @type { get; set; }
        [Name("price")] public double @price { get; set; }
    }
    [External]
    public class OrderFilter
    {
        protected OrderFilter() {}
        [Name("id")] public string @id { get; set; }
        [Name("created")] public double? @created { get; set; }
        [Name("type")] public string @type { get; set; }
        [Name("resourceType")] public dynamic @resourceType { get; set; }
        [Name("roomName")] public string @roomName { get; set; }
        [Name("amount")] public double? @amount { get; set; }
        [Name("remainingAmount")] public double? @remainingAmount { get; set; }
        [Name("price")] public double? @price { get; set; }
    }
    [External]
    public class PriceHistory
    {
        protected PriceHistory() {}
        [Name("resourceType")] public dynamic @resourceType { get; set; }
        [Name("date")] public string @date { get; set; }
        [Name("transactions")] public double @transactions { get; set; }
        [Name("volume")] public double @volume { get; set; }
        [Name("avgPrice")] public double @avgPrice { get; set; }
        [Name("stddevPrice")] public double @stddevPrice { get; set; }
    }
    [External]
    public class CreateOrderParam
    {
        protected CreateOrderParam() {}
        [Name("type")] public string @type { get; set; }
        [Name("resourceType")] public dynamic @resourceType { get; set; }
        [Name("price")] public double @price { get; set; }
        [Name("totalAmount")] public double @totalAmount { get; set; }
        [Name("roomName")] public string @roomName { get; set; }
    }
    [External]
    public class Memory
    {
        protected Memory() {}
        [Name("creeps")] public NativeMap<CreepMemory> @creeps { get; set; }
        [Name("powerCreeps")] public NativeMap<PowerCreepMemory> @powerCreeps { get; set; }
        [Name("flags")] public NativeMap<FlagMemory> @flags { get; set; }
        [Name("rooms")] public NativeMap<RoomMemory> @rooms { get; set; }
        [Name("spawns")] public NativeMap<SpawnMemory> @spawns { get; set; }
        public extern dynamic this[string key] { get; set; }
    }
    [External]
    public class CreepMemory
    {
        protected CreepMemory() {}
        public extern dynamic this[string key] { get; set; }
    }
    [External]
    public class FlagMemory
    {
        protected FlagMemory() {}
        public extern dynamic this[string key] { get; set; }
    }
    [External]
    public class PowerCreepMemory
    {
        protected PowerCreepMemory() {}
        public extern dynamic this[string key] { get; set; }
    }
    [External]
    public class RoomMemory
    {
        protected RoomMemory() {}
        public extern dynamic this[string key] { get; set; }
    }
    [External]
    public class SpawnMemory
    {
        protected SpawnMemory() {}
        public extern dynamic this[string key] { get; set; }
    }
    [External]
    public class Mineral : RoomObject
    {
        protected Mineral() {}
        [Name("prototype")] public Mineral @prototype { get; }
        [Name("density")] public double @density { get; set; }
        [Name("mineralAmount")] public double @mineralAmount { get; set; }
        [Name("mineralType")] public dynamic @mineralType { get; set; }
        [Name("id")] public string @id { get; set; }
        [Name("ticksToRegeneration")] public double? @ticksToRegeneration { get; set; }
    }
    [External]
    public class MineralConstructor : _Constructor
    {
        protected MineralConstructor() {}
        [Template("new ({this})({0})")] public extern Mineral New(string id);
    }
    [External]
    public class Nuke : RoomObject
    {
        protected Nuke() {}
        [Name("prototype")] public Nuke @prototype { get; }
        [Name("id")] public string @id { get; set; }
        [Name("launchRoomName")] public string @launchRoomName { get; set; }
        [Name("timeToLand")] public double @timeToLand { get; set; }
    }
    [External]
    public class NukeConstructor : _Constructor
    {
        protected NukeConstructor() {}
        [Template("new ({this})({0})")] public extern Nuke New(string id);
    }
    [External]
    public class PathFinder
    {
        protected PathFinder() {}
        [Name("CostMatrix")] public CostMatrixConstructor @CostMatrix { get; set; }
        [Name("search")] public extern PathFinderPath @search(RoomPosition @origin, object @goal);
        [Name("search")] public extern PathFinderPath @search(RoomPosition @origin, object @goal, PathFinderOpts @opts);
        [Name("use")] public extern dynamic @use(bool @isEnabled);
    }
    [External]
    public class PathFinderPath
    {
        protected PathFinderPath() {}
        [Name("path")] public RoomPosition[] @path { get; set; }
        [Name("ops")] public double @ops { get; set; }
        [Name("cost")] public double @cost { get; set; }
        [Name("incomplete")] public bool @incomplete { get; set; }
    }
    [External]
    public class PathFinderOpts
    {
        protected PathFinderOpts() {}
        [Name("plainCost")] public double? @plainCost { get; set; }
        [Name("swampCost")] public double? @swampCost { get; set; }
        [Name("flee")] public bool? @flee { get; set; }
        [Name("maxOps")] public double? @maxOps { get; set; }
        [Name("maxRooms")] public double? @maxRooms { get; set; }
        [Name("maxCost")] public double? @maxCost { get; set; }
        [Name("heuristicWeight")] public double? @heuristicWeight { get; set; }
        [Name("roomCallback")] public extern dynamic @roomCallback(string @roomName);
    }
    [External]
    public class CostMatrixConstructor : _Constructor
    {
        protected CostMatrixConstructor() {}
        [Template("new ({this})()")] public extern CostMatrix New();
        [Name("deserialize")] public extern CostMatrix @deserialize(double[] @val);
    }
    [External]
    public class CostMatrix
    {
        protected CostMatrix() {}
        [Name("set")] public extern dynamic @set(double @x, double @y, double @cost);
        [Name("get")] public extern double @get(double @x, double @y);
        [Name("clone")] public extern CostMatrix @clone();
        [Name("serialize")] public extern double[] @serialize();
    }
    [External]
    public class PowerCreep : RoomObject
    {
        protected PowerCreep() {}
        [Name("carry")] public GenericStoreBase @carry { get; set; }
        [Name("carryCapacity")] public double @carryCapacity { get; set; }
        [Name("className")] public dynamic @className { get; set; }
        [Name("deleteTime")] public double? @deleteTime { get; set; }
        [Name("hits")] public double @hits { get; set; }
        [Name("hitsMax")] public double @hitsMax { get; set; }
        [Name("id")] public string @id { get; set; }
        [Name("level")] public double @level { get; set; }
        [Name("memory")] public PowerCreepMemory @memory { get; set; }
        [Name("my")] public bool @my { get; set; }
        [Name("name")] public string @name { get; set; }
        [Name("owner")] public Owner @owner { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("powers")] public PowerCreepPowers @powers { get; set; }
        [Name("saying")] public string @saying { get; set; }
        [Name("shard")] public string @shard { get; set; }
        [Name("spawnCooldownTime")] public double? @spawnCooldownTime { get; set; }
        [Name("ticksToLive")] public double? @ticksToLive { get; set; }
        [Name("cancelOrder")] public extern double @cancelOrder(string @methodName);
        [Name("delete")] public extern double @delete();
        [Name("delete")] public extern double @delete(bool @cancel);
        [Name("drop")] public extern double @drop(string @resourceType);
        [Name("drop")] public extern double @drop(string @resourceType, double @amount);
        [Name("enableRoom")] public extern double @enableRoom(StructureController @controller);
        [Name("move")] public extern double @move(object @direction);
        [Name("moveByPath")] public extern double @moveByPath(object @path);
        [Name("moveTo")] public extern double @moveTo(object @x, object @y);
        [Name("moveTo")] public extern double @moveTo(double @x, double @y, MoveToOpts @opts);
        [Name("moveTo")] public extern double @moveTo(object @target);
        [Name("notifyWhenAttacked")] public extern double @notifyWhenAttacked(bool @enabled);
        [Name("pickup")] public extern double @pickup(Resource @target);
        [Name("rename")] public extern double @rename(string @name);
        [Name("renew")] public extern double @renew(object @target);
        [Name("say")] public extern double @say(string @message);
        [Name("say")] public extern double @say(string @message, bool @toPublic);
        [Name("spawn")] public extern double @spawn(StructurePowerSpawn @powerSpawn);
        [Name("suicide")] public extern double @suicide();
        [Name("transfer")] public extern double @transfer(object @target, string @resourceType);
        [Name("transfer")] public extern double @transfer(object @target, string @resourceType, double @amount);
        [Name("upgrade")] public extern double @upgrade(double @power);
        [Name("usePower")] public extern double @usePower(double @power);
        [Name("usePower")] public extern double @usePower(double @power, RoomObject @target);
        [Name("withdraw")] public extern double @withdraw(object @target, string @resourceType);
        [Name("withdraw")] public extern double @withdraw(object @target, string @resourceType, double @amount);
    }
    [External]
    public class PowerCreepConstructor : _Constructor
    {
        protected PowerCreepConstructor() {}
        [Template("new ({this})({0})")] public extern PowerCreep New(string id);
        [Name("create")] public extern double @create(string @name, object @className);
    }
    [External]
    public class PowerCreepPowers
    {
        protected PowerCreepPowers() {}
        public extern dynamic this[double key] { get; set; }
    }
    [External]
    public class RawMemory
    {
        protected RawMemory() {}
        [Name("segments")] public NativeMap<string> @segments { get; set; }
        [Name("foreignSegment")] public dynamic @foreignSegment { get; set; }
        [Name("interShardSegment")] public string @interShardSegment { get; set; }
        public extern dynamic this[string key] { get; set; }
        [Name("get")] public extern string @get();
        [Name("set")] public extern dynamic @set(string @value);
        [Name("setActiveSegments")] public extern dynamic @setActiveSegments(double[] @ids);
        [Name("setActiveForeignSegment")] public extern dynamic @setActiveForeignSegment(string @username);
        [Name("setActiveForeignSegment")] public extern dynamic @setActiveForeignSegment(string @username, double @id);
        [Name("setDefaultPublicSegment")] public extern dynamic @setDefaultPublicSegment(double? @id);
        [Name("setPublicSegments")] public extern dynamic @setPublicSegments(double[] @ids);
    }
    [External]
    public class Resource : RoomObject
    {
        protected Resource() {}
        [Name("prototype")] public Resource @prototype { get; }
        [Name("amount")] public double @amount { get; set; }
        [Name("id")] public string @id { get; set; }
        [Name("resourceType")] public dynamic @resourceType { get; set; }
    }
    [External]
    public class ResourceConstructor : _Constructor
    {
        protected ResourceConstructor() {}
        [Template("new ({this})({0})")] public extern Resource New(string id);
    }
    [External]
    public class RoomObject
    {
        protected RoomObject() {}
        [Name("prototype")] public RoomObject @prototype { get; }
        [Name("effects")] public dynamic[] @effects { get; set; }
        [Name("pos")] public RoomPosition @pos { get; set; }
        [Name("room")] public Room @room { get; set; }
    }
    [External]
    public class RoomObjectConstructor : _Constructor
    {
        protected RoomObjectConstructor() {}
        [Template("new ({this})({0}, {1}, {2})")] public extern RoomObject New(double @x, double @y, string @roomName);
    }
    [External]
    public class NaturalEffect
    {
        protected NaturalEffect() {}
        [Name("effect")] public double @effect { get; set; }
        [Name("ticksRemaining")] public double @ticksRemaining { get; set; }
    }
    [External]
    public class PowerEffect
    {
        protected PowerEffect() {}
        [Name("level")] public double @level { get; set; }
        [Name("effect")] public double @effect { get; set; }
        [Name("power")] public double @power { get; set; }
        [Name("ticksRemaining")] public double @ticksRemaining { get; set; }
    }
    [External]
    public class RoomPosition
    {
        protected RoomPosition() {}
        [Name("prototype")] public RoomPosition @prototype { get; }
        [Name("roomName")] public string @roomName { get; set; }
        [Name("x")] public double @x { get; set; }
        [Name("y")] public double @y { get; set; }
        [Name("createConstructionSite")] public extern double @createConstructionSite(string @structureType);
        [Name("createConstructionSite")] public extern double @createConstructionSite(string @structureType, string @name);
        [Name("createFlag")] public extern dynamic @createFlag();
        [Name("createFlag")] public extern dynamic @createFlag(string @name);
        [Name("createFlag")] public extern dynamic @createFlag(string @name, double @color);
        [Name("createFlag")] public extern dynamic @createFlag(string @name, double @color, double @secondaryColor);
        [Name("findClosestByPath")] public extern dynamic @findClosestByPath(object @type);
        [Name("findClosestByPath")] public extern dynamic @findClosestByPath(object @type, object @opts);
        [Name("findClosestByRange")] public extern dynamic @findClosestByRange(object @type);
        [Name("findClosestByRange")] public extern dynamic @findClosestByRange(object @type, FilterOptions @opts);
        [Name("findInRange")] public extern dynamic[] @findInRange(object @type, double @range);
        [Name("findInRange")] public extern dynamic[] @findInRange(object @type, double @range, FilterOptions @opts);
        [Name("findPathTo")] public extern PathStep[] @findPathTo(object @x, object @y);
        [Name("findPathTo")] public extern PathStep[] @findPathTo(double @x, double @y, FindPathOpts @opts);
        [Name("findPathTo")] public extern PathStep[] @findPathTo(object @target);
        [Name("getDirectionTo")] public extern double @getDirectionTo(double @x, double @y);
        [Name("getDirectionTo")] public extern double @getDirectionTo(object @target);
        [Name("getRangeTo")] public extern double @getRangeTo(double @x, double @y);
        [Name("getRangeTo")] public extern double @getRangeTo(object @target);
        [Name("inRangeTo")] public extern bool @inRangeTo(double @x, double @y, double @range);
        [Name("inRangeTo")] public extern bool @inRangeTo(object @target, double @range);
        [Name("isEqualTo")] public extern bool @isEqualTo(double @x, double @y);
        [Name("isEqualTo")] public extern bool @isEqualTo(object @target);
        [Name("isNearTo")] public extern bool @isNearTo(double @x, double @y);
        [Name("isNearTo")] public extern bool @isNearTo(object @target);
        [Name("look")] public extern dynamic[] @look();
        [Name("lookFor")] public extern dynamic[] @lookFor(object @type);
    }
    [External]
    public class RoomPositionConstructor : _Constructor
    {
        protected RoomPositionConstructor() {}
        [Template("new ({this})({0}, {1}, {2})")] public extern RoomPosition New(double @x, double @y, string @roomName);
    }
    [External]
    public class RoomTerrain
    {
        protected RoomTerrain() {}
        [Name("get")] public extern double @get(double @x, double @y);
        [Name("getRawBuffer")] public extern dynamic @getRawBuffer(object @destinationArray);
        [Name("getRawBuffer")] public extern dynamic @getRawBuffer();
    }
    [External]
    public class RoomTerrainConstructor : _Constructor
    {
        protected RoomTerrainConstructor() {}
        [Template("new ({this})({0})")] public extern RoomTerrain New(string @roomName);
    }
    [External]
    public class RoomVisual
    {
        protected RoomVisual() {}
        [Name("roomName")] public string @roomName { get; set; }
        [Name("line")] public extern RoomVisual @line(double @x1, double @y1, double @x2, double @y2);
        [Name("line")] public extern RoomVisual @line(double @x1, double @y1, double @x2, double @y2, LineStyle @style);
        [Name("line")] public extern RoomVisual @line(RoomPosition @pos1, RoomPosition @pos2);
        [Name("line")] public extern RoomVisual @line(RoomPosition @pos1, RoomPosition @pos2, LineStyle @style);
        [Name("circle")] public extern RoomVisual @circle(object @x, object @y);
        [Name("circle")] public extern RoomVisual @circle(double @x, double @y, CircleStyle @style);
        [Name("circle")] public extern RoomVisual @circle(RoomPosition @pos);
        [Name("rect")] public extern RoomVisual @rect(object @x, double @y, double @w, object @h);
        [Name("rect")] public extern RoomVisual @rect(double @x, double @y, double @w, double @h, PolyStyle @style);
        [Name("rect")] public extern RoomVisual @rect(RoomPosition @topLeftPos, double @width, double @height);
        [Name("poly")] public extern RoomVisual @poly(dynamic[] @points);
        [Name("poly")] public extern RoomVisual @poly(dynamic[] @points, PolyStyle @style);
        [Name("text")] public extern RoomVisual @text(string @text, object @x, object @y);
        [Name("text")] public extern RoomVisual @text(string @text, double @x, double @y, TextStyle @style);
        [Name("text")] public extern RoomVisual @text(string @text, RoomPosition @pos);
        [Name("clear")] public extern RoomVisual @clear();
        [Name("getSize")] public extern double @getSize();
        [Name("export")] public extern string @export();
        [Name("import")] public extern RoomVisual @import(string @data);
    }
    [External]
    public class LineStyle
    {
        protected LineStyle() {}
        [Name("width")] public double? @width { get; set; }
        [Name("color")] public string @color { get; set; }
        [Name("opacity")] public double? @opacity { get; set; }
        [Name("lineStyle")] public string @lineStyle { get; set; }
    }
    [External]
    public class PolyStyle
    {
        protected PolyStyle() {}
        [Name("fill")] public string @fill { get; set; }
        [Name("opacity")] public double? @opacity { get; set; }
        [Name("stroke")] public string @stroke { get; set; }
        [Name("strokeWidth")] public double? @strokeWidth { get; set; }
        [Name("lineStyle")] public string @lineStyle { get; set; }
    }
    [External]
    public class CircleStyle : PolyStyle
    {
        protected CircleStyle() {}
        [Name("radius")] public double? @radius { get; set; }
    }
    [External]
    public class TextStyle
    {
        protected TextStyle() {}
        [Name("color")] public string @color { get; set; }
        [Name("font")] public dynamic @font { get; set; }
        [Name("stroke")] public string @stroke { get; set; }
        [Name("strokeWidth")] public double? @strokeWidth { get; set; }
        [Name("backgroundColor")] public string @backgroundColor { get; set; }
        [Name("backgroundPadding")] public double? @backgroundPadding { get; set; }
        [Name("align")] public string @align { get; set; }
        [Name("opacity")] public double? @opacity { get; set; }
    }
    [External]
    public class Room
    {
        protected Room() {}
        [Name("prototype")] public Room @prototype { get; }
        [Name("controller")] public StructureController @controller { get; set; }
        [Name("energyAvailable")] public double @energyAvailable { get; set; }
        [Name("energyCapacityAvailable")] public double @energyCapacityAvailable { get; set; }
        [Name("memory")] public RoomMemory @memory { get; set; }
        [Name("name")] public string @name { get; }
        [Name("storage")] public StructureStorage @storage { get; set; }
        [Name("terminal")] public StructureTerminal @terminal { get; set; }
        [Name("visual")] public RoomVisual @visual { get; set; }
        [Name("getEventLog")] public extern dynamic[] @getEventLog();
        [Name("getEventLog")] public extern dynamic @getEventLog(bool @raw);
        [Name("createConstructionSite")] public extern double @createConstructionSite(object @x, object @y, string @structureType);
        [Name("createConstructionSite")] public extern double @createConstructionSite(object @pos, string @structureType);
        [Name("createConstructionSite")] public extern double @createConstructionSite(double @x, double @y, string @structureType, string @name);
        [Name("createFlag")] public extern dynamic @createFlag(object @x, object @y);
        [Name("createFlag")] public extern dynamic @createFlag(object @x, object @y, object @name);
        [Name("createFlag")] public extern dynamic @createFlag(object @x, object @y, object @name, double @color);
        [Name("createFlag")] public extern dynamic @createFlag(double @x, double @y, string @name, double @color, double @secondaryColor);
        [Name("createFlag")] public extern dynamic @createFlag(object @pos);
        [Name("find")] public extern dynamic[] @find(object @type);
        [Name("find")] public extern dynamic[] @find(object @type, FilterOptions @opts);
        [Name("findExitTo")] public extern double @findExitTo(object @room);
        [Name("findPath")] public extern PathStep[] @findPath(RoomPosition @fromPos, RoomPosition @toPos);
        [Name("findPath")] public extern PathStep[] @findPath(RoomPosition @fromPos, RoomPosition @toPos, FindPathOpts @opts);
        [Name("getPositionAt")] public extern RoomPosition @getPositionAt(double @x, double @y);
        [Name("getTerrain")] public extern RoomTerrain @getTerrain();
        [Name("lookAt")] public extern dynamic[] @lookAt(double @x, double @y);
        [Name("lookAt")] public extern dynamic[] @lookAt(object @target);
        [Name("lookAtArea")] public extern LookAtResultMatrix @lookAtArea(double @top, double @left, double @bottom, double @right);
        [Name("lookAtArea")] public extern dynamic @lookAtArea(double @top, double @left, double @bottom, double @right, bool @asArray);
        [Name("lookForAt")] public extern dynamic[] @lookForAt(object @type, double @x, double @y);
        [Name("lookForAt")] public extern dynamic[] @lookForAt(object @type, object @target);
        [Name("lookForAtArea")] public extern LookForAtAreaResultMatrix @lookForAtArea(object @type, double @top, double @left, double @bottom, double @right);
        [Name("lookForAtArea")] public extern dynamic @lookForAtArea(object @type, double @top, double @left, double @bottom, double @right, bool @asArray);
    }
    [External]
    public class RoomConstructor : _Constructor
    {
        protected RoomConstructor() {}
        [Name("Terrain")] public RoomTerrainConstructor @Terrain { get; set; }
        [Template("new ({this})({0})")] public extern Room New(string @id);
        [Name("serializePath")] public extern string @serializePath(PathStep[] @path);
        [Name("deserializePath")] public extern PathStep[] @deserializePath(string @path);
    }
    [External]
    public class Ruin : RoomObject
    {
        protected Ruin() {}
        [Name("id")] public string @id { get; set; }
        [Name("destroyTime")] public double @destroyTime { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("ticksToDecay")] public double @ticksToDecay { get; set; }
        [Name("structure")] public dynamic @structure { get; set; }
    }
    [External]
    public class RuinConstructor : _Constructor
    {
        protected RuinConstructor() {}
        [Template("new ({this})({0})")] public extern Ruin New(string id);
    }
    [External]
    public class Source : RoomObject
    {
        protected Source() {}
        [Name("prototype")] public Source @prototype { get; }
        [Name("energy")] public double @energy { get; set; }
        [Name("energyCapacity")] public double @energyCapacity { get; set; }
        [Name("id")] public string @id { get; set; }
        [Name("room")] public Room @room { get; set; }
        [Name("ticksToRegeneration")] public double @ticksToRegeneration { get; set; }
    }
    [External]
    public class SourceConstructor : _Constructor
    {
        protected SourceConstructor() {}
        [Template("new ({this})({0})")] public extern Source New(string id);
    }
    [External]
    public class StructureSpawn : OwnedStructure
    {
        protected StructureSpawn() {}
        [Name("prototype")] public StructureSpawn @prototype { get; }
        [Name("energy")] public double @energy { get; set; }
        [Name("energyCapacity")] public double @energyCapacity { get; set; }
        [Name("memory")] public SpawnMemory @memory { get; set; }
        [Name("name")] public string @name { get; set; }
        [Name("spawning")] public Spawning @spawning { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("canCreateCreep")] public extern double @canCreateCreep(string[] @body);
        [Name("canCreateCreep")] public extern double @canCreateCreep(string[] @body, string @name);
        [Name("createCreep")] public extern dynamic @createCreep(string[] @body);
        [Name("createCreep")] public extern dynamic @createCreep(string[] @body, string @name);
        [Name("createCreep")] public extern dynamic @createCreep(string[] @body, string @name, CreepMemory @memory);
        [Name("spawnCreep")] public extern double @spawnCreep(string[] @body, string @name);
        [Name("spawnCreep")] public extern double @spawnCreep(string[] @body, string @name, SpawnOptions @opts);
        [Name("renewCreep")] public extern double @renewCreep(Creep @target);
        [Name("recycleCreep")] public extern double @recycleCreep(Creep @target);
    }
    [External]
    public class StructureSpawnConstructor : _Constructor
    {
        protected StructureSpawnConstructor() {}
        [Name("Spawning")] public SpawningConstructor @Spawning { get; set; }
        [Template("new ({this})({0})")] public extern StructureSpawn New(string id);
    }
    [External]
    public class Spawning
    {
        protected Spawning() {}
        [Name("prototype")] public Spawning @prototype { get; }
        [Name("directions")] public double[] @directions { get; set; }
        [Name("name")] public string @name { get; set; }
        [Name("needTime")] public double @needTime { get; set; }
        [Name("remainingTime")] public double @remainingTime { get; set; }
        [Name("spawn")] public StructureSpawn @spawn { get; set; }
        [Name("cancel")] public extern dynamic @cancel();
        [Name("setDirections")] public extern dynamic @setDirections(double[] @directions);
    }
    [External]
    public class SpawnOptions
    {
        protected SpawnOptions() {}
        [Name("memory")] public CreepMemory @memory { get; set; }
        [Name("energyStructures")] public dynamic[] @energyStructures { get; set; }
        [Name("dryRun")] public bool? @dryRun { get; set; }
        [Name("directions")] public double[] @directions { get; set; }
    }
    [External]
    public class SpawningConstructor : _Constructor
    {
        protected SpawningConstructor() {}
        [Template("new ({this})({0})")] public extern Spawning New(string @id);
    }
    [External]
    public class StoreBase
    {
        protected StoreBase() {}
        [Name("getCapacity")] public extern dynamic @getCapacity();
        [Name("getCapacity")] public extern dynamic @getCapacity(object @resource);
        [Name("getUsedCapacity")] public extern dynamic @getUsedCapacity();
        [Name("getUsedCapacity")] public extern dynamic @getUsedCapacity(object @resource);
        [Name("getFreeCapacity")] public extern dynamic @getFreeCapacity();
        [Name("getFreeCapacity")] public extern dynamic @getFreeCapacity(object @resource);
    }
    [External]
    public class GenericStoreBase
    {
        protected GenericStoreBase() {}
        public extern double this[string key] { get; set; }
        [Name("getCapacity")] public extern double? @getCapacity();
        [Name("getCapacity")] public extern double? @getCapacity(string @resource);
        [Name("getUsedCapacity")] public extern double? @getUsedCapacity();
        [Name("getUsedCapacity")] public extern double? @getUsedCapacity(string @resource);
        [Name("getFreeCapacity")] public extern double? @getFreeCapacity();
        [Name("getFreeCapacity")] public extern double? @getFreeCapacity(string @resource);
    }
    [External]
    public class Structure : RoomObject
    {
        protected Structure() {}
        [Name("prototype")] public Structure @prototype { get; }
        [Name("hits")] public double @hits { get; set; }
        [Name("hitsMax")] public double @hitsMax { get; set; }
        [Name("id")] public string @id { get; set; }
        [Name("room")] public Room @room { get; set; }
        [Name("structureType")] public dynamic @structureType { get; set; }
        [Name("destroy")] public extern double @destroy();
        [Name("isActive")] public extern bool @isActive();
        [Name("notifyWhenAttacked")] public extern double @notifyWhenAttacked(bool @enabled);
    }
    [External]
    public class StructureConstructor : _Constructor
    {
        protected StructureConstructor() {}
        [Template("new ({this})({0})")] public extern Structure New(string id);
    }
    [External]
    public class OwnedStructure : Structure
    {
        protected OwnedStructure() {}
        [Name("prototype")] public OwnedStructure @prototype { get; }
        [Name("my")] public bool @my { get; set; }
        [Name("owner")] public dynamic @owner { get; set; }
        [Name("room")] public Room @room { get; set; }
    }
    [External]
    public class OwnedStructureConstructor : _Constructor
    {
        protected OwnedStructureConstructor() {}
        [Template("new ({this})({0})")] public extern OwnedStructure New(string id);
    }
    [External]
    public class StructureController : OwnedStructure
    {
        protected StructureController() {}
        [Name("prototype")] public StructureController @prototype { get; }
        [Name("isPowerEnabled")] public bool @isPowerEnabled { get; set; }
        [Name("level")] public double @level { get; set; }
        [Name("progress")] public double @progress { get; set; }
        [Name("progressTotal")] public double @progressTotal { get; set; }
        [Name("reservation")] public ReservationDefinition @reservation { get; set; }
        [Name("safeMode")] public double? @safeMode { get; set; }
        [Name("safeModeAvailable")] public double @safeModeAvailable { get; set; }
        [Name("safeModeCooldown")] public double? @safeModeCooldown { get; set; }
        [Name("sign")] public SignDefinition @sign { get; set; }
        [Name("ticksToDowngrade")] public double @ticksToDowngrade { get; set; }
        [Name("upgradeBlocked")] public double @upgradeBlocked { get; set; }
        [Name("activateSafeMode")] public extern double @activateSafeMode();
        [Name("unclaim")] public extern double @unclaim();
    }
    [External]
    public class StructureControllerConstructor : _Constructor
    {
        protected StructureControllerConstructor() {}
        [Template("new ({this})({0})")] public extern StructureController New(string id);
    }
    [External]
    public class StructureExtension : OwnedStructure
    {
        protected StructureExtension() {}
        [Name("prototype")] public StructureExtension @prototype { get; }
        [Name("energy")] public double @energy { get; set; }
        [Name("energyCapacity")] public double @energyCapacity { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
    }
    [External]
    public class StructureExtensionConstructor : _Constructor
    {
        protected StructureExtensionConstructor() {}
        [Template("new ({this})({0})")] public extern StructureExtension New(string id);
    }
    [External]
    public class StructureLink : OwnedStructure
    {
        protected StructureLink() {}
        [Name("prototype")] public StructureLink @prototype { get; }
        [Name("cooldown")] public double @cooldown { get; set; }
        [Name("energy")] public double @energy { get; set; }
        [Name("energyCapacity")] public double @energyCapacity { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("transferEnergy")] public extern double @transferEnergy(StructureLink @target);
        [Name("transferEnergy")] public extern double @transferEnergy(StructureLink @target, double @amount);
    }
    [External]
    public class StructureLinkConstructor : _Constructor
    {
        protected StructureLinkConstructor() {}
        [Template("new ({this})({0})")] public extern StructureLink New(string id);
    }
    [External]
    public class StructureKeeperLair : OwnedStructure
    {
        protected StructureKeeperLair() {}
        [Name("prototype")] public StructureKeeperLair @prototype { get; }
        [Name("ticksToSpawn")] public double? @ticksToSpawn { get; set; }
    }
    [External]
    public class StructureKeeperLairConstructor : _Constructor
    {
        protected StructureKeeperLairConstructor() {}
        [Template("new ({this})({0})")] public extern StructureKeeperLair New(string id);
    }
    [External]
    public class StructureObserver : OwnedStructure
    {
        protected StructureObserver() {}
        [Name("prototype")] public StructureObserver @prototype { get; }
        [Name("observeRoom")] public extern double @observeRoom(string @roomName);
    }
    [External]
    public class StructureObserverConstructor : _Constructor
    {
        protected StructureObserverConstructor() {}
        [Template("new ({this})({0})")] public extern StructureObserver New(string id);
    }
    [External]
    public class StructurePowerBank : OwnedStructure
    {
        protected StructurePowerBank() {}
        [Name("prototype")] public StructurePowerBank @prototype { get; }
        [Name("power")] public double @power { get; set; }
        [Name("ticksToDecay")] public double @ticksToDecay { get; set; }
    }
    [External]
    public class StructurePowerBankConstructor : _Constructor
    {
        protected StructurePowerBankConstructor() {}
        [Template("new ({this})({0})")] public extern StructurePowerBank New(string id);
    }
    [External]
    public class StructurePowerSpawn : OwnedStructure
    {
        protected StructurePowerSpawn() {}
        [Name("prototype")] public StructurePowerSpawn @prototype { get; }
        [Name("energy")] public double @energy { get; set; }
        [Name("energyCapacity")] public double @energyCapacity { get; set; }
        [Name("power")] public double @power { get; set; }
        [Name("powerCapacity")] public double @powerCapacity { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("processPower")] public extern double @processPower();
    }
    [External]
    public class StructurePowerSpawnConstructor : _Constructor
    {
        protected StructurePowerSpawnConstructor() {}
        [Template("new ({this})({0})")] public extern StructurePowerSpawn New(string id);
    }
    [External]
    public class StructureRampart : OwnedStructure
    {
        protected StructureRampart() {}
        [Name("prototype")] public StructureRampart @prototype { get; }
        [Name("ticksToDecay")] public double @ticksToDecay { get; set; }
        [Name("isPublic")] public bool @isPublic { get; set; }
        [Name("setPublic")] public extern dynamic @setPublic(bool @isPublic);
    }
    [External]
    public class StructureRampartConstructor : _Constructor
    {
        protected StructureRampartConstructor() {}
        [Template("new ({this})({0})")] public extern StructureRampart New(string id);
    }
    [External]
    public class StructureRoad : Structure
    {
        protected StructureRoad() {}
        [Name("prototype")] public StructureRoad @prototype { get; }
        [Name("ticksToDecay")] public double @ticksToDecay { get; set; }
    }
    [External]
    public class StructureRoadConstructor : _Constructor
    {
        protected StructureRoadConstructor() {}
        [Template("new ({this})({0})")] public extern StructureRoad New(string id);
    }
    [External]
    public class StructureStorage : OwnedStructure
    {
        protected StructureStorage() {}
        [Name("prototype")] public StructureStorage @prototype { get; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("storeCapacity")] public double @storeCapacity { get; set; }
    }
    [External]
    public class StructureStorageConstructor : _Constructor
    {
        protected StructureStorageConstructor() {}
        [Template("new ({this})({0})")] public extern StructureStorage New(string id);
    }
    [External]
    public class StructureTower : OwnedStructure
    {
        protected StructureTower() {}
        [Name("prototype")] public StructureTower @prototype { get; }
        [Name("energy")] public double @energy { get; set; }
        [Name("energyCapacity")] public double @energyCapacity { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("attack")] public extern double @attack(object @target);
        [Name("heal")] public extern double @heal(object @target);
        [Name("repair")] public extern double @repair(Structure @target);
    }
    [External]
    public class StructureTowerConstructor : _Constructor
    {
        protected StructureTowerConstructor() {}
        [Template("new ({this})({0})")] public extern StructureTower New(string id);
    }
    [External]
    public class StructureWall : Structure
    {
        protected StructureWall() {}
        [Name("prototype")] public StructureWall @prototype { get; }
        [Name("ticksToLive")] public double @ticksToLive { get; set; }
    }
    [External]
    public class StructureWallConstructor : _Constructor
    {
        protected StructureWallConstructor() {}
        [Template("new ({this})({0})")] public extern StructureWall New(string id);
    }
    [External]
    public class StructureExtractor : OwnedStructure
    {
        protected StructureExtractor() {}
        [Name("prototype")] public StructureExtractor @prototype { get; }
        [Name("cooldown")] public double @cooldown { get; set; }
    }
    [External]
    public class StructureExtractorConstructor : _Constructor
    {
        protected StructureExtractorConstructor() {}
        [Template("new ({this})({0})")] public extern StructureExtractor New(string id);
    }
    [External]
    public class StructureLab : OwnedStructure
    {
        protected StructureLab() {}
        [Name("prototype")] public StructureLab @prototype { get; }
        [Name("cooldown")] public double @cooldown { get; set; }
        [Name("energy")] public double @energy { get; set; }
        [Name("energyCapacity")] public double @energyCapacity { get; set; }
        [Name("mineralAmount")] public double @mineralAmount { get; set; }
        [Name("mineralType")] public string @mineralType { get; set; }
        [Name("mineralCapacity")] public double @mineralCapacity { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("boostCreep")] public extern double @boostCreep(Creep @creep);
        [Name("boostCreep")] public extern double @boostCreep(Creep @creep, double @bodyPartsCount);
        [Name("unboostCreep")] public extern double @unboostCreep(Creep @creep);
        [Name("reverseReaction")] public extern double @reverseReaction(StructureLab @lab1, StructureLab @lab2);
        [Name("runReaction")] public extern double @runReaction(StructureLab @lab1, StructureLab @lab2);
    }
    [External]
    public class StructureLabConstructor : _Constructor
    {
        protected StructureLabConstructor() {}
        [Template("new ({this})({0})")] public extern StructureLab New(string id);
    }
    [External]
    public class StructureTerminal : OwnedStructure
    {
        protected StructureTerminal() {}
        [Name("prototype")] public StructureTerminal @prototype { get; }
        [Name("cooldown")] public double @cooldown { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("storeCapacity")] public double @storeCapacity { get; set; }
        [Name("send")] public extern double @send(string @resourceType, double @amount, string @destination);
        [Name("send")] public extern double @send(string @resourceType, double @amount, string @destination, string @description);
    }
    [External]
    public class StructureTerminalConstructor : _Constructor
    {
        protected StructureTerminalConstructor() {}
        [Template("new ({this})({0})")] public extern StructureTerminal New(string id);
    }
    [External]
    public class StructureContainer : Structure
    {
        protected StructureContainer() {}
        [Name("prototype")] public StructureContainer @prototype { get; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("storeCapacity")] public double @storeCapacity { get; set; }
        [Name("ticksToDecay")] public double @ticksToDecay { get; set; }
    }
    [External]
    public class StructureContainerConstructor : _Constructor
    {
        protected StructureContainerConstructor() {}
        [Template("new ({this})({0})")] public extern StructureContainer New(string id);
    }
    [External]
    public class StructureNuker : OwnedStructure
    {
        protected StructureNuker() {}
        [Name("prototype")] public StructureNuker @prototype { get; }
        [Name("energy")] public double @energy { get; set; }
        [Name("energyCapacity")] public double @energyCapacity { get; set; }
        [Name("ghodium")] public double @ghodium { get; set; }
        [Name("ghodiumCapacity")] public double @ghodiumCapacity { get; set; }
        [Name("cooldown")] public double @cooldown { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("launchNuke")] public extern double @launchNuke(RoomPosition @pos);
    }
    [External]
    public class StructureNukerConstructor : _Constructor
    {
        protected StructureNukerConstructor() {}
        [Template("new ({this})({0})")] public extern StructureNuker New(string id);
    }
    [External]
    public class StructurePortal : Structure
    {
        protected StructurePortal() {}
        [Name("prototype")] public StructurePortal @prototype { get; }
        [Name("destination")] public dynamic @destination { get; set; }
        [Name("ticksToDecay")] public double? @ticksToDecay { get; set; }
    }
    [External]
    public class StructurePortalConstructor : _Constructor
    {
        protected StructurePortalConstructor() {}
        [Template("new ({this})({0})")] public extern StructurePortal New(string id);
    }
    [External]
    public class StructureFactory : OwnedStructure
    {
        protected StructureFactory() {}
        [Name("prototype")] public StructureFactory @prototype { get; }
        [Name("cooldown")] public double @cooldown { get; set; }
        [Name("level")] public double? @level { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("produce")] public extern double @produce(string @resource);
    }
    [External]
    public class StructureFactoryConstructor : _Constructor
    {
        protected StructureFactoryConstructor() {}
        [Template("new ({this})({0})")] public extern StructureFactory New(string id);
    }
    [External]
    public class StructureInvaderCore : OwnedStructure
    {
        protected StructureInvaderCore() {}
        [Name("prototype")] public StructureInvaderCore @prototype { get; }
        [Name("level")] public double @level { get; set; }
        [Name("ticksToDeploy")] public double @ticksToDeploy { get; set; }
        [Name("spawning")] public Spawning @spawning { get; set; }
    }
    [External]
    public class StructureInvaderCoreConstructor : _Constructor
    {
        protected StructureInvaderCoreConstructor() {}
        [Template("new ({this})({0})")] public extern StructureInvaderCore New(string id);
    }
    [External]
    public class ConcreteStructureMap
    {
        protected ConcreteStructureMap() {}
    }
    [External]
    public class Tombstone : RoomObject
    {
        protected Tombstone() {}
        [Name("id")] public string @id { get; set; }
        [Name("deathTime")] public double @deathTime { get; set; }
        [Name("store")] public GenericStoreBase @store { get; set; }
        [Name("ticksToDecay")] public double @ticksToDecay { get; set; }
        [Name("creep")] public dynamic @creep { get; set; }
    }
    [External]
    public class TombstoneConstructor : _Constructor
    {
        protected TombstoneConstructor() {}
        [Template("new ({this})({0})")] public extern Tombstone New(string id);
    }
    public static partial class World
    {
        public static double @OK => Script.Write<double>("OK");
        public static double @ERR_NOT_OWNER => Script.Write<double>("ERR_NOT_OWNER");
        public static double @ERR_NO_PATH => Script.Write<double>("ERR_NO_PATH");
        public static double @ERR_NAME_EXISTS => Script.Write<double>("ERR_NAME_EXISTS");
        public static double @ERR_BUSY => Script.Write<double>("ERR_BUSY");
        public static double @ERR_NOT_FOUND => Script.Write<double>("ERR_NOT_FOUND");
        public static double @ERR_NOT_ENOUGH_RESOURCES => Script.Write<double>("ERR_NOT_ENOUGH_RESOURCES");
        public static double @ERR_NOT_ENOUGH_ENERGY => Script.Write<double>("ERR_NOT_ENOUGH_ENERGY");
        public static double @ERR_INVALID_TARGET => Script.Write<double>("ERR_INVALID_TARGET");
        public static double @ERR_FULL => Script.Write<double>("ERR_FULL");
        public static double @ERR_NOT_IN_RANGE => Script.Write<double>("ERR_NOT_IN_RANGE");
        public static double @ERR_INVALID_ARGS => Script.Write<double>("ERR_INVALID_ARGS");
        public static double @ERR_TIRED => Script.Write<double>("ERR_TIRED");
        public static double @ERR_NO_BODYPART => Script.Write<double>("ERR_NO_BODYPART");
        public static double @ERR_NOT_ENOUGH_EXTENSIONS => Script.Write<double>("ERR_NOT_ENOUGH_EXTENSIONS");
        public static double @ERR_RCL_NOT_ENOUGH => Script.Write<double>("ERR_RCL_NOT_ENOUGH");
        public static double @ERR_GCL_NOT_ENOUGH => Script.Write<double>("ERR_GCL_NOT_ENOUGH");
        public static double @ERR_ACCESS_DENIED => Script.Write<double>("ERR_ACCESS_DENIED");
        public static double @FIND_EXIT_TOP => Script.Write<double>("FIND_EXIT_TOP");
        public static double @FIND_EXIT_RIGHT => Script.Write<double>("FIND_EXIT_RIGHT");
        public static double @FIND_EXIT_BOTTOM => Script.Write<double>("FIND_EXIT_BOTTOM");
        public static double @FIND_EXIT_LEFT => Script.Write<double>("FIND_EXIT_LEFT");
        public static double @FIND_EXIT => Script.Write<double>("FIND_EXIT");
        public static double @FIND_CREEPS => Script.Write<double>("FIND_CREEPS");
        public static double @FIND_MY_CREEPS => Script.Write<double>("FIND_MY_CREEPS");
        public static double @FIND_HOSTILE_CREEPS => Script.Write<double>("FIND_HOSTILE_CREEPS");
        public static double @FIND_SOURCES_ACTIVE => Script.Write<double>("FIND_SOURCES_ACTIVE");
        public static double @FIND_SOURCES => Script.Write<double>("FIND_SOURCES");
        public static double @FIND_DROPPED_RESOURCES => Script.Write<double>("FIND_DROPPED_RESOURCES");
        public static double @FIND_STRUCTURES => Script.Write<double>("FIND_STRUCTURES");
        public static double @FIND_MY_STRUCTURES => Script.Write<double>("FIND_MY_STRUCTURES");
        public static double @FIND_HOSTILE_STRUCTURES => Script.Write<double>("FIND_HOSTILE_STRUCTURES");
        public static double @FIND_FLAGS => Script.Write<double>("FIND_FLAGS");
        public static double @FIND_CONSTRUCTION_SITES => Script.Write<double>("FIND_CONSTRUCTION_SITES");
        public static double @FIND_MY_SPAWNS => Script.Write<double>("FIND_MY_SPAWNS");
        public static double @FIND_HOSTILE_SPAWNS => Script.Write<double>("FIND_HOSTILE_SPAWNS");
        public static double @FIND_MY_CONSTRUCTION_SITES => Script.Write<double>("FIND_MY_CONSTRUCTION_SITES");
        public static double @FIND_HOSTILE_CONSTRUCTION_SITES => Script.Write<double>("FIND_HOSTILE_CONSTRUCTION_SITES");
        public static double @FIND_MINERALS => Script.Write<double>("FIND_MINERALS");
        public static double @FIND_NUKES => Script.Write<double>("FIND_NUKES");
        public static double @FIND_TOMBSTONES => Script.Write<double>("FIND_TOMBSTONES");
        public static double @FIND_POWER_CREEPS => Script.Write<double>("FIND_POWER_CREEPS");
        public static double @FIND_MY_POWER_CREEPS => Script.Write<double>("FIND_MY_POWER_CREEPS");
        public static double @FIND_HOSTILE_POWER_CREEPS => Script.Write<double>("FIND_HOSTILE_POWER_CREEPS");
        public static double @FIND_DEPOSITS => Script.Write<double>("FIND_DEPOSITS");
        public static double @FIND_RUINS => Script.Write<double>("FIND_RUINS");
        public static double @TOP => Script.Write<double>("TOP");
        public static double @TOP_RIGHT => Script.Write<double>("TOP_RIGHT");
        public static double @RIGHT => Script.Write<double>("RIGHT");
        public static double @BOTTOM_RIGHT => Script.Write<double>("BOTTOM_RIGHT");
        public static double @BOTTOM => Script.Write<double>("BOTTOM");
        public static double @BOTTOM_LEFT => Script.Write<double>("BOTTOM_LEFT");
        public static double @LEFT => Script.Write<double>("LEFT");
        public static double @TOP_LEFT => Script.Write<double>("TOP_LEFT");
        public static double @COLOR_RED => Script.Write<double>("COLOR_RED");
        public static double @COLOR_PURPLE => Script.Write<double>("COLOR_PURPLE");
        public static double @COLOR_BLUE => Script.Write<double>("COLOR_BLUE");
        public static double @COLOR_CYAN => Script.Write<double>("COLOR_CYAN");
        public static double @COLOR_GREEN => Script.Write<double>("COLOR_GREEN");
        public static double @COLOR_YELLOW => Script.Write<double>("COLOR_YELLOW");
        public static double @COLOR_ORANGE => Script.Write<double>("COLOR_ORANGE");
        public static double @COLOR_BROWN => Script.Write<double>("COLOR_BROWN");
        public static double @COLOR_GREY => Script.Write<double>("COLOR_GREY");
        public static double @COLOR_WHITE => Script.Write<double>("COLOR_WHITE");
        public static double[] @COLORS_ALL => Script.Write<double[]>("COLORS_ALL");
        public static double @CREEP_SPAWN_TIME => Script.Write<double>("CREEP_SPAWN_TIME");
        public static double @CREEP_LIFE_TIME => Script.Write<double>("CREEP_LIFE_TIME");
        public static double @CREEP_CLAIM_LIFE_TIME => Script.Write<double>("CREEP_CLAIM_LIFE_TIME");
        public static double @CREEP_CORPSE_RATE => Script.Write<double>("CREEP_CORPSE_RATE");
        public static dynamic @OBSTACLE_OBJECT_TYPES => Script.Write<dynamic>("OBSTACLE_OBJECT_TYPES");
        public static double @ENERGY_REGEN_TIME => Script.Write<double>("ENERGY_REGEN_TIME");
        public static double @ENERGY_DECAY => Script.Write<double>("ENERGY_DECAY");
        public static double @REPAIR_COST => Script.Write<double>("REPAIR_COST");
        public static double @RAMPART_DECAY_AMOUNT => Script.Write<double>("RAMPART_DECAY_AMOUNT");
        public static double @RAMPART_DECAY_TIME => Script.Write<double>("RAMPART_DECAY_TIME");
        public static double @RAMPART_HITS => Script.Write<double>("RAMPART_HITS");
        public static dynamic @RAMPART_HITS_MAX => Script.Write<dynamic>("RAMPART_HITS_MAX");
        public static double @SPAWN_HITS => Script.Write<double>("SPAWN_HITS");
        public static double @SPAWN_ENERGY_START => Script.Write<double>("SPAWN_ENERGY_START");
        public static double @SPAWN_ENERGY_CAPACITY => Script.Write<double>("SPAWN_ENERGY_CAPACITY");
        public static double @SOURCE_ENERGY_CAPACITY => Script.Write<double>("SOURCE_ENERGY_CAPACITY");
        public static double @SOURCE_ENERGY_NEUTRAL_CAPACITY => Script.Write<double>("SOURCE_ENERGY_NEUTRAL_CAPACITY");
        public static double @SOURCE_ENERGY_KEEPER_CAPACITY => Script.Write<double>("SOURCE_ENERGY_KEEPER_CAPACITY");
        public static double @WALL_HITS => Script.Write<double>("WALL_HITS");
        public static double @WALL_HITS_MAX => Script.Write<double>("WALL_HITS_MAX");
        public static double @EXTENSION_HITS => Script.Write<double>("EXTENSION_HITS");
        public static dynamic @EXTENSION_ENERGY_CAPACITY => Script.Write<dynamic>("EXTENSION_ENERGY_CAPACITY");
        public static double @ROAD_HITS => Script.Write<double>("ROAD_HITS");
        public static double @ROAD_WEAROUT => Script.Write<double>("ROAD_WEAROUT");
        public static double @ROAD_WEAROUT_POWER_CREEP => Script.Write<double>("ROAD_WEAROUT_POWER_CREEP");
        public static double @ROAD_DECAY_AMOUNT => Script.Write<double>("ROAD_DECAY_AMOUNT");
        public static double @ROAD_DECAY_TIME => Script.Write<double>("ROAD_DECAY_TIME");
        public static double @LINK_HITS => Script.Write<double>("LINK_HITS");
        public static double @LINK_HITS_MAX => Script.Write<double>("LINK_HITS_MAX");
        public static double @LINK_CAPACITY => Script.Write<double>("LINK_CAPACITY");
        public static double @LINK_COOLDOWN => Script.Write<double>("LINK_COOLDOWN");
        public static double @LINK_LOSS_RATIO => Script.Write<double>("LINK_LOSS_RATIO");
        public static double @STORAGE_CAPACITY => Script.Write<double>("STORAGE_CAPACITY");
        public static double @STORAGE_HITS => Script.Write<double>("STORAGE_HITS");
        public static double @FACTORY_HITS => Script.Write<double>("FACTORY_HITS");
        public static double @FACTORY_CAPACITY => Script.Write<double>("FACTORY_CAPACITY");
        public static dynamic @BODYPART_COST => Script.Write<dynamic>("BODYPART_COST");
        public static string[] @BODYPARTS_ALL => Script.Write<string[]>("BODYPARTS_ALL");
        public static double @CARRY_CAPACITY => Script.Write<double>("CARRY_CAPACITY");
        public static double @HARVEST_POWER => Script.Write<double>("HARVEST_POWER");
        public static double @HARVEST_MINERAL_POWER => Script.Write<double>("HARVEST_MINERAL_POWER");
        public static double @HARVEST_DEPOSIT_POWER => Script.Write<double>("HARVEST_DEPOSIT_POWER");
        public static double @REPAIR_POWER => Script.Write<double>("REPAIR_POWER");
        public static double @DISMANTLE_POWER => Script.Write<double>("DISMANTLE_POWER");
        public static double @BUILD_POWER => Script.Write<double>("BUILD_POWER");
        public static double @ATTACK_POWER => Script.Write<double>("ATTACK_POWER");
        public static double @UPGRADE_CONTROLLER_POWER => Script.Write<double>("UPGRADE_CONTROLLER_POWER");
        public static double @RANGED_ATTACK_POWER => Script.Write<double>("RANGED_ATTACK_POWER");
        public static double @HEAL_POWER => Script.Write<double>("HEAL_POWER");
        public static double @RANGED_HEAL_POWER => Script.Write<double>("RANGED_HEAL_POWER");
        public static double @DISMANTLE_COST => Script.Write<double>("DISMANTLE_COST");
        public static string @MOVE => Script.Write<string>("MOVE");
        public static string @WORK => Script.Write<string>("WORK");
        public static string @CARRY => Script.Write<string>("CARRY");
        public static string @ATTACK => Script.Write<string>("ATTACK");
        public static string @RANGED_ATTACK => Script.Write<string>("RANGED_ATTACK");
        public static string @TOUGH => Script.Write<string>("TOUGH");
        public static string @HEAL => Script.Write<string>("HEAL");
        public static string @CLAIM => Script.Write<string>("CLAIM");
        public static dynamic @CONSTRUCTION_COST => Script.Write<dynamic>("CONSTRUCTION_COST");
        public static double @CONSTRUCTION_COST_ROAD_SWAMP_RATIO => Script.Write<double>("CONSTRUCTION_COST_ROAD_SWAMP_RATIO");
        public static double @CONSTRUCTION_COST_ROAD_WALL_RATIO => Script.Write<double>("CONSTRUCTION_COST_ROAD_WALL_RATIO");
        public static string @STRUCTURE_EXTENSION => Script.Write<string>("STRUCTURE_EXTENSION");
        public static string @STRUCTURE_RAMPART => Script.Write<string>("STRUCTURE_RAMPART");
        public static string @STRUCTURE_ROAD => Script.Write<string>("STRUCTURE_ROAD");
        public static string @STRUCTURE_SPAWN => Script.Write<string>("STRUCTURE_SPAWN");
        public static string @STRUCTURE_LINK => Script.Write<string>("STRUCTURE_LINK");
        public static string @STRUCTURE_WALL => Script.Write<string>("STRUCTURE_WALL");
        public static string @STRUCTURE_KEEPER_LAIR => Script.Write<string>("STRUCTURE_KEEPER_LAIR");
        public static string @STRUCTURE_CONTROLLER => Script.Write<string>("STRUCTURE_CONTROLLER");
        public static string @STRUCTURE_STORAGE => Script.Write<string>("STRUCTURE_STORAGE");
        public static string @STRUCTURE_TOWER => Script.Write<string>("STRUCTURE_TOWER");
        public static string @STRUCTURE_OBSERVER => Script.Write<string>("STRUCTURE_OBSERVER");
        public static string @STRUCTURE_POWER_BANK => Script.Write<string>("STRUCTURE_POWER_BANK");
        public static string @STRUCTURE_POWER_SPAWN => Script.Write<string>("STRUCTURE_POWER_SPAWN");
        public static string @STRUCTURE_EXTRACTOR => Script.Write<string>("STRUCTURE_EXTRACTOR");
        public static string @STRUCTURE_LAB => Script.Write<string>("STRUCTURE_LAB");
        public static string @STRUCTURE_TERMINAL => Script.Write<string>("STRUCTURE_TERMINAL");
        public static string @STRUCTURE_CONTAINER => Script.Write<string>("STRUCTURE_CONTAINER");
        public static string @STRUCTURE_NUKER => Script.Write<string>("STRUCTURE_NUKER");
        public static string @STRUCTURE_FACTORY => Script.Write<string>("STRUCTURE_FACTORY");
        public static string @STRUCTURE_INVADER_CORE => Script.Write<string>("STRUCTURE_INVADER_CORE");
        public static string @STRUCTURE_PORTAL => Script.Write<string>("STRUCTURE_PORTAL");
        public static string @RESOURCE_ENERGY => Script.Write<string>("RESOURCE_ENERGY");
        public static string @RESOURCE_POWER => Script.Write<string>("RESOURCE_POWER");
        public static string @RESOURCE_OPS => Script.Write<string>("RESOURCE_OPS");
        public static string @RESOURCE_UTRIUM => Script.Write<string>("RESOURCE_UTRIUM");
        public static string @RESOURCE_LEMERGIUM => Script.Write<string>("RESOURCE_LEMERGIUM");
        public static string @RESOURCE_KEANIUM => Script.Write<string>("RESOURCE_KEANIUM");
        public static string @RESOURCE_GHODIUM => Script.Write<string>("RESOURCE_GHODIUM");
        public static string @RESOURCE_ZYNTHIUM => Script.Write<string>("RESOURCE_ZYNTHIUM");
        public static string @RESOURCE_OXYGEN => Script.Write<string>("RESOURCE_OXYGEN");
        public static string @RESOURCE_HYDROGEN => Script.Write<string>("RESOURCE_HYDROGEN");
        public static string @RESOURCE_CATALYST => Script.Write<string>("RESOURCE_CATALYST");
        public static string @RESOURCE_HYDROXIDE => Script.Write<string>("RESOURCE_HYDROXIDE");
        public static string @RESOURCE_ZYNTHIUM_KEANITE => Script.Write<string>("RESOURCE_ZYNTHIUM_KEANITE");
        public static string @RESOURCE_UTRIUM_LEMERGITE => Script.Write<string>("RESOURCE_UTRIUM_LEMERGITE");
        public static string @RESOURCE_UTRIUM_HYDRIDE => Script.Write<string>("RESOURCE_UTRIUM_HYDRIDE");
        public static string @RESOURCE_UTRIUM_OXIDE => Script.Write<string>("RESOURCE_UTRIUM_OXIDE");
        public static string @RESOURCE_KEANIUM_HYDRIDE => Script.Write<string>("RESOURCE_KEANIUM_HYDRIDE");
        public static string @RESOURCE_KEANIUM_OXIDE => Script.Write<string>("RESOURCE_KEANIUM_OXIDE");
        public static string @RESOURCE_LEMERGIUM_HYDRIDE => Script.Write<string>("RESOURCE_LEMERGIUM_HYDRIDE");
        public static string @RESOURCE_LEMERGIUM_OXIDE => Script.Write<string>("RESOURCE_LEMERGIUM_OXIDE");
        public static string @RESOURCE_ZYNTHIUM_HYDRIDE => Script.Write<string>("RESOURCE_ZYNTHIUM_HYDRIDE");
        public static string @RESOURCE_ZYNTHIUM_OXIDE => Script.Write<string>("RESOURCE_ZYNTHIUM_OXIDE");
        public static string @RESOURCE_GHODIUM_HYDRIDE => Script.Write<string>("RESOURCE_GHODIUM_HYDRIDE");
        public static string @RESOURCE_GHODIUM_OXIDE => Script.Write<string>("RESOURCE_GHODIUM_OXIDE");
        public static string @RESOURCE_UTRIUM_ACID => Script.Write<string>("RESOURCE_UTRIUM_ACID");
        public static string @RESOURCE_UTRIUM_ALKALIDE => Script.Write<string>("RESOURCE_UTRIUM_ALKALIDE");
        public static string @RESOURCE_KEANIUM_ACID => Script.Write<string>("RESOURCE_KEANIUM_ACID");
        public static string @RESOURCE_KEANIUM_ALKALIDE => Script.Write<string>("RESOURCE_KEANIUM_ALKALIDE");
        public static string @RESOURCE_LEMERGIUM_ACID => Script.Write<string>("RESOURCE_LEMERGIUM_ACID");
        public static string @RESOURCE_LEMERGIUM_ALKALIDE => Script.Write<string>("RESOURCE_LEMERGIUM_ALKALIDE");
        public static string @RESOURCE_ZYNTHIUM_ACID => Script.Write<string>("RESOURCE_ZYNTHIUM_ACID");
        public static string @RESOURCE_ZYNTHIUM_ALKALIDE => Script.Write<string>("RESOURCE_ZYNTHIUM_ALKALIDE");
        public static string @RESOURCE_GHODIUM_ACID => Script.Write<string>("RESOURCE_GHODIUM_ACID");
        public static string @RESOURCE_GHODIUM_ALKALIDE => Script.Write<string>("RESOURCE_GHODIUM_ALKALIDE");
        public static string @RESOURCE_CATALYZED_UTRIUM_ACID => Script.Write<string>("RESOURCE_CATALYZED_UTRIUM_ACID");
        public static string @RESOURCE_CATALYZED_UTRIUM_ALKALIDE => Script.Write<string>("RESOURCE_CATALYZED_UTRIUM_ALKALIDE");
        public static string @RESOURCE_CATALYZED_KEANIUM_ACID => Script.Write<string>("RESOURCE_CATALYZED_KEANIUM_ACID");
        public static string @RESOURCE_CATALYZED_KEANIUM_ALKALIDE => Script.Write<string>("RESOURCE_CATALYZED_KEANIUM_ALKALIDE");
        public static string @RESOURCE_CATALYZED_LEMERGIUM_ACID => Script.Write<string>("RESOURCE_CATALYZED_LEMERGIUM_ACID");
        public static string @RESOURCE_CATALYZED_LEMERGIUM_ALKALIDE => Script.Write<string>("RESOURCE_CATALYZED_LEMERGIUM_ALKALIDE");
        public static string @RESOURCE_CATALYZED_ZYNTHIUM_ACID => Script.Write<string>("RESOURCE_CATALYZED_ZYNTHIUM_ACID");
        public static string @RESOURCE_CATALYZED_ZYNTHIUM_ALKALIDE => Script.Write<string>("RESOURCE_CATALYZED_ZYNTHIUM_ALKALIDE");
        public static string @RESOURCE_CATALYZED_GHODIUM_ACID => Script.Write<string>("RESOURCE_CATALYZED_GHODIUM_ACID");
        public static string @RESOURCE_CATALYZED_GHODIUM_ALKALIDE => Script.Write<string>("RESOURCE_CATALYZED_GHODIUM_ALKALIDE");
        public static string @RESOURCE_BIOMASS => Script.Write<string>("RESOURCE_BIOMASS");
        public static string @RESOURCE_METAL => Script.Write<string>("RESOURCE_METAL");
        public static string @RESOURCE_MIST => Script.Write<string>("RESOURCE_MIST");
        public static string @RESOURCE_SILICON => Script.Write<string>("RESOURCE_SILICON");
        public static string @RESOURCE_UTRIUM_BAR => Script.Write<string>("RESOURCE_UTRIUM_BAR");
        public static string @RESOURCE_LEMERGIUM_BAR => Script.Write<string>("RESOURCE_LEMERGIUM_BAR");
        public static string @RESOURCE_ZYNTHIUM_BAR => Script.Write<string>("RESOURCE_ZYNTHIUM_BAR");
        public static string @RESOURCE_KEANIUM_BAR => Script.Write<string>("RESOURCE_KEANIUM_BAR");
        public static string @RESOURCE_GHODIUM_MELT => Script.Write<string>("RESOURCE_GHODIUM_MELT");
        public static string @RESOURCE_OXIDANT => Script.Write<string>("RESOURCE_OXIDANT");
        public static string @RESOURCE_REDUCTANT => Script.Write<string>("RESOURCE_REDUCTANT");
        public static string @RESOURCE_PURIFIER => Script.Write<string>("RESOURCE_PURIFIER");
        public static string @RESOURCE_BATTERY => Script.Write<string>("RESOURCE_BATTERY");
        public static string @RESOURCE_COMPOSITE => Script.Write<string>("RESOURCE_COMPOSITE");
        public static string @RESOURCE_CRYSTAL => Script.Write<string>("RESOURCE_CRYSTAL");
        public static string @RESOURCE_LIQUID => Script.Write<string>("RESOURCE_LIQUID");
        public static string @RESOURCE_WIRE => Script.Write<string>("RESOURCE_WIRE");
        public static string @RESOURCE_SWITCH => Script.Write<string>("RESOURCE_SWITCH");
        public static string @RESOURCE_TRANSISTOR => Script.Write<string>("RESOURCE_TRANSISTOR");
        public static string @RESOURCE_MICROCHIP => Script.Write<string>("RESOURCE_MICROCHIP");
        public static string @RESOURCE_CIRCUIT => Script.Write<string>("RESOURCE_CIRCUIT");
        public static string @RESOURCE_DEVICE => Script.Write<string>("RESOURCE_DEVICE");
        public static string @RESOURCE_CELL => Script.Write<string>("RESOURCE_CELL");
        public static string @RESOURCE_PHLEGM => Script.Write<string>("RESOURCE_PHLEGM");
        public static string @RESOURCE_TISSUE => Script.Write<string>("RESOURCE_TISSUE");
        public static string @RESOURCE_MUSCLE => Script.Write<string>("RESOURCE_MUSCLE");
        public static string @RESOURCE_ORGANOID => Script.Write<string>("RESOURCE_ORGANOID");
        public static string @RESOURCE_ORGANISM => Script.Write<string>("RESOURCE_ORGANISM");
        public static string @RESOURCE_ALLOY => Script.Write<string>("RESOURCE_ALLOY");
        public static string @RESOURCE_TUBE => Script.Write<string>("RESOURCE_TUBE");
        public static string @RESOURCE_FIXTURES => Script.Write<string>("RESOURCE_FIXTURES");
        public static string @RESOURCE_FRAME => Script.Write<string>("RESOURCE_FRAME");
        public static string @RESOURCE_HYDRAULICS => Script.Write<string>("RESOURCE_HYDRAULICS");
        public static string @RESOURCE_MACHINE => Script.Write<string>("RESOURCE_MACHINE");
        public static string @RESOURCE_CONDENSATE => Script.Write<string>("RESOURCE_CONDENSATE");
        public static string @RESOURCE_CONCENTRATE => Script.Write<string>("RESOURCE_CONCENTRATE");
        public static string @RESOURCE_EXTRACT => Script.Write<string>("RESOURCE_EXTRACT");
        public static string @RESOURCE_SPIRIT => Script.Write<string>("RESOURCE_SPIRIT");
        public static string @RESOURCE_EMANATION => Script.Write<string>("RESOURCE_EMANATION");
        public static string @RESOURCE_ESSENCE => Script.Write<string>("RESOURCE_ESSENCE");
        public static string[] @RESOURCES_ALL => Script.Write<string[]>("RESOURCES_ALL");
        public static string @SUBSCRIPTION_TOKEN => Script.Write<string>("SUBSCRIPTION_TOKEN");
        public static string @CPU_UNLOCK => Script.Write<string>("CPU_UNLOCK");
        public static string @PIXEL => Script.Write<string>("PIXEL");
        public static string @ACCESS_KEY => Script.Write<string>("ACCESS_KEY");
        public static double @PIXEL_CPU_COST => Script.Write<double>("PIXEL_CPU_COST");
        public static NativeMap<double> @CONTROLLER_LEVELS => Script.Write<NativeMap<double>>("CONTROLLER_LEVELS");
        public static dynamic @CONTROLLER_STRUCTURES => Script.Write<dynamic>("CONTROLLER_STRUCTURES");
        public static NativeMap<double> @CONTROLLER_DOWNGRADE => Script.Write<NativeMap<double>>("CONTROLLER_DOWNGRADE");
        public static double @CONTROLLER_DOWNGRADE_RESTORE => Script.Write<double>("CONTROLLER_DOWNGRADE_RESTORE");
        public static double @CONTROLLER_DOWNGRADE_SAFEMODE_THRESHOLD => Script.Write<double>("CONTROLLER_DOWNGRADE_SAFEMODE_THRESHOLD");
        public static double @CONTROLLER_CLAIM_DOWNGRADE => Script.Write<double>("CONTROLLER_CLAIM_DOWNGRADE");
        public static double @CONTROLLER_RESERVE => Script.Write<double>("CONTROLLER_RESERVE");
        public static double @CONTROLLER_RESERVE_MAX => Script.Write<double>("CONTROLLER_RESERVE_MAX");
        public static double @CONTROLLER_MAX_UPGRADE_PER_TICK => Script.Write<double>("CONTROLLER_MAX_UPGRADE_PER_TICK");
        public static double @CONTROLLER_ATTACK_BLOCKED_UPGRADE => Script.Write<double>("CONTROLLER_ATTACK_BLOCKED_UPGRADE");
        public static double @CONTROLLER_NUKE_BLOCKED_UPGRADE => Script.Write<double>("CONTROLLER_NUKE_BLOCKED_UPGRADE");
        public static double @SAFE_MODE_DURATION => Script.Write<double>("SAFE_MODE_DURATION");
        public static double @SAFE_MODE_COOLDOWN => Script.Write<double>("SAFE_MODE_COOLDOWN");
        public static double @SAFE_MODE_COST => Script.Write<double>("SAFE_MODE_COST");
        public static double @TOWER_HITS => Script.Write<double>("TOWER_HITS");
        public static double @TOWER_CAPACITY => Script.Write<double>("TOWER_CAPACITY");
        public static double @TOWER_ENERGY_COST => Script.Write<double>("TOWER_ENERGY_COST");
        public static double @TOWER_POWER_ATTACK => Script.Write<double>("TOWER_POWER_ATTACK");
        public static double @TOWER_POWER_HEAL => Script.Write<double>("TOWER_POWER_HEAL");
        public static double @TOWER_POWER_REPAIR => Script.Write<double>("TOWER_POWER_REPAIR");
        public static double @TOWER_OPTIMAL_RANGE => Script.Write<double>("TOWER_OPTIMAL_RANGE");
        public static double @TOWER_FALLOFF_RANGE => Script.Write<double>("TOWER_FALLOFF_RANGE");
        public static double @TOWER_FALLOFF => Script.Write<double>("TOWER_FALLOFF");
        public static double @OBSERVER_HITS => Script.Write<double>("OBSERVER_HITS");
        public static double @OBSERVER_RANGE => Script.Write<double>("OBSERVER_RANGE");
        public static double @POWER_BANK_HITS => Script.Write<double>("POWER_BANK_HITS");
        public static double @POWER_BANK_CAPACITY_MAX => Script.Write<double>("POWER_BANK_CAPACITY_MAX");
        public static double @POWER_BANK_CAPACITY_MIN => Script.Write<double>("POWER_BANK_CAPACITY_MIN");
        public static double @POWER_BANK_CAPACITY_CRIT => Script.Write<double>("POWER_BANK_CAPACITY_CRIT");
        public static double @POWER_BANK_DECAY => Script.Write<double>("POWER_BANK_DECAY");
        public static double @POWER_BANK_HIT_BACK => Script.Write<double>("POWER_BANK_HIT_BACK");
        public static double @POWER_SPAWN_HITS => Script.Write<double>("POWER_SPAWN_HITS");
        public static double @POWER_SPAWN_ENERGY_CAPACITY => Script.Write<double>("POWER_SPAWN_ENERGY_CAPACITY");
        public static double @POWER_SPAWN_POWER_CAPACITY => Script.Write<double>("POWER_SPAWN_POWER_CAPACITY");
        public static double @POWER_SPAWN_ENERGY_RATIO => Script.Write<double>("POWER_SPAWN_ENERGY_RATIO");
        public static double @EXTRACTOR_HITS => Script.Write<double>("EXTRACTOR_HITS");
        public static double @EXTRACTOR_COOLDOWN => Script.Write<double>("EXTRACTOR_COOLDOWN");
        public static double @LAB_HITS => Script.Write<double>("LAB_HITS");
        public static double @LAB_MINERAL_CAPACITY => Script.Write<double>("LAB_MINERAL_CAPACITY");
        public static double @LAB_ENERGY_CAPACITY => Script.Write<double>("LAB_ENERGY_CAPACITY");
        public static double @LAB_BOOST_ENERGY => Script.Write<double>("LAB_BOOST_ENERGY");
        public static double @LAB_BOOST_MINERAL => Script.Write<double>("LAB_BOOST_MINERAL");
        public static double @LAB_COOLDOWN => Script.Write<double>("LAB_COOLDOWN");
        public static double @LAB_REACTION_AMOUNT => Script.Write<double>("LAB_REACTION_AMOUNT");
        public static double @GCL_POW => Script.Write<double>("GCL_POW");
        public static double @GCL_MULTIPLY => Script.Write<double>("GCL_MULTIPLY");
        public static double @GCL_NOVICE => Script.Write<double>("GCL_NOVICE");
        public static dynamic @MODE_SIMULATION => Script.Write<dynamic>("MODE_SIMULATION");
        public static dynamic @MODE_WORLD => Script.Write<dynamic>("MODE_WORLD");
        public static double @TERRAIN_MASK_WALL => Script.Write<double>("TERRAIN_MASK_WALL");
        public static double @TERRAIN_MASK_SWAMP => Script.Write<double>("TERRAIN_MASK_SWAMP");
        public static double @TERRAIN_MASK_LAVA => Script.Write<double>("TERRAIN_MASK_LAVA");
        public static double @MAX_CONSTRUCTION_SITES => Script.Write<double>("MAX_CONSTRUCTION_SITES");
        public static double @MAX_CREEP_SIZE => Script.Write<double>("MAX_CREEP_SIZE");
        public static double @MINERAL_REGEN_TIME => Script.Write<double>("MINERAL_REGEN_TIME");
        public static dynamic @MINERAL_MIN_AMOUNT => Script.Write<dynamic>("MINERAL_MIN_AMOUNT");
        public static double @MINERAL_RANDOM_FACTOR => Script.Write<double>("MINERAL_RANDOM_FACTOR");
        public static dynamic @MINERAL_DENSITY => Script.Write<dynamic>("MINERAL_DENSITY");
        public static dynamic @MINERAL_DENSITY_PROBABILITY => Script.Write<dynamic>("MINERAL_DENSITY_PROBABILITY");
        public static double @MINERAL_DENSITY_CHANGE => Script.Write<double>("MINERAL_DENSITY_CHANGE");
        public static double @DENSITY_LOW => Script.Write<double>("DENSITY_LOW");
        public static double @DENSITY_MODERATE => Script.Write<double>("DENSITY_MODERATE");
        public static double @DENSITY_HIGH => Script.Write<double>("DENSITY_HIGH");
        public static double @DENSITY_ULTRA => Script.Write<double>("DENSITY_ULTRA");
        public static double @DEPOSIT_EXHAUST_MULTIPLY => Script.Write<double>("DEPOSIT_EXHAUST_MULTIPLY");
        public static double @DEPOSIT_EXHAUST_POW => Script.Write<double>("DEPOSIT_EXHAUST_POW");
        public static double @DEPOSIT_DECAY_TIME => Script.Write<double>("DEPOSIT_DECAY_TIME");
        public static double @TERMINAL_CAPACITY => Script.Write<double>("TERMINAL_CAPACITY");
        public static double @TERMINAL_COOLDOWN => Script.Write<double>("TERMINAL_COOLDOWN");
        public static double @TERMINAL_HITS => Script.Write<double>("TERMINAL_HITS");
        public static double @TERMINAL_SEND_COST => Script.Write<double>("TERMINAL_SEND_COST");
        public static double @TERMINAL_MIN_SEND => Script.Write<double>("TERMINAL_MIN_SEND");
        public static double @CONTAINER_HITS => Script.Write<double>("CONTAINER_HITS");
        public static double @CONTAINER_CAPACITY => Script.Write<double>("CONTAINER_CAPACITY");
        public static double @CONTAINER_DECAY => Script.Write<double>("CONTAINER_DECAY");
        public static double @CONTAINER_DECAY_TIME => Script.Write<double>("CONTAINER_DECAY_TIME");
        public static double @CONTAINER_DECAY_TIME_OWNED => Script.Write<double>("CONTAINER_DECAY_TIME_OWNED");
        public static double @NUKER_HITS => Script.Write<double>("NUKER_HITS");
        public static double @NUKER_COOLDOWN => Script.Write<double>("NUKER_COOLDOWN");
        public static double @NUKER_ENERGY_CAPACITY => Script.Write<double>("NUKER_ENERGY_CAPACITY");
        public static double @NUKER_GHODIUM_CAPACITY => Script.Write<double>("NUKER_GHODIUM_CAPACITY");
        public static double @NUKE_LAND_TIME => Script.Write<double>("NUKE_LAND_TIME");
        public static double @NUKE_RANGE => Script.Write<double>("NUKE_RANGE");
        public static dynamic @NUKE_DAMAGE => Script.Write<dynamic>("NUKE_DAMAGE");
        public static dynamic @REACTIONS => Script.Write<dynamic>("REACTIONS");
        public static dynamic @REACTION_TIME => Script.Write<dynamic>("REACTION_TIME");
        public static dynamic @BOOSTS => Script.Write<dynamic>("BOOSTS");
        public static string[] @INTERSHARD_RESOURCES => Script.Write<string[]>("INTERSHARD_RESOURCES");
        public static dynamic @COMMODITIES => Script.Write<dynamic>("COMMODITIES");
        public static string @LOOK_CREEPS => Script.Write<string>("LOOK_CREEPS");
        public static string @LOOK_ENERGY => Script.Write<string>("LOOK_ENERGY");
        public static string @LOOK_RESOURCES => Script.Write<string>("LOOK_RESOURCES");
        public static string @LOOK_SOURCES => Script.Write<string>("LOOK_SOURCES");
        public static string @LOOK_MINERALS => Script.Write<string>("LOOK_MINERALS");
        public static string @LOOK_DEPOSITS => Script.Write<string>("LOOK_DEPOSITS");
        public static string @LOOK_STRUCTURES => Script.Write<string>("LOOK_STRUCTURES");
        public static string @LOOK_FLAGS => Script.Write<string>("LOOK_FLAGS");
        public static string @LOOK_CONSTRUCTION_SITES => Script.Write<string>("LOOK_CONSTRUCTION_SITES");
        public static string @LOOK_NUKES => Script.Write<string>("LOOK_NUKES");
        public static string @LOOK_TERRAIN => Script.Write<string>("LOOK_TERRAIN");
        public static string @LOOK_TOMBSTONES => Script.Write<string>("LOOK_TOMBSTONES");
        public static string @LOOK_POWER_CREEPS => Script.Write<string>("LOOK_POWER_CREEPS");
        public static string @LOOK_RUINS => Script.Write<string>("LOOK_RUINS");
        public static string @ORDER_SELL => Script.Write<string>("ORDER_SELL");
        public static string @ORDER_BUY => Script.Write<string>("ORDER_BUY");
        public static double @MARKET_FEE => Script.Write<double>("MARKET_FEE");
        public static double @MARKET_MAX_ORDERS => Script.Write<double>("MARKET_MAX_ORDERS");
        public static double @MARKET_ORDER_LIFE_TIME => Script.Write<double>("MARKET_ORDER_LIFE_TIME");
        public static double @INVADERS_ENERGY_GOAL => Script.Write<double>("INVADERS_ENERGY_GOAL");
        public static string @SYSTEM_USERNAME => Script.Write<string>("SYSTEM_USERNAME");
        public static double @TOMBSTONE_DECAY_PER_PART => Script.Write<double>("TOMBSTONE_DECAY_PER_PART");
        public static double @TOMBSTONE_DECAY_POWER_CREEP => Script.Write<double>("TOMBSTONE_DECAY_POWER_CREEP");
        public static double @RUIN_DECAY => Script.Write<double>("RUIN_DECAY");
        public static dynamic @RUIN_DECAY_STRUCTURES => Script.Write<dynamic>("RUIN_DECAY_STRUCTURES");
        public static double @EVENT_ATTACK => Script.Write<double>("EVENT_ATTACK");
        public static double @EVENT_OBJECT_DESTROYED => Script.Write<double>("EVENT_OBJECT_DESTROYED");
        public static double @EVENT_ATTACK_CONTROLLER => Script.Write<double>("EVENT_ATTACK_CONTROLLER");
        public static double @EVENT_BUILD => Script.Write<double>("EVENT_BUILD");
        public static double @EVENT_HARVEST => Script.Write<double>("EVENT_HARVEST");
        public static double @EVENT_HEAL => Script.Write<double>("EVENT_HEAL");
        public static double @EVENT_REPAIR => Script.Write<double>("EVENT_REPAIR");
        public static double @EVENT_RESERVE_CONTROLLER => Script.Write<double>("EVENT_RESERVE_CONTROLLER");
        public static double @EVENT_UPGRADE_CONTROLLER => Script.Write<double>("EVENT_UPGRADE_CONTROLLER");
        public static double @EVENT_EXIT => Script.Write<double>("EVENT_EXIT");
        public static double @EVENT_POWER => Script.Write<double>("EVENT_POWER");
        public static double @EVENT_TRANSFER => Script.Write<double>("EVENT_TRANSFER");
        public static double @EVENT_ATTACK_TYPE_MELEE => Script.Write<double>("EVENT_ATTACK_TYPE_MELEE");
        public static double @EVENT_ATTACK_TYPE_RANGED => Script.Write<double>("EVENT_ATTACK_TYPE_RANGED");
        public static double @EVENT_ATTACK_TYPE_RANGED_MASS => Script.Write<double>("EVENT_ATTACK_TYPE_RANGED_MASS");
        public static double @EVENT_ATTACK_TYPE_DISMANTLE => Script.Write<double>("EVENT_ATTACK_TYPE_DISMANTLE");
        public static double @EVENT_ATTACK_TYPE_HIT_BACK => Script.Write<double>("EVENT_ATTACK_TYPE_HIT_BACK");
        public static double @EVENT_ATTACK_TYPE_NUKE => Script.Write<double>("EVENT_ATTACK_TYPE_NUKE");
        public static double @EVENT_HEAL_TYPE_MELEE => Script.Write<double>("EVENT_HEAL_TYPE_MELEE");
        public static double @EVENT_HEAL_TYPE_RANGED => Script.Write<double>("EVENT_HEAL_TYPE_RANGED");
        public static double @POWER_LEVEL_MULTIPLY => Script.Write<double>("POWER_LEVEL_MULTIPLY");
        public static double @POWER_LEVEL_POW => Script.Write<double>("POWER_LEVEL_POW");
        public static double @POWER_CREEP_SPAWN_COOLDOWN => Script.Write<double>("POWER_CREEP_SPAWN_COOLDOWN");
        public static double @POWER_CREEP_DELETE_COOLDOWN => Script.Write<double>("POWER_CREEP_DELETE_COOLDOWN");
        public static double @POWER_CREEP_MAX_LEVEL => Script.Write<double>("POWER_CREEP_MAX_LEVEL");
        public static double @POWER_CREEP_LIFE_TIME => Script.Write<double>("POWER_CREEP_LIFE_TIME");
        public static dynamic @POWER_CLASS => Script.Write<dynamic>("POWER_CLASS");
        public static double @PWR_GENERATE_OPS => Script.Write<double>("PWR_GENERATE_OPS");
        public static double @PWR_OPERATE_SPAWN => Script.Write<double>("PWR_OPERATE_SPAWN");
        public static double @PWR_OPERATE_TOWER => Script.Write<double>("PWR_OPERATE_TOWER");
        public static double @PWR_OPERATE_STORAGE => Script.Write<double>("PWR_OPERATE_STORAGE");
        public static double @PWR_OPERATE_LAB => Script.Write<double>("PWR_OPERATE_LAB");
        public static double @PWR_OPERATE_EXTENSION => Script.Write<double>("PWR_OPERATE_EXTENSION");
        public static double @PWR_OPERATE_OBSERVER => Script.Write<double>("PWR_OPERATE_OBSERVER");
        public static double @PWR_OPERATE_TERMINAL => Script.Write<double>("PWR_OPERATE_TERMINAL");
        public static double @PWR_DISRUPT_SPAWN => Script.Write<double>("PWR_DISRUPT_SPAWN");
        public static double @PWR_DISRUPT_TOWER => Script.Write<double>("PWR_DISRUPT_TOWER");
        public static double @PWR_DISRUPT_SOURCE => Script.Write<double>("PWR_DISRUPT_SOURCE");
        public static double @PWR_SHIELD => Script.Write<double>("PWR_SHIELD");
        public static double @PWR_REGEN_SOURCE => Script.Write<double>("PWR_REGEN_SOURCE");
        public static double @PWR_REGEN_MINERAL => Script.Write<double>("PWR_REGEN_MINERAL");
        public static double @PWR_DISRUPT_TERMINAL => Script.Write<double>("PWR_DISRUPT_TERMINAL");
        public static double @PWR_OPERATE_POWER => Script.Write<double>("PWR_OPERATE_POWER");
        public static double @PWR_FORTIFY => Script.Write<double>("PWR_FORTIFY");
        public static double @PWR_OPERATE_CONTROLLER => Script.Write<double>("PWR_OPERATE_CONTROLLER");
        public static double @PWR_OPERATE_FACTORY => Script.Write<double>("PWR_OPERATE_FACTORY");
        public static double @EFFECT_INVULNERABILITY => Script.Write<double>("EFFECT_INVULNERABILITY");
        public static double @EFFECT_COLLAPSE_TIMER => Script.Write<double>("EFFECT_COLLAPSE_TIMER");
        public static double @INVADER_CORE_HITS => Script.Write<double>("INVADER_CORE_HITS");
        public static dynamic @INVADER_CORE_CREEP_SPAWN_TIME => Script.Write<dynamic>("INVADER_CORE_CREEP_SPAWN_TIME");
        public static dynamic @INVADER_CORE_EXPAND_TIME => Script.Write<dynamic>("INVADER_CORE_EXPAND_TIME");
        public static double @INVADER_CORE_CONTROLLER_POWER => Script.Write<double>("INVADER_CORE_CONTROLLER_POWER");
        public static double @INVADER_CORE_CONTROLLER_DOWNGRADE => Script.Write<double>("INVADER_CORE_CONTROLLER_DOWNGRADE");
        public static dynamic @STRONGHOLD_RAMPART_HITS => Script.Write<dynamic>("STRONGHOLD_RAMPART_HITS");
        public static double @STRONGHOLD_DECAY_TICKS => Script.Write<double>("STRONGHOLD_DECAY_TICKS");
        public static dynamic @POWER_INFO => Script.Write<dynamic>("POWER_INFO");
        public static ConstructionSiteConstructor @ConstructionSite => Script.Write<ConstructionSiteConstructor>("ConstructionSite");
        public static CreepConstructor @Creep => Script.Write<CreepConstructor>("Creep");
        public static DepositConstructor @Deposit => Script.Write<DepositConstructor>("Deposit");
        public static FlagConstructor @Flag => Script.Write<FlagConstructor>("Flag");
        public static Game @Game => Script.Write<Game>("Game");
        public static InterShardMemory @InterShardMemory => Script.Write<InterShardMemory>("InterShardMemory");
        public static Memory @Memory => Script.Write<Memory>("Memory");
        public static MineralConstructor @Mineral => Script.Write<MineralConstructor>("Mineral");
        public static NukeConstructor @Nuke => Script.Write<NukeConstructor>("Nuke");
        public static PathFinder @PathFinder => Script.Write<PathFinder>("PathFinder");
        public static PowerCreepConstructor @PowerCreep => Script.Write<PowerCreepConstructor>("PowerCreep");
        public static RawMemory @RawMemory => Script.Write<RawMemory>("RawMemory");
        public static ResourceConstructor @Resource => Script.Write<ResourceConstructor>("Resource");
        public static RoomObjectConstructor @RoomObject => Script.Write<RoomObjectConstructor>("RoomObject");
        public static RoomPositionConstructor @RoomPosition => Script.Write<RoomPositionConstructor>("RoomPosition");
        public static RoomConstructor @Room => Script.Write<RoomConstructor>("Room");
        public static RuinConstructor @Ruin => Script.Write<RuinConstructor>("Ruin");
        public static SourceConstructor @Source => Script.Write<SourceConstructor>("Source");
        public static StructureSpawnConstructor @StructureSpawn => Script.Write<StructureSpawnConstructor>("StructureSpawn");
        public static StructureSpawnConstructor @Spawn => Script.Write<StructureSpawnConstructor>("Spawn");
        public static StructureConstructor @Structure => Script.Write<StructureConstructor>("Structure");
        public static OwnedStructureConstructor @OwnedStructure => Script.Write<OwnedStructureConstructor>("OwnedStructure");
        public static StructureControllerConstructor @StructureController => Script.Write<StructureControllerConstructor>("StructureController");
        public static StructureExtensionConstructor @StructureExtension => Script.Write<StructureExtensionConstructor>("StructureExtension");
        public static StructureLinkConstructor @StructureLink => Script.Write<StructureLinkConstructor>("StructureLink");
        public static StructureKeeperLairConstructor @StructureKeeperLair => Script.Write<StructureKeeperLairConstructor>("StructureKeeperLair");
        public static StructureObserverConstructor @StructureObserver => Script.Write<StructureObserverConstructor>("StructureObserver");
        public static StructurePowerBankConstructor @StructurePowerBank => Script.Write<StructurePowerBankConstructor>("StructurePowerBank");
        public static StructurePowerSpawnConstructor @StructurePowerSpawn => Script.Write<StructurePowerSpawnConstructor>("StructurePowerSpawn");
        public static StructureRampartConstructor @StructureRampart => Script.Write<StructureRampartConstructor>("StructureRampart");
        public static StructureRoadConstructor @StructureRoad => Script.Write<StructureRoadConstructor>("StructureRoad");
        public static StructureStorageConstructor @StructureStorage => Script.Write<StructureStorageConstructor>("StructureStorage");
        public static StructureTowerConstructor @StructureTower => Script.Write<StructureTowerConstructor>("StructureTower");
        public static StructureWallConstructor @StructureWall => Script.Write<StructureWallConstructor>("StructureWall");
        public static StructureExtractorConstructor @StructureExtractor => Script.Write<StructureExtractorConstructor>("StructureExtractor");
        public static StructureLabConstructor @StructureLab => Script.Write<StructureLabConstructor>("StructureLab");
        public static StructureTerminalConstructor @StructureTerminal => Script.Write<StructureTerminalConstructor>("StructureTerminal");
        public static StructureContainerConstructor @StructureContainer => Script.Write<StructureContainerConstructor>("StructureContainer");
        public static StructureNukerConstructor @StructureNuker => Script.Write<StructureNukerConstructor>("StructureNuker");
        public static StructurePortalConstructor @StructurePortal => Script.Write<StructurePortalConstructor>("StructurePortal");
        public static StructureFactoryConstructor @StructureFactory => Script.Write<StructureFactoryConstructor>("StructureFactory");
        public static StructureInvaderCoreConstructor @StructureInvaderCore => Script.Write<StructureInvaderCoreConstructor>("StructureInvaderCore");
        public static TombstoneConstructor @Tombstone => Script.Write<TombstoneConstructor>("Tombstone");
    }
}
