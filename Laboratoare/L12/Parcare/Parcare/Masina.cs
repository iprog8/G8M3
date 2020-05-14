using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare
{
    public class Masina
    {
        public string Marca { get; set; }
        public string Culoare { get; set; }
        public TipMasina Tip { get; set; }
        public string Numar { get; set; }
        //public LocParcare ParcataPe { get; set; }

        public void IntraInParcare()
        {
            Console.WriteLine($"Masina cu numarul {Numar} intra in parcare");
        }

        public bool OcupaLocParcare(LocParcare loculParcare)
        {
            if(loculParcare.OcupatDeMasina == null)
            {
                if (Tip == loculParcare.TipLoc)
                {
                    Console.WriteLine("Poti parca pe acest loc");
                }
                else
                {
                    Console.WriteLine($"Acest loc este de tipul: {loculParcare.TipLoc} iar masina ta este de un tip diferit {Tip}");
                    return false;
                }
                Console.WriteLine($"Locul de parcare {loculParcare.LiteraRand}{loculParcare.Pozitie} este liber");
                loculParcare.OcupatDeMasina = this;
                Console.WriteLine($"Masina {Numar} a fost parcata!");
                return true; //masina s-a parcat
            }
            else
            {
                Console.WriteLine($"Locul de parcare {loculParcare.LiteraRand}{loculParcare.Pozitie} este ocupat");
                Console.WriteLine($"Nu poti parca aici!!!");
                return false; //loc ocupat si nu poti parca
            }
        }
    }
}
