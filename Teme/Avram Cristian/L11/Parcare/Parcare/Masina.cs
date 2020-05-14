using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare
{
    public class Masina
    {
        public string Marca { get; set;}
        public string Culoare { get; set;}
        public string Tip { get; set; }
        public string Numar { get; set; }

        public void IntraInParcare()
        {
            Console.WriteLine($"Masina cu numarul {Numar}, tipul {Tip}, culoarea {Culoare}, marca {Marca} intra in parcare.");
        }
        
        public void OcupaLoc(string LiteraRand, int Pozitie, string CuloareArie, string TipLoc)
        {
            Console.WriteLine($"Masina cu numarul {Numar} ocupa parcela {LiteraRand} {Pozitie} {CuloareArie}, de tipul {TipLoc}");            
        }

        public void ElibereazaLoc(string LiteraRand, int Pozitie, string CuloareArie, string TipLoc)
        {
            Console.WriteLine($"Masina cu numarul {Numar} elibereaza parcela {LiteraRand} {Pozitie} {CuloareArie}, de tipul {TipLoc}");
        }

        public void IeseDinParcare()
        {
            Console.WriteLine($"Masina cu numarul {Numar} , tipul {Tip}, culoarea {Culoare}, marca {Marca}  iese din parcare.");
        }

    }
}
