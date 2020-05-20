using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcareContinuareCurs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LocParcare> locuriParcare = new List<LocParcare>();
            LocParcare loc1 = new LocParcare() { CuloareArie = "Rosu" , LiteraRand = "A", Pozitie = 1, TipLoc = TipMasina.Autoturism };
            locuriParcare.Add(loc1);

            LocParcare loc2 = new LocParcare() { CuloareArie = "Rosu" , LiteraRand = "A", Pozitie = 2, TipLoc = TipMasina.Autoturism };
            locuriParcare.Add(loc2);
            LocParcare loc3 = new LocParcare() { CuloareArie = "Rosu", LiteraRand = "A", Pozitie = 3, TipLoc = TipMasina.Autoturism };
            locuriParcare.Add(loc3);

            Masina dacia = new Masina(){ Culoare = "Gri",Marca = "Dacia", Numar = "B123ZZZ",Tip = TipMasina.Camion };
            Masina opel = new Masina() { Culoare = "Rosu", Marca = "Opel", Numar = "C123BNX", Tip = TipMasina.Autoturism };
            Masina logan = new Masina() { Culoare = "Maro", Marca = "Logan", Numar = "D645NNN", Tip = TipMasina.Autoturism };
            Masina ford = new Masina() { Culoare = "Alb", Marca = "Ford", Numar = "B321AAA", Tip = TipMasina.Autoturism };

            opel.IntraInParcare();
            LocParcare locParcareLiber = LocParcare.GasesteLocParcarePentruMasina(locuriParcare, opel);
            if(opel.OcupaLocParcare(locParcareLiber))
            {
                Console.WriteLine($"Masina cu numarul {opel.Numar} a parcat pe locul de parcare {locParcareLiber.LiteraRand}{locParcareLiber.Pozitie}");
            }

            dacia.IntraInParcare();
            LocParcare locParcareLiber1 = LocParcare.GasesteLocParcarePentruMasina(locuriParcare, dacia);
            if (dacia.OcupaLocParcare(locParcareLiber1))
            {
                Console.WriteLine($"Masina cu numarul {dacia.Numar} a parcat pe locul de parcare {locParcareLiber1.LiteraRand}{locParcareLiber1.Pozitie}");
            }

            logan.IntraInParcare();
            LocParcare locParcareLiber3 = LocParcare.GasesteLocParcarePentruMasina(locuriParcare, logan);
            if (logan.OcupaLocParcare(locParcareLiber3))
            {
                Console.WriteLine($"Masina cu numarul {logan.Numar} a parcat pe locul de parcare {locParcareLiber3.LiteraRand}{locParcareLiber3.Pozitie}");
            }

            ford.IntraInParcare();
            LocParcare locParcareLiber4 = LocParcare.GasesteLocParcarePentruMasina(locuriParcare, ford);
            if (ford.OcupaLocParcare(locParcareLiber4))
            {
                Console.WriteLine($"Masina cu numarul {ford.Numar} a parcat pe locul de parcare {locParcareLiber4.LiteraRand}{locParcareLiber4.Pozitie}");
            }

            if (opel.ElibereazaLocParcare(loc1))
            {
                opel.IeseDinParcare();
            }
            Console.ReadKey();
        }
      
    }
}
