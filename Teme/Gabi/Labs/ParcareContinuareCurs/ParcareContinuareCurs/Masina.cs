using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcareContinuareCurs
{
    public class Masina
    {
        public string Marca { get; set; }
        public string Culoare { get; set; }
        public TipMasina Tip { get; set; }
        public string Numar { get; set; }
        public void IntraInParcare()
        {
            Console.WriteLine($"Masina cu numarul {Numar} intra in parcare");
        }
       public bool OcupaLocParcare(LocParcare loculParcare)
        {
            if (loculParcare.CuloareArie == null) return false;
            else
            {
                loculParcare.OcupatDeMasina = this;
                return true;
            }          
        }
        public bool ElibereazaLocParcare(LocParcare locParcare)
        {
            if(locParcare.OcupatDeMasina != null)
            {
                if(locParcare.OcupatDeMasina.Numar == Numar)
                {
                    locParcare.OcupatDeMasina = null;
                    Console.WriteLine($"Locul de parcare {locParcare.LiteraRand}{locParcare.Pozitie} a fost eliberat de masina cu numarul {Numar}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Masina cu numarul {Numar} nu este parcata pe {locParcare.LiteraRand}{locParcare.Pozitie}");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"Locul de parcare{locParcare.LiteraRand}{locParcare.Pozitie} este deja liber");
                return true;
            }
        }
        public void IeseDinParcare()
        {
            Console.WriteLine($"Masina cu numarul {Numar} iese din parcare");
        }
        //my code ends here
    }
}
