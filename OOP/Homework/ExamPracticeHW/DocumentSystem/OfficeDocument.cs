﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class OfficeDocument : EncyptableDocument
    {
        public string Version { get; set; }
    }
}
