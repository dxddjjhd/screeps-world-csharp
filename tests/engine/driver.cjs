const vm = require("node:vm");
exports.constants = require("@screeps/common/lib/constants");
exports.pathFinder = {make(){}, search(){throw Error("unexpected native path request");}};
exports.getWorldSize = () => 202;
exports.evalCode = function (module, globals) {
    globals.currentModule = module;
    try {
        return vm.runInContext("(function(module,exports){\n"+module.code+"\n})(currentModule,currentModule.exports)", globals, {filename:module.name,timeout:1500});
    } finally { delete globals.currentModule; }
};
