const fs = require("node:fs"), vm = require("node:vm"), assert = require("node:assert/strict");
const calls = [];
const lab = {runReaction(a,b){assert.equal(a,lab);assert.equal(b,lab); calls.push("lab");}};
class RoomPosition {constructor(x,y,room){Object.assign(this,{x,y,room});}}
const objects = {lab, factory:{produce(r){assert.equal(r,"wire");calls.push("factory");}},
    terminal:{send(r,n,d){assert.deepEqual([r,n,d],["energy",100,"W2N1"]);calls.push("terminal");}}};
const world = {module:{exports:{}}, RoomPosition, Memory:{},
    PathFinder:{CostMatrix: class {set(x,y,v){assert.deepEqual([x,y,v],[20,21,4]);calls.push("cost");}},
        search(a,b){assert.equal(a,b);assert.ok(a instanceof RoomPosition);calls.push("path");return {ops:2};}},
    Game:{getObjectById(id){return objects[id];},powerCreeps:{operator:{usePower(n){assert.equal(n,1);calls.push("power");}}},
        map:{getRoomLinearDistance(){return 1;}},market:{calcTransactionCost(n,a,b){assert.deepEqual([n,a,b],[100,"W1N1","W2N1"]);return 5;}}},
    InterShardMemory:{setLocal(s){assert.equal(s,"hello");calls.push("shard");}},
    RawMemory:{setActiveSegments(ids){assert.deepEqual(Array.from(ids),[2,3]);calls.push("segments");}},
    SeasonExtension:{base:3,custom(s){assert.equal(s,"W1N1");return this.base;}}};
vm.createContext(world,{codeGeneration:{strings:false,wasm:false}});
vm.runInContext(fs.readFileSync(process.argv[2],"utf8"),world,{timeout:1500});
vm.runInContext("module.exports.loop()",world,{timeout:500});
assert.equal(world.Memory.answer,27);
assert.deepEqual(calls,["cost","path","lab","factory","terminal","power","segments","shard"]);
console.log("C# language and World API probes passed.");
