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

            Masina Dacia = new Masina();
            Dacia.Marca = "Dacia";
            Dacia.Culoare = "Gri";
            Dacia.Tip = TipMasina.Automobil;
            Dacia.Numar = "AG11GEY";

            Masina Mercedes = new Masina();
            Mercedes.Marca = "Mercedes";
            Mercedes.Culoare = "Albastru";
            Mercedes.Tip = TipMasina.Automobil;
            Mercedes.Numar = "B250SIE";

            Masina Ford = new Masina();
            Ford.Marca = "Ford";
            Ford.Culoare = "Negru";
            Ford.Tip = TipMasina.Automobil;
            Ford.Numar = "B50POL";

            Masina Audi = new Masina();
            Audi.Marca = "Audi";
            Audi.Culoare = "Alb";
            Audi.Tip = TipMasina.Camion;
            Audi.Numar = "VN20TED";

            Dacia.IntraInParcare();
            if (Dacia.OcupaLoc(primulLocDeParcare))
            {
            }
            else if (Dacia.OcupaLoc(alDoileaLocDeParcare))
            {

            }
            else
            {
                Console.WriteLine($"Parcarea de tip {TipMasina.Automobil}  este plina! Autovehiculul marca {Dacia.Marca} nu a putut fi parcata.");
            }


            Mercedes.IntraInParcare();
            if (Mercedes.OcupaLoc(primulLocDeParcare))
            {
            }
            else if (Mercedes.OcupaLoc(alDoileaLocDeParcare))
            {

            }
            else
            {
                Console.WriteLine($"Parcarea de tip {TipMasina.Automobil}  este plina! Autovehiculul marca {Mercedes.Marca} nu a putut fi parcata.");
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

            Ford.IntraInParcare();
            if (Ford.OcupaLoc(primulLocDeParcare))
            {
            }
            else if (Ford.OcupaLoc(alDoileaLocDeParcare))
            {

            }
            else
            {
                Console.WriteLine($"Parcarea de tip {TipMasina.Automobil}  este plina! Autovehiculul marca {Ford.Marca} nu a putut fi parcata.");
            }
            Dacia.ElibereazaLoc(primulLocDeParcare);
            Dacia.IesireDinParcare();
            Ford.IntraInParcare();
            if (Ford.OcupaLoc(primulLocDeParcare))
            {
            }
            else if (Ford.OcupaLoc(alDoileaLocDeParcare))
            {

            }
            else
            {
                Console.WriteLine($"Parcarea de tip {TipMasina.Automobil}  este plina! Autovehiculul marca {Ford.Marca} nu a putut fi parcata.");
            }

            Console.ReadKey();
        }
    }
}
