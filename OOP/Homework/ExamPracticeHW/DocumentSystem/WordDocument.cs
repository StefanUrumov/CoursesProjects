using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class WordDocument : OfficeDocument, IEditable
    {
        public ulong NumberOfCharacters { get; set; }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
}
