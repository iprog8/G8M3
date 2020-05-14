using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare
{
    public class LocParcare
    {
        public string CuloareArie { get; set; }
        public string LiteraRand { get; set; }
        public int Pozitie { get; set; }
        public TipMasina TipLoc { get; set; } //camion, autocar, microbus, autoturism
        public Masina OcupatDeMasina { get; set; }

    }
}
