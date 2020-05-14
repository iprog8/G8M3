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
        public string TipLoc { get; set; }

        public bool OcupatDeMasina(string Numar)
        {
            Console.WriteLine($"Parcela {LiteraRand} {Pozitie} {CuloareArie}, de tipul {TipLoc} este ocupata de masina cu numarul {Numar}");
            return false;
        }


    }
}
