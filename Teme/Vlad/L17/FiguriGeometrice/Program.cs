using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    class Program
    {
        static void Main(string[] args)
        {
            AlegeCalcul();
            Console.ReadKey();
        }

        private static void AlegeCalcul()
        {
            Console.WriteLine($"Selectati operatiunea dorita:");
            Console.WriteLine($"1.Calculeaza Aria si Perimetrul unui cerc.");
            Console.WriteLine($"2.Calculeaza Aria si Perimetrul unui dreptunghi.");
            Console.WriteLine($"3.Calculeaza Aria si Perimetrul unui patrat.");
            ConsoleKeyInfo tastaApasata = Console.ReadKey();
            switch (tastaApasata.Key)
            {
                case ConsoleKey.D1:
                    AriaSiPerimetrulCercului();
                    break;
                case ConsoleKey.D2:
                    AriaSiPerimetrulDreptunghiului();
                    break;
                case ConsoleKey.D3:
                    AriaSiPerimetrulPatratului();
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Doriti o noua operatiune? Y/N");
            Console.WriteLine();

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                AlegeCalcul();
            }
        }

        private static void AriaSiPerimetrulCercului()
        {
            Console.WriteLine();
            Console.WriteLine($"Introduceti raza cercului:");
            string razaCerculuiStr = Console.ReadLine();
            double razaCerculuiDouble = Convert.ToDouble(razaCerculuiStr);
            if (razaCerculuiDouble <= 0)
            {
                Console.WriteLine($"Introduceti o valoare pozitiva pentru raza cercului");
                AriaSiPerimetrulCercului();
            }
            Cerc Cerc = new Cerc(razaCerculuiDouble);
            double ariaCercului = Cerc.CalculeazaAria();
            double ariaCerculuiAprox = Math.Round(ariaCercului, 2);
            double perimetrulCercului = Cerc.CalculeazaPerimetru();
            double perimetrulCerculuiAprox = Math.Round(perimetrulCercului, 2);
            Console.WriteLine($"Aria cercului este egala cu :{ariaCerculuiAprox} cm patrati");
            Console.WriteLine($"Perimetrul cercului este egal cu :{perimetrulCerculuiAprox} cm");

        }
        private static void AriaSiPerimetrulDreptunghiului()
        {
            Console.WriteLine();
            Console.WriteLine($"Introduceti lungimea dreptunghiului:");
            string lungimeaDreptunghiuluiStr = Console.ReadLine();
            double lungimeaDreptunghiuluiDouble = Convert.ToDouble(lungimeaDreptunghiuluiStr);
            Console.WriteLine($"Introduceti latimea dreptunghiului:");
            string latimeaDreptunghiuluiStr = Console.ReadLine();
            double latimeaDreptunghiuluiDouble = Convert.ToDouble(latimeaDreptunghiuluiStr);
            if (latimeaDreptunghiuluiDouble <= 0 || lungimeaDreptunghiuluiDouble <= 0)
            {
                Console.WriteLine($"Introduceti valori pozitive pentru laturile dreptunghiului");
                AriaSiPerimetrulDreptunghiului();
            }
            Dreptunghi Dreptunghi = new Dreptunghi(latimeaDreptunghiuluiDouble, lungimeaDreptunghiuluiDouble);
            double ariaDreptunghiului = Dreptunghi.CalculeazaAria();
            double ariaDreptunghiuluiAprox = Math.Round(ariaDreptunghiului, 2);
            double perimetrulDreptunghiului = Dreptunghi.CalculeazaPerimetru();
            double perimetrulDreptunghiuluiAprox = Math.Round(perimetrulDreptunghiului, 2);
            Console.WriteLine($"Aria dreptunghiului este egala cu :{ariaDreptunghiuluiAprox} cm patrati");
            Console.WriteLine($"Perimetrul dreptunghiului este egal cu :{perimetrulDreptunghiuluiAprox} cm");

        }
        private static void AriaSiPerimetrulPatratului()
        {
            Console.WriteLine();
            Console.WriteLine($"Introduceti latura patratului:");
            string laturaPatratuluiStr = Console.ReadLine();
            double laturaPatratuluiDouble = Convert.ToDouble(laturaPatratuluiStr);
            if (laturaPatratuluiDouble <= 0)
            {
                Console.WriteLine($"Introduceti valori pozitive pentru laturile dreptunghiului");
                AriaSiPerimetrulDreptunghiului();
            }
            Patrat Patrat = new Patrat(laturaPatratuluiDouble);
            double ariaPatratului = Patrat.CalculeazaAria();
            double ariaPatratuluiAprox = Math.Round(ariaPatratului, 2);
            double perimetrulPatratului = Patrat.CalculeazaPerimetru();
            double perimetrulPatratuluiAprox = Math.Round(perimetrulPatratului, 2);
            Console.WriteLine($"Aria Patratului este egala cu :{ariaPatratuluiAprox} cm patrati");
            Console.WriteLine($"Perimetrul Patratului este egal cu :{perimetrulPatratuluiAprox} cm");
        }
    }
}
