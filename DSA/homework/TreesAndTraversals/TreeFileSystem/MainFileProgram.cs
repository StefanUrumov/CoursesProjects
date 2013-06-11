using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TreeFileSystem
{
    class MainFileProgram
    {
        private static List<string> files = new List<string>();

        public static void Main()
        {
            string treeRootPath = @"C:\Program Files";
            string fileExtension = "*.chk";

            TraverseDirectory(treeRootPath, fileExtension);
            
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
                
        }

        public void DFS()
        {
            Stack<Folder<File>> stack = new Stack<Folder<File>>();
            List<File> currentDirFiles = new List<File>();
            List<Folder<File>> currentChildFolders = new List<Folder<File>>();
            Folder<File> direcrory = new Folder<File>("testDir", currentDirFiles, currentChildFolders); 
             
            //this.root
            stack.Push(direcrory.Root);
            
            while (stack.Count > 0)
            {
                Folder<File> currentNode = stack.Pop();
                //Console.Write("{0} ", currentNode.Value);

                for (int i = 0; i < currentNode.ChildFolders.Count; i++)
                {
                    Folder<File> childNode = currentNode.ChildFolders[i];
                    stack.Push(childNode);                    
                }                
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
