using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n Selecteaza operatia pe care vrei sa o faci:");
            Console.WriteLine(" 1.Adunare; \n 2.Scadere; \n 3.Inmultire; \n 4.Impartire;");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1)
            {
                   
                Console.WriteLine("\n Cati termeni vrei sa aiba operatia ta? ");
                string termen1String = Console.ReadLine();
                int termen1Int = int.Parse(termen1String);
                int rezultat = Adunare(termen1Int);
                Console.WriteLine($"Suma numerelor tale este: {rezultat}");
            }
            if(key.Key == ConsoleKey.D2)
            {
                Console.WriteLine(" \n Introdu primul numar si apasa enter");
                string termen1String = Console.ReadLine();
                int termen1Int = int.Parse(termen1String);
                Console.WriteLine("Introdu al doilea numar si apasa enter");
                string termen2String = Console.ReadLine();
                int termen2Int = int.Parse(termen2String);
                int rezultat = Scadere(termen1Int, termen2Int);
                Console.WriteLine($"Rezultatul tau este: {rezultat}");
            }
            if(key.Key == ConsoleKey.D3)
            {
                Console.WriteLine(" \n Cati termeni vrei sa aiba operatia ta? ");
                string termenString = Console.ReadLine();
                int termenInt = int.Parse(termenString);
                int rezultat = Inmultire(termenInt);
                Console.WriteLine($"Rezultatul tau este: {rezultat}");
            }
            if(key.Key == ConsoleKey.D4)
            {
                Console.WriteLine("\n Introdu primul numar si apasa enter");
                string termen1String = Console.ReadLine();
                double termen1Int = double.Parse(termen1String);
                Console.WriteLine("\n Introdu al doilea numar si apasa enter");
                string termen2String = Console.ReadLine();
                double termen2Int = double.Parse(termen2String);
                double rezultat = Impartire(termen1Int, termen2Int);
                Console.WriteLine($"Rezultatul tau este: {rezultat}");

            }
            Console.WriteLine("\nCe vrei sa faci in continuare? : \n 1.Alta operatie \n 2.Iesire");
            ConsoleKeyInfo key2= Console.ReadKey();
            if (key2.Key == ConsoleKey.D1) Main();
            if (key2.Key == ConsoleKey.D2) Console.ReadKey();
        }
        static int Adunare(int termeni)
        {
            if(termeni < 2)
            {
                Console.WriteLine("Nu poti avea mai putin de un termen");
                Main();
            } 
            int rezultatAdunare = 0;
            for(int i = 1; i <= termeni; i++)
            {
                Console.WriteLine($"Introdu termenul cu numarul {i} si apasa enter");
                string numar = Console.ReadLine();
                int numarInt = int.Parse(numar);
                rezultatAdunare += numarInt;
            }
            return rezultatAdunare;
        }
        static int Scadere(int termen1, int termen2)
        {
            return termen1 - termen2;
        }
        static int Inmultire(int termeni)
        {
            if (termeni < 2)
            {
                Console.WriteLine("Nu poti avea mai putin de un termen");
                Main();
            }
            int rezultatInmultire = 1;
            for(int i = 1; i <= termeni; i++)
            {
                Console.WriteLine($"Introdu termenul cu numarul {i} si apasa enter");
                string numar = Console.ReadLine();
                int numarInt = int.Parse(numar);
                rezultatInmultire *= numarInt;
            }
            return rezultatInmultire;
        }
        static double Impartire(double term1, double term2)
        {
            return term1 / term2;
        }
    }
}
