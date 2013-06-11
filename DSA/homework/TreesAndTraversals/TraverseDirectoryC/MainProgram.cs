
namespace TraverseDirectoryC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MainProgram
    {
        private static List<string> files = new List<string>();

        public static void Main()
        {
            string treeRootPath = @"C:\Program Files";
            string fileExtension = "*.exe";

            TraverseDirectory(treeRootPath, fileExtension);
            
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }

        public static void TraverseDirectory(string currentPath, string fileExtension)
        {
            try
            {
                string[] currentDirectoryFiles = Directory.GetFiles(currentPath, fileExtension);
                files.AddRange(currentDirectoryFiles);

                string[] currentDirectoryDirectories = Directory.GetDirectories(currentPath);

                foreach (var directory in currentDirectoryDirectories)
                {
                    TraverseDirectory(directory, fileExtension);
                }
            }
            catch (UnauthorizedAccessException uae)
            {
                //Console.WriteLine("Access denied -> {0}", uae.Message);
            }            
        }
    }
}
