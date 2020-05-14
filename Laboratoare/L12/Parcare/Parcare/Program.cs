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
            List<LocParcare> locuriParcare = new List<LocParcare>();
            LocParcare loc1 = new LocParcare();
            locuriParcare.Add(loc1);
            loc1.CuloareArie = "Rosu";
            loc1.LiteraRand = "A";
            loc1.Pozitie = 1;
            loc1.TipLoc = TipMasina.Autoturism;

            LocParcare loc2 = new LocParcare();
            locuriParcare.Add(loc2);
            loc2.CuloareArie = "Rosu";
            loc2.LiteraRand = "A";
            loc2.Pozitie = 2;
            loc2.TipLoc = TipMasina.Autoturism;

            Masina dacia = new Masina() {
                Culoare = "Gri",
                Marca = "Dacia",
                Numar = "B123ZZZ",
                Tip = TipMasina.Autoturism
            };

            dacia.IntraInParcare();
            if (!dacia.OcupaLocParcare(loc1))
            {
                if (!dacia.OcupaLocParcare(loc2))
                {
                    Console.WriteLine("Nu ai unde sa o parchezi. Parcarea este plina!");
                }
            }

            Masina ford = new Masina();
            ford.Marca = "Ford";
            ford.Numar = "B321AAA";
            ford.Tip = TipMasina.Autoturism;
            ford.Culoare = "Alb";

            ford.IntraInParcare();
            if (!ford.OcupaLocParcare(loc1))
            {
                if (!ford.OcupaLocParcare(loc2))
                {
                    Console.WriteLine("Nu ai unde sa o parchezi. Parcarea este plina!");
                }
            }



            Console.ReadKey();
        }
    }
}
