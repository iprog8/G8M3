using System;
using System.Collections.Generic;

namespace Parcare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LocParcare> locuriParcare = new List<LocParcare>();
            LocParcare primulLocDeParcare = new LocParcare();
            locuriParcare.Add(primulLocDeParcare);
            primulLocDeParcare.CuloareArie = "alb";
            primulLocDeParcare.LiteraRand = "A";
            primulLocDeParcare.Pozitie = 1;
            primulLocDeParcare.TipLoc = TipMasina.Automobil;

            LocParcare alDoileaLocDeParcare = new LocParcare();
            locuriParcare.Add(alDoileaLocDeParcare);
            alDoileaLocDeParcare.CuloareArie = "rosu";
            alDoileaLocDeParcare.LiteraRand = "B";
            alDoileaLocDeParcare.Pozitie = 1;
            alDoileaLocDeParcare.TipLoc = TipMasina.Camion;

            Masina dacia = new Masina();
            dacia.Marca = "Dacia";
            dacia.Culoare = "Gri";
            dacia.Tip = TipMasina.Automobil;
            dacia.Numar = "AG11GEY";

            Masina mercedes = new Masina();
            mercedes.Marca = "Mercedes";
            mercedes.Culoare = "Albastru";
            mercedes.Tip = TipMasina.Automobil;
            mercedes.Numar = "B250SIE";

            Masina ford = new Masina();
            ford.Marca = "Ford";
            ford.Culoare = "Negru";
            ford.Tip = TipMasina.Automobil;
            ford.Numar = "B50POL";

            Masina Audi = new Masina();
            Audi.Marca = "Audi";
            Audi.Culoare = "Alb";
            Audi.Tip = TipMasina.Camion;
            Audi.Numar = "VN20TED";

            dacia.IntraInParcare();
            if (dacia.OcupaLoc(primulLocDeParcare))
            {
            }
            else if (dacia.OcupaLoc(alDoileaLocDeParcare))
            {

            }
            else
            {
                Console.WriteLine($"Parcarea de tip {TipMasina.Automobil}  este plina! Autovehiculul marca {dacia.Marca} nu a putut fi parcata.");
            }


            mercedes.IntraInParcare();
            if (mercedes.OcupaLoc(primulLocDeParcare))
            {
            }
            else if (mercedes.OcupaLoc(alDoileaLocDeParcare))
            {

            }
            else
            {
                Console.WriteLine($"Parcarea de tip {TipMasina.Automobil}  este plina! Autovehiculul marca {mercedes.Marca} nu a putut fi parcata.");
            }

            Audi.IntraInParcare();
            if (Audi.OcupaLoc(primulLocDeParcare))
            {
            }
            else if (Audi.OcupaLoc(alDoileaLocDeParcare))
            {

            }
            else
            {
                Console.WriteLine($"Parcarea de tip {TipMasina.Camion}  este plina! Autovehiculul marca {Audi.Marca} nu a putut fi parcata.");
            }

            ford.IntraInParcare();
            if (ford.OcupaLoc(primulLocDeParcare))
            {
            }
            else if (ford.OcupaLoc(alDoileaLocDeParcare))
            {

            }
            else
            {
                Console.WriteLine($"Parcarea de tip {TipMasina.Automobil}  este plina! Autovehiculul marca {ford.Marca} nu a putut fi parcata.");
            }
            dacia.ElibereazaLoc(primulLocDeParcare);
            dacia.IesireDinParcare();
            ford.IntraInParcare();
            if (ford.OcupaLoc(primulLocDeParcare))
            {
            }
            else if (ford.OcupaLoc(alDoileaLocDeParcare))
            {

            }
            else
            {
                Console.WriteLine($"Parcarea de tip {TipMasina.Automobil}  este plina! Autovehiculul marca {ford.Marca} nu a putut fi parcata.");
            }

            Console.ReadKey();
        }
    }
}
