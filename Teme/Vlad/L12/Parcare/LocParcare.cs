using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*clasa LocParcare sa aiba urmatoarele proprietati: CuloareArie, LiteraRand, Pozitie, TipLoc(Camion, Autocar, Microbus, Automobil), OcupatDeMasina;*/

namespace Parcare
{
    public class LocParcare
    {
        public string CuloareArie { get; set; }
        public string LiteraRand { get; set; }
        public int Pozitie { get; set; }
        public string TipLoc { get; set; }

        public Masina OcupatDeMasina { get; set; }
    }
}
 