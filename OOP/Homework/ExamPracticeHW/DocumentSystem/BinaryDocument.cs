using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class BinaryDocument : Document
    {
        public ulong Size { get; set; }
    }
}
