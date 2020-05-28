using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {


            LocParcare parcela1 = new LocParcare();
            parcela1.CuloareArie = "Rosu";
            parcela1.TipLoc = "autoturism";
            parcela1.Pozitie = 1;
            parcela1.LiteraRand = "A";

            LocParcare parcela2 = new LocParcare();
            parcela2.CuloareArie = "Albastru";
            parcela2.TipLoc = "autoturism";
            parcela2.Pozitie = 2;
            parcela2.LiteraRand = "B";

            LocParcare parcela3 = new LocParcare();
            parcela3.CuloareArie = "Galben";
            parcela3.TipLoc = "camion";
            parcela3.Pozitie = 3;
            parcela3.LiteraRand = "C";

            Masina focus = new Masina();
            focus.Culoare = "Negru";
            focus.Marca = "Focus";
            focus.Tip = "autoturism";
            focus.Numar = "DJ09BUJ";

            Masina fiesta = new Masina();
            fiesta.Culoare = "Albastru";
            fiesta.Marca = "Fiesta";
            fiesta.Tip = "autoturism";
            fiesta.Numar = "DJ40WAM";

            Masina ka = new Masina();
            ka.Culoare = "Verde";
            ka.Marca = "Ka";
            ka.Tip = "autoturism";
            ka.Numar = "B20ABC";

            Masina volvo = new Masina();
            volvo.Culoare = "gri";
            volvo.Marca = "Volvo";
            volvo.Tip = "camion";
            volvo.Numar = "BV11OOP";

           

            volvo.IntraInParcare();

            if (!volvo.OcupaLoc(parcela1))
            {
                if (!volvo.OcupaLoc(parcela2))
                {
                    if (!volvo.OcupaLoc(parcela3)) 
                    { 
                        Console.WriteLine($"Nu exista un loc de parcare disponibil");
                    }
                }
            }

            focus.IntraInParcare();

            if (!focus.OcupaLoc(parcela1))
            {
                if (!focus.OcupaLoc(parcela2))
                {
                    Console.WriteLine($"Nu exista un loc de parcare disponibil");
                }
            }

            fiesta.IntraInParcare();

            if (!fiesta.OcupaLoc(parcela1))
            {
                if (!fiesta.OcupaLoc(parcela2))
                {
                    Console.WriteLine($"Nu exista un loc de parcare disponibil");
                }
            }

            ka.IntraInParcare();

            if (!ka.OcupaLoc(parcela1))
            {
                if (!ka.OcupaLoc(parcela2))
                {
                    Console.WriteLine($"Nu exista un loc de parcare disponibil");
                }
            }
            
            focus.ElibereazaLoc(parcela1);

            ka.IntraInParcare();

            if (!ka.OcupaLoc(parcela1))
            {
                if (!ka.OcupaLoc(parcela2))
                {
                    Console.WriteLine($"Nu exista un loc de parcare disponibil");
                }
            }
            Console.ReadKey();
        }
    }
}
