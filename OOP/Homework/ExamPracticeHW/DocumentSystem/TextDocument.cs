using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class TextDocument : Document, IEditable
    {
        public string Charset { get; set; }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
}
