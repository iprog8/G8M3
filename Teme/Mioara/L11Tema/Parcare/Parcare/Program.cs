using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare
{
    class Program
    {
        static void Main(string[] args)
        {
            LocParcare ioana = new LocParcare();
            ioana.CuloareArie = "verde";
            ioana.LiteraRand = "C";
            ioana.TipLoc = "angajatFirma";
            ioana.Pozitie = 21;

            LocParcare alexandra = new LocParcare();
            alexandra.CuloareArie = "rosu";
            alexandra.LiteraRand = "M";
            alexandra.TipLoc = "client";
            alexandra.Pozitie = 14;

            Masina auto1 = new Masina();
            auto1.Marca = "Hyundai";
            auto1.Numar = "GL-79-TOR";
            auto1.Tip = "Getz";
            auto1.Culoare = "alb";
           
            

            Masina auto2 = new Masina();
            auto2.Marca = "Nissan";
            auto2.Tip = "Micra";
            auto2.Numar = "B-219-COR";
            auto2.Culoare = "negru";


            Masina auto3 = new Masina();
            auto3.Marca = "Range Rover";
            auto3.Tip = "Evoque";
            auto3.Numar = "VS-26-ARM";
            auto3.Culoare = "albastru";

            auto1.IntraInParcare(ioana.CuloareArie);

            Console.WriteLine($"{auto1.Marca} intra in locul de parcare {ioana.CuloareArie}  cu nr {ioana.Pozitie} {ioana.LiteraRand}.");
            Console.ReadKey();

            auto2.IntraInParcare (alexandra.CuloareArie);

            Console.WriteLine($"{auto2.Marca} intra in al doilea loc de parcare {alexandra.CuloareArie} cu nr {alexandra.Pozitie} {alexandra.LiteraRand}.");
            Console.ReadKey();

            auto3.IntraInParcare(ioana.TipLoc);

            auto1.OcupaLoc(ioana.Pozitie);
            auto2.OcupaLoc(alexandra.Pozitie);
            auto3.OcupaLoc(ioana.Pozitie);





        }

    }
}
