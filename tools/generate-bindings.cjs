// Regenerate from an explicit TypeScript compiler and typed-screeps declaration file.
const fs = require("node:fs");
const path = require("node:path");
const ts = require(process.argv[2]);
const source = ts.createSourceFile("world.d.ts", fs.readFileSync(process.argv[3], "utf8"), ts.ScriptTarget.Latest, true);
const types = new Map();
const aliases = new Map();
const globals = new Map();
for (const node of source.statements) {
    if (ts.isInterfaceDeclaration(node) || ts.isClassDeclaration(node)) types.set(node.name.text, node);
    if (ts.isTypeAliasDeclaration(node)) aliases.set(node.name.text, node.type);
    if (ts.isVariableStatement(node)) {
        for (const item of node.declarationList.declarations) globals.set(item.name.text, item.type);
    }
}
const primitive = {number: "double", string: "string", boolean: "bool", void: "void", undefined: "dynamic"};
const builtins = {Id: "string", Store: "GenericStoreBase", GenericStore: "GenericStoreBase"};
function common(values) {
    return values.every(v => v === values[0]) ? values[0] : "dynamic";
}
function cs(node, depth = 0) {
    if (!node || depth > 8) return "dynamic";
    const s = node.getText(source);
    if (Object.hasOwn(primitive, s)) return primitive[s];
    if (ts.isLiteralTypeNode(node)) {
        if (ts.isStringLiteral(node.literal)) return "string";
        if (/^-?\d/.test(s)) return "double";
        if (s === "true" || s === "false") return "bool";
    }
    if (ts.isArrayTypeNode(node)) return cs(node.elementType, depth + 1) + "[]";
    if (ts.isParenthesizedTypeNode(node)) return cs(node.type, depth + 1);
    if (ts.isUnionTypeNode(node)) {
        const valid = node.types.filter(t => !["undefined","null"].includes(t.getText(source)));
        const result = common(valid.map(t => cs(t, depth + 1))) || "dynamic";
        return valid.length !== node.types.length && ["bool","double"].includes(result) ? result+"?" : result;
    }
    if (ts.isTypeReferenceNode(node)) {
        const id = node.typeName.getText(source);
        if (Object.hasOwn(builtins, id)) return builtins[id];
        if (types.has(id)) return id;
        if (id === "Array" || id === "ReadonlyArray") return cs(node.typeArguments?.[0], depth+1) + "[]";
        if (aliases.has(id)) return cs(aliases.get(id), depth+1);
    }
    if (ts.isTypeLiteralNode(node) && node.members.length === 1 && ts.isIndexSignatureDeclaration(node.members[0]))
        return "NativeMap<" + cs(node.members[0].type,depth+1) + ">";
    return "dynamic";
}
const lines = ["// Generated from @types/screeps 3.4.0. See licenses/typed-screeps.txt.",
    "#pragma warning disable 0108, 0626, 0824", "using Transpose;", "namespace WorldKit", "{"];
let count = 0;
for (const [name, node] of types) {
    const base = node.heritageClauses?.[0]?.types[0]?.expression?.getText(source);
    lines.push("    [External]", "    public class "+name+(types.has(base) ? " : "+base : ""), "    {");
    lines.push("        protected "+name+"() {}");
    const constructors = new Map();
    const isById = node.heritageClauses?.some(clause => clause.types.some(t => t.expression.getText(source) === "_ConstructorById"));
    if (isById && types.has(name.replace(/Constructor$/, ""))) {
        constructors.set(1, {type:name.replace(/Constructor$/, ""), args:["string id"]});
    }
    let hasIndex = false;
    const calls = new Map();
    const seen = new Set();
    for (const m of node.members) {
        if (ts.isConstructSignatureDeclaration(m)) {
            const min = m.parameters.filter(p => !p.questionToken).length;
            for (let n = min; n <= m.parameters.length; n++) {
                constructors.set(n, {type:cs(m.type), args:m.parameters.slice(0,n).map(p=>cs(p.type)+" @"+p.name.getText(source))});
            }
            continue;
        }
        if (ts.isIndexSignatureDeclaration(m) && !hasIndex) {
            const keyType = cs(m.parameters[0].type);
            if (["string","double"].includes(keyType)) {
                lines.push("        public extern "+cs(m.type)+" this["+keyType+" key] { get; set; }");
                hasIndex = true;
                count++;
            }
            continue;
        }
        const key = m.name?.getText(source);
        if (!key || !/^[a-zA-Z_]\w*$/.test(key) || key === name) continue;
        if (ts.isPropertySignature(m) || ts.isPropertyDeclaration(m)) {
            if (seen.has(key)) continue;
            seen.add(key);
            const readonly = m.modifiers?.some(mod => mod.kind === ts.SyntaxKind.ReadonlyKeyword);
            let typ = cs(m.type);
            if (m.questionToken && ["double","bool"].includes(typ)) typ += "?";
            lines.push('        [Name("'+key+'")] public '+typ+" @"+key+" { get;"+(readonly ? "" : " set;")+" }");
            count++;
        } else if (ts.isMethodSignature(m) || ts.isMethodDeclaration(m)) {
            const params = m.parameters.filter(p => p.name.getText(source) !== "this");
            const min = params.filter(p => !p.questionToken && !p.dotDotDotToken && !p.initializer).length;
            for(let n=min;n<=params.length;n++){
                const sig = key+"/"+n;
                if(!calls.has(sig)) calls.set(sig, []);
                calls.get(sig).push({params:params.slice(0,n), result:cs(m.type)});
            }
        }
    }
    if (!hasIndex && (name.endsWith("Memory") || name === "GenericStoreBase")) {
        const typ = name === "GenericStoreBase" ? "double" : "dynamic";
        lines.push("        public extern "+typ+" this[string key] { get; set; }");
        count++;
    }
    for(const [arity, ctor] of constructors) {
        const slots = Array.from({length:arity}, (_,i)=>"{"+i+"}").join(", ");
        lines.push('        [Template("new ({this})('+slots+')")] public extern '+ctor.type+' New('+ctor.args.join(", ")+');');
        count++;
    }
    for(const [sig, overloads] of calls){
        const [key] = sig.split("/");
        const args = overloads[0].params.map((p,i)=>{
            const t = common(overloads.map(o=>cs(o.params[i].type)));
            // object accepts native callbacks, argument unions and C# null.
            return (t === "dynamic" ? "object" : t)+" @"+p.name.getText(source);
        });
        lines.push('        [Name("'+key+'")] public extern '+common(overloads.map(o=>o.result))+" @"+key+"("+args.join(", ")+");");
        count++;
    }
    lines.push("    }");
}
lines.push("    public static partial class World", "    {");
for(const [name,node] of globals) {
    lines.push("        public static "+cs(node)+" @"+name+' => Script.Write<'+cs(node)+'>("'+name+'");');
}
lines.push("    }", "}");
fs.writeFileSync(path.join(__dirname,"../Bot/World.generated.cs"),lines.join("\n")+"\n");
console.log(types.size+" declarations, "+globals.size+" globals, "+count+" member signatures");
