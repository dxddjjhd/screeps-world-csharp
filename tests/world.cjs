"use strict";
const assert = require("node:assert/strict");
const fs = require("node:fs");
const vm = require("node:vm");
const path = require("node:path");
const dir = path.resolve(process.argv[2] || path.join(__dirname, "../dist"));
const source = fs.readFileSync(path.join(dir, "main.js"), "utf8");
const constants = {OK:0, ERR_NOT_IN_RANGE:-9, FIND_MY_SPAWNS:112, FIND_MY_STRUCTURES:108,
    FIND_HOSTILE_CREEPS:103, FIND_SOURCES_ACTIVE:104, FIND_MY_CONSTRUCTION_SITES:114,
    RESOURCE_ENERGY:"energy", WORK:"work", CARRY:"carry", MOVE:"move", STRUCTURE_TOWER:"tower",
    STRUCTURE_SPAWN:"spawn", STRUCTURE_EXTENSION:"extension"};
function boot(){
    const ctx = vm.createContext({...constants, console, module:{exports:{}}}, {codeGeneration:{strings:false,wasm:false}});
    vm.runInContext("globalThis.global = globalThis",ctx);
    vm.runInContext(source,ctx,{filename:"main.js",timeout:1500});
    assert.equal(typeof ctx.module.exports.loop,"function");
    return ctx;
}
let world = boot();
const calls = [];
const sourceTarget = {id:"S"}, construction = {id:"C"};
let energy = 0, free = 0, hostiles = [], site = null;
const room = { name:"W1N1", controller:{my:true}, energyAvailable:200,
    find(k){return ({112:[spawn],108:[spawn,tower],103:hostiles})[k] || []; } };
const spawn = { name:"Home", room, structureType:"spawn", spawning:null,
    store:{getFreeCapacity(){return free;}},
    spawnCreep(body,name,opts){
        assert.deepEqual(Array.from(body),["work","carry","move"]);
        assert.equal(opts.memory.role,"wk-worker"); assert.equal(opts.memory.home, room.name);
        calls.push("spawn"); return 0;
    }};
const tower = {structureType:"tower", store:{getFreeCapacity(){return 0;}}, attack(e){assert.equal(e,hostiles[0]);calls.push("attack");}};
let memory = {role:"wk-worker",home:room.name};
function creep(){return {
    memory, room, spawning:false, store:{getUsedCapacity(){return energy;},getFreeCapacity(){return 50-energy;}},
    pos:{findClosestByPath(k){return k===104 ? sourceTarget : site;}},
    harvest(s){assert.equal(s,sourceTarget);calls.push("harvest");return -9;},
    moveTo(){calls.push("move");}, transfer(s){assert.equal(s,spawn);calls.push("transfer");return 0;},
    build(s){assert.equal(s,construction);calls.push("build");return 0;},
    upgradeController(c){assert.equal(c,room.controller);calls.push("upgrade");return 0;}
};}
let time=0;
function tick(creeps,rooms,expected){
    world.Game = {creeps,rooms,time:++time};
    calls.length = 0; vm.runInContext("module.exports.loop()",world,{timeout:500});
    assert.deepEqual(calls,expected);
}
tick({}, {}, []);
tick({other:{memory:{role:"scout"}}},{home:room},["spawn"]);
spawn.spawning={}; tick({one:creep()},{home:room},["harvest","move"]);
energy=50;free=50;tick({one:creep()},{home:room},["transfer"]);assert.equal(memory.working,true);
world=boot();memory=JSON.parse(JSON.stringify(memory));energy=12;free=0;site=construction;
tick({one:creep()},{home:room},["build"]);
site=null;hostiles=[{}];tick({one:creep()},{home:room},["upgrade","attack"]);
energy=0;tick({one:creep()},{home:room},["harvest","move","attack"]);
console.log("World module passed spawning, harvesting, hauling, building, upgrading, defense and global reset.");
