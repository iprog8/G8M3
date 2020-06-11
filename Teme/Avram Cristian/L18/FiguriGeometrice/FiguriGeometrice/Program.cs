using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    class Program
    {
        static void Main()
        {
            Cerc c1 = new Cerc(10);
            Console.WriteLine($"Aria cercului cu raza de {c1.Raza} este {c1.CalculeazaArie()}");
            Console.WriteLine($"Perimetrul cercului cu raza de {c1.Raza} este {c1.CalculeazaPerimetru()}");
            Dreptunghi d1 = new Dreptunghi(22, 11);
            Console.WriteLine($"Aria dreptunghiului cu lungimea {d1.Lungime} si latimea {d1.Latime} este {d1.CalculeazaArie()}");
            Console.WriteLine($"Perimetrul dreptunghiului cu lungimea {d1.Lungime} si latimea {d1.Latime} este {d1.CalculeazaPerimetru()}");
            Patrat p1 = new Patrat(6);
            Console.WriteLine($"Aria paytatului cu latura de {p1.Latura} este {p1.CalculeazaArie()}");
            Console.WriteLine($"Perimetrul patratului cu latura de {p1.Latura} este {p1.CalculeazaPerimetru()}");
            Console.ReadKey();
        }
    }
}
