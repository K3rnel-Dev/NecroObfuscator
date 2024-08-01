using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;


namespace NecroObfuscator.Algorithms.Obufscation
{
    internal class Modules
    {
        #region Helper
        public static class RandomUtils
        {
            private static Random random = new Random();

            public static string RandomString(int length)
            {
                const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                return new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }
        } // Random Utils Module
        #endregion
        #region Rename Functions
        public class RenameProtector
        {
            public static int count_xxx = 0;

            public static void Execute(ModuleDef module, string outPath)
            {
                try
                {
                    module.Name = RandomUtils.RandomString(7);

                    foreach (var type in module.Types)
                    {
                        if (type.IsGlobalModuleType || type.IsRuntimeSpecialName || type.IsSpecialName || type.IsWindowsRuntime || type.IsInterface)
                            continue;

                        count_xxx++;
                        type.Name = RandomUtils.RandomString(40);
                        type.Namespace = "";

                        foreach (var property in type.Properties)
                        {
                            count_xxx++;
                            property.Name = RandomUtils.RandomString(40);
                        }

                        foreach (var field in type.Fields)
                        {
                            count_xxx++;
                            field.Name = RandomUtils.RandomString(40);
                        }

                        foreach (var eventDef in type.Events)
                        {
                            count_xxx++;
                            eventDef.Name = RandomUtils.RandomString(40);
                        }

                        foreach (var method in type.Methods)
                        {
                            if (method.IsConstructor) continue;
                            count_xxx++;
                            method.Name = RandomUtils.RandomString(40);
                        }
                    }

                    // Write the modified module to the specified output path
                    module.Write(outPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred during renaming: {ex.Message}");
                }
            }
        } // RenameFuncs Module
        #endregion
        #region Proxy String
        public class ProxyString
        {
            public static void Execute(ModuleDef module, string outPath)
            {
                try
                {
                    foreach (var type in module.GetTypes())
                    {
                        if (type.IsGlobalModuleType) continue;

                        foreach (var meth in type.Methods)
                        {
                            if (!meth.HasBody) continue;

                            var instr = meth.Body.Instructions;
                            var newInstructions = new List<Instruction>();

                            foreach (var t in instr)
                            {
                                if (t.OpCode == OpCodes.Ldstr)
                                {
                                    var methImplFlags = MethodImplAttributes.IL | MethodImplAttributes.Managed;
                                    var methFlags = MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig | MethodAttributes.ReuseSlot;
                                    var meth1 = new MethodDefUser(RandomUtils.RandomString(10),
                                        MethodSig.CreateStatic(module.CorLibTypes.String),
                                        methImplFlags, methFlags);

                                    module.GlobalType.Methods.Add(meth1);

                                    meth1.Body = new CilBody();
                                    meth1.Body.Variables.Add(new Local(module.CorLibTypes.String));
                                    meth1.Body.Instructions.Add(Instruction.Create(OpCodes.Ldstr, t.Operand.ToString()));
                                    meth1.Body.Instructions.Add(Instruction.Create(OpCodes.Ret));

                                    t.OpCode = OpCodes.Call;
                                    t.Operand = meth1;
                                }
                                newInstructions.Add(t);
                            }

                            meth.Body.Instructions.Clear();
                            foreach (var instruction in newInstructions)
                            {
                                meth.Body.Instructions.Add(instruction);
                            }

                            meth.Body.UpdateInstructionOffsets();
                            meth.Body.SimplifyBranches();
                        }
                    }
                    module.Write(outPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred during string proxying: {ex.Message}");
                }
            }
        } // ProxyString Module
        #endregion
        #region Control Flow
        public class ControlFlow
        {
            public static void Execute(ModuleDef module, string outPath)
            {
                try
                {
                    foreach (var type in module.Types)
                    {
                        foreach (var method in type.Methods)
                        {
                            if (!method.HasBody || method.Body.Instructions.Count == 0) continue;

                            var instructions = method.Body.Instructions;
                            var local = new Local(method.Module.CorLibTypes.Int32);
                            method.Body.Variables.Add(local);

                            var firstInstruction = instructions[0];

                            instructions.Insert(0, Instruction.Create(OpCodes.Ldc_I4, 0));
                            instructions.Insert(1, Instruction.Create(OpCodes.Stloc, local));

                            var newInstructions = new List<Instruction>
                    {
                        Instruction.Create(OpCodes.Ldloc, local),
                        Instruction.Create(OpCodes.Ldc_I4, 1),
                        Instruction.Create(OpCodes.Bne_Un, firstInstruction),
                    };
                            for (int i = 0; i < newInstructions.Count; i++)
                            {
                                instructions.Insert(2 + i, newInstructions[i]);
                            }
                        }
                    }

                    module.Write(outPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred during control flow obfuscation: {ex.Message}");
                }
            }
        } // Control-Flow Module
        #endregion
        #region Junk Methods
        public class JunkMethods
        {
            public static void Execute(ModuleDef module, string OutPath)
            {
                try
                {
                    foreach (var type in module.Types)
                    {
                        for (int i = 0; i < 250; i++) // Create 100 junk methods for each type
                        {
                            var junkMethod = new MethodDefUser(RandomUtils.RandomString(10), MethodSig.CreateStatic(module.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static)
                            {
                                Body = new CilBody()
                            };
                            junkMethod.Body.Instructions.Add(OpCodes.Ret.ToInstruction());

                            type.Methods.Add(junkMethod);
                        }
                    }

                    for (int i = 0; i < 50; i++) // Create 50 junk classes
                    {
                        var junkType = new TypeDefUser(RandomUtils.RandomString(10), module.CorLibTypes.Object.TypeDefOrRef);
                        module.Types.Add(junkType);

                        for (int j = 0; j < 10; j++) // For each junk class, create 10 junk methods
                        {
                            var junkMethod = new MethodDefUser(RandomUtils.RandomString(10), MethodSig.CreateStatic(module.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static)
                            {
                                Body = new CilBody()
                            };
                            junkMethod.Body.Instructions.Add(OpCodes.Ret.ToInstruction());

                            junkType.Methods.Add(junkMethod);
                        }
                    }
                    module.Write(OutPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred during junk method insertion: {ex.Message}");
                }
            }
        } // JunkMethods Module
        #endregion
        #region WaterMark
        public class WaterMark
        {
            public static void Execute(ModuleDefMD md)
            {
                foreach (var moduleDef in md.Assembly.Modules)
                {
                    var module = (ModuleDefMD)moduleDef;
                    var attrRef = module.CorLibTypes.GetTypeRef("System", "Attribute");
                    var attrType = new TypeDefUser("", "N.E.C.R.O.-.O.B.F.U.S.C.A.T.E", attrRef);
                    module.Types.Add(attrType);

                    var ctor = new MethodDefUser(
                        ".ctor",
                        MethodSig.CreateInstance(module.CorLibTypes.Void, module.CorLibTypes.String),
                        MethodImplAttributes.Managed,
                        MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName)
                    {
                        Body = new CilBody()
                    };
                    ctor.Body.MaxStack = 1;
                    ctor.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
                    ctor.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(module, ".ctor", MethodSig.CreateInstance(module.CorLibTypes.Void), attrRef)));
                    ctor.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
                    attrType.Methods.Add(ctor);
                }
            }
        } // WaterMark Module
        #endregion
        #region AntiDe4Dot
        public class AntiDe4dot
        {
            public static void Execute(ModuleDefMD md)
            {
                foreach (var moduleDef in md.Assembly.Modules)
                {
                    var interfaceM = new InterfaceImplUser(md.GlobalType);
                    for (var i = 0; i < 1; i++)
                    {
                        var typeDef1 = new TypeDefUser(string.Empty, $"Form{i}", md.CorLibTypes.GetTypeRef("System", "Attribute"));
                        var interface1 = new InterfaceImplUser(typeDef1);
                        md.Types.Add(typeDef1);
                        typeDef1.Interfaces.Add(interface1);
                        typeDef1.Interfaces.Add(interfaceM);
                    }
                }
            }
        } // AntiDe4Dot Module
        #endregion
        #region HideOEP
        public class HideOEP
        {
            public static void Execute(ModuleDef module, string outPath)
            {
                try
                {
                    var originalEntryPoint = module.EntryPoint;

                    if (originalEntryPoint == null)
                    {
                        Console.WriteLine("No entry point found.");
                        return;
                    }

                    var originalMethod = module.Types.SelectMany(t => t.Methods)
                                                     .FirstOrDefault(m => m.MDToken == originalEntryPoint.MDToken);

                    if (originalMethod == null)
                    {
                        Console.WriteLine("Original entry point method not found.");
                        return;
                    }

                    if (originalMethod.IsPrivate)
                    {
                        originalMethod.Attributes &= ~MethodAttributes.Private; // Удаление модификатора Private
                        originalMethod.Attributes |= MethodAttributes.Public;    // Добавление модификатора Public
                    }

                    var falseEntryPoints = new List<MethodDef>();
                    for (int i = 0; i < 4; i++) // Создаем 4 ложные точки входа
                    {
                        var falseEntryPoint = CreateFalseEntryPoint(module, originalMethod);
                        falseEntryPoints.Add(falseEntryPoint);
                        module.GlobalType.Methods.Add(falseEntryPoint);
                    }

                    // Цепочка вызовов ложных OEP, последний вызывает настоящий OEP
                    for (int i = 0; i < falseEntryPoints.Count - 1; i++)
                    {
                        InsertCallToNextOEP(falseEntryPoints[i], falseEntryPoints[i + 1]);
                    }

                    // В последней ложной точке входа вызываем реальную точку входа
                    InsertCallToNextOEP(falseEntryPoints[falseEntryPoints.Count - 1], originalMethod);

                    // Установка первой ложной точки входа как OEP программы
                    module.EntryPoint = falseEntryPoints[0];

                    module.Write(outPath);
                    Console.WriteLine("Multiple OEP with chaining successfully created and hidden.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred during OEP hiding: {ex.Message}");
                }
            }

            private static MethodDef CreateFalseEntryPoint(ModuleDef module, MethodDef realEntryPoint)
            {
                var falseEntryPoint = new MethodDefUser(
                    RandomUtils.RandomString(10),
                    MethodSig.CreateStatic(module.CorLibTypes.Void),
                    MethodImplAttributes.IL | MethodImplAttributes.Managed,
                    MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.HideBySig | MethodAttributes.ReuseSlot);

                falseEntryPoint.Body = new CilBody();
                falseEntryPoint.Body.Instructions.Add(Instruction.Create(OpCodes.Nop)); // Простая инструкция для ложного OEP
                                                                                        // Следующий вызов OEP (реальной или ложной) будет добавлен позже
                falseEntryPoint.Body.Instructions.Add(Instruction.Create(OpCodes.Ret));

                return falseEntryPoint;
            }

            private static void InsertCallToNextOEP(MethodDef currentOEP, MethodDef nextOEP)
            {
                var instrList = currentOEP.Body.Instructions;
                // Удаление инструкции "ret" и вставка вызова следующего OEP
                instrList.RemoveAt(instrList.Count - 1);
                instrList.Add(Instruction.Create(OpCodes.Call, nextOEP));
                instrList.Add(Instruction.Create(OpCodes.Ret));
            }
        } // Hide OEP-Module
        #endregion
    }
}
