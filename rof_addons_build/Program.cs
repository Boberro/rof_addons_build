using System;
using System.IO;
using SwiftPbo;

namespace rof_addons_build
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // ReSharper disable line StringLiteralTypo
            const string outFolder = "@rof_addons\\addons";

            foreach (var directoryPath in Directory.GetDirectories(Directory.GetCurrentDirectory()))
            {
                var directory = Path.GetFileName(directoryPath);
                if (directory is null || directory.StartsWith(".") || directory.StartsWith("@")) continue;
                Console.WriteLine(directory);
                var outPath = Path.Combine(Directory.GetCurrentDirectory(), outFolder, directory + ".pbo");
                PboArchive.Create(directoryPath, outPath);
            }
            Console.WriteLine("Done.");
        }
    }
}