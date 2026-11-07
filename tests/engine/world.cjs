const assert = require("node:assert/strict"), fs = require("node:fs"), vm = require("node:vm");
process.env.DRIVER_MODULE = require.resolve("./driver.cjs");
const engine = require("@screeps/engine/dist/game/game");
const globals = vm.createContext({},{codeGeneration:{strings:false,wasm:false}});
vm.runInContext("globalThis.global=globalThis",globals);
const room = "W1N1", user="u1", spawnId="000000000000000000000001", ctrlId="000000000000000000000002";
const spawn = {_id:spawnId,type:"spawn",room,user,x:20,y:20,name:"Home",store:{energy:300},storeCapacityResource:{energy:300},hits:5000,hitsMax:5000};
const ctrl = {_id:ctrlId,type:"controller",room,user,x:22,y:20,level:3};
const objects = {[spawnId]:spawn,[ctrlId]:ctrl};
const snapshot={user:{_id:user,cpu:20},userCodeTimestamp:1,time:1,cpu:500,
    rooms:{[room]:{_id:room}},roomObjects:objects,userObjects:{...objects},
    staticTerrainData:{[room]:new Uint8Array(2500)},roomEventLog:{},users:{[user]:{username:"Tester"}},flags:[],accessibleRooms:JSON.stringify([room]),
    market:{orders:{all:{}},history:{},myOrders:[]},mapGrid:{gridData:{}}};
let memory="{}";
const intents = [];
const main=fs.readFileSync(process.argv[2],"utf8");
function tick(){
    const raw={get:()=>memory};
    engine.init(globals,{main},snapshot,{set(...args){intents.push(args);}},raw,console,[],1500,()=>0);
    engine.run(user);
    memory=JSON.stringify(globals.Memory);
    snapshot.time++;
}
tick();
assert.equal(intents.length,1);assert.equal(intents[0][1],"createCreep");
const name=intents[0][2].name;
assert.equal(JSON.parse(memory).creeps[name].role,"wk-worker");
const workerId="000000000000000000000003";
const creep={_id:workerId, type:"creep",room,user,name,x:21,y:20,spawning:false,hits:300,hitsMax:300,
    body:["work","carry","move"].map(type=>({type,hits:100})),store:{energy:50},storeCapacity:50};
snapshot.roomObjects[workerId]=snapshot.userObjects[workerId]=creep;
spawn.store.energy=0;
tick();
assert.ok(intents.some(([id,type,params])=>id===workerId && type==="transfer" && params.id===spawnId));
console.log("Official engine accepted spawn and transfer intents across two ticks.");
spawn.store.energy = 300;
const siteId = "000000000000000000000004";
objects[siteId] = {_id:siteId, type:"constructionSite", structureType:"road",room,user,x:21,y:20,progress:0,progressTotal:300};
snapshot.userObjects[siteId]=objects[siteId];
intents.length=0;tick();
assert.ok(intents.some(([id,type,params])=>id===workerId && type==="build" && params.id===siteId));
delete objects[siteId];delete snapshot.userObjects[siteId];
const towerId="000000000000000000000005", enemyId="000000000000000000000006";
objects[towerId]={_id:towerId,type:"tower",room,user,x:23,y:23,store:{energy:1000},storeCapacityResource:{energy:1000}};
snapshot.userObjects[towerId]=objects[towerId];
objects[enemyId]={...creep,_id:enemyId,user:"enemy",name:"Invader",x:24,y:24};
snapshot.users.enemy={username:"Enemy"};
intents.length=0;tick();
assert.ok(intents.some(([id,type,p])=>id===workerId && type==="upgradeController" && p.id===ctrlId));
assert.ok(intents.some(([id,type,p])=>id===towerId && type==="attack" && p.id===enemyId));
console.log("Official engine also accepted building, upgrading and tower defense intents.");
