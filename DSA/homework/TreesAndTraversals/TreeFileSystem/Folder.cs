using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFileSystem
{
    public class Folder<File>
    {
        private readonly Folder<File> root;

        public string Name { get; set; }
        public List<File> Files { get; set; }
        public List<Folder<File>> ChildFolders { get; set; }
        public Folder<File> Root { get { return this.root; } }
                

        public Folder(string name, List<File> files, List<Folder<File>> childFolders)            
        {
            this.Name = name;
            this.root = new Folder<File>(name, files, childFolders);
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder<File>>();

            foreach (Folder<File> folder in childFolders)
            {
                this.ChildFolders.Add(folder.root);
            }
        }        
    }
}
