using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Parcare
{
    class Masina
    {
        public string Marca { get; set; }
        public string Culoare { get; set; }
        public string Tip { get; set; }
        public string Numar { get; set; }
        public void IntraInParcare(string Numar)
        {
            Console.WriteLine($"Masina care are numarul {Numar} a intrat in parcare");
        }
        public void IeseDinParcare(string Numar)
        {
            Console.WriteLine($"Masina care are numarul {Numar} a iesit din parcare");
        }
        public bool OcupaLoc(string NumarMasina, string TipulMasinii, string TipulLocului, bool LocOcupat, string Rand)
        {
            if((TipulMasinii == TipulLocului) && (LocOcupat == false))
            {
                Console.WriteLine($"Masina cu numarul {NumarMasina} a ocupat locul dupa randul {Rand}");
                LocOcupat = true;
                return LocOcupat;
            }
            else
            {
                Console.WriteLine($"Masina cu numarul {NumarMasina} nu poate ocupa locul deoarece cineva deja a ocupat locul {Rand}");
                return LocOcupat;
            }
        }
        public bool ElibereazaLoc(string NumarMasina,bool LocOcupat, string Rand)
        {
        if(LocOcupat == true)
            {
                Console.WriteLine($"Masina cu numarul {NumarMasina} a eliberat locul dupa randul {Rand}");
                LocOcupat = false;
                return LocOcupat ;
            }
            return LocOcupat;
        }
    }
}
