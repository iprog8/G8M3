using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Masina
    {
        public string Marca { get; set; }
        public string Culoare { get; set; }
        public string Tip { get; set; }
        public string Numar { get; set; }

        public void IntraInParcare()
        {
            Console.WriteLine($"Masina cu numarul {Numar}, marca {Marca}, intra in parcare.");
        }

        public bool OcupaLoc(LocParcare locParcare)
        {
            if(locParcare.OcupatDeMasina == null)
            {
                if(Tip == locParcare.TipLoc)
                {
                    Console.WriteLine("Poti parca aici");
                }
                else
                {
                    Console.WriteLine($"Parcela {locParcare.LiteraRand} {locParcare.Pozitie} este de tipul {locParcare.TipLoc} iar masina ta este de tipul {Tip}.");
                    return false;
                }
                Console.WriteLine($"Parcela {locParcare.LiteraRand} {locParcare.Pozitie} {locParcare.TipLoc} este libera." );
                locParcare.OcupatDeMasina = this;
                Console.WriteLine($"Masina {Marca} cu numarul {Numar} a fost parcata pe parcela {locParcare.LiteraRand} {locParcare.Pozitie} {locParcare.TipLoc}");
                return true;
            }
            else
            {
                Console.WriteLine($"Parcela  {locParcare.LiteraRand} {locParcare.Pozitie} {locParcare.TipLoc} este ocupata.");
                Console.WriteLine("Nu poti parca aici.");
                return false;
            }
        }
        public bool ElibereazaLoc(LocParcare locParcare)
        {
           if( locParcare.OcupatDeMasina != null)
            {
                locParcare.OcupatDeMasina = null;
                Console.WriteLine($"Parcela  {locParcare.LiteraRand} {locParcare.Pozitie} {locParcare.TipLoc} a fost eliberata.");
                return true;
            }
            else
            {
                Console.WriteLine($"Parcela  {locParcare.LiteraRand} {locParcare.Pozitie} {locParcare.TipLoc} este ocupata.");
                return false;
                
            }
        }
    }
}
