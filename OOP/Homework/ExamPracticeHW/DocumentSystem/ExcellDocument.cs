using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class ExcelDocument : OfficeDocument
    {
        public uint NumberOfRows { get; set; }
        public uint NumberOfColumns { get; set; }
    }
}
