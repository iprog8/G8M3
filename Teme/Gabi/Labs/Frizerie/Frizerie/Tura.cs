﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frizerie
{
    public class Tura
    {
        public Tura()
        {
            TimpTura = 480;
        }
        public uint TimpTura { get; set; } //in minute
        public List<Frizer> Frizeri { get; set; }
    }
}
