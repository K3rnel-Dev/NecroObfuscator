using dnlib.DotNet;
using System;
using static NecroObfuscator.Algorithms.Obufscation.Modules;

namespace NecroObfuscator.Algorithms.Obufscation
{
    internal class Runtimer
    {
        public static void RuntimeExecute(string inputFilePath, string outputFilePath, bool useRenameFuncs, bool useJunkMethods, bool useProxyStrings, bool useControlFlow, bool useWatermark, bool useAntiDe4dot, bool useHideOEP)
        {
            try
            {
                ModuleDefMD module = ModuleDefMD.Load(inputFilePath);

                if (useRenameFuncs)
                {
                    RenameProtector.Execute(module, outputFilePath);
                    Console.WriteLine("RenameProtector applied successfully.");
                }

                if (useJunkMethods)
                {
                    JunkMethods.Execute(module, outputFilePath);
                    Console.WriteLine("JunkMethods applied successfully.");
                }

                if (useProxyStrings)
                {
                    ProxyString.Execute(module, outputFilePath);
                    Console.WriteLine("ProxyString applied successfully.");
                }

                if (useControlFlow)
                {
                    ControlFlow.Execute(module, outputFilePath);
                    Console.WriteLine("ControlFlow applied successfully.");
                }

                if (useWatermark)
                {
                    WaterMark.Execute(module);
                    Console.WriteLine("Watermark applied successfully.");
                }

                if (useAntiDe4dot)
                {
                    AntiDe4dot.Execute(module);
                    Console.WriteLine("AntiDe4dot applied successfully.");
                }
                
                if (useHideOEP)
                {
                    HideOEP.Execute(module, outputFilePath);
                }

                module.Write(outputFilePath);
                Console.WriteLine($"Obfuscation completed successfully. Output saved to {outputFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during obfuscation: {ex.Message}");
            }
        }
    }
}
