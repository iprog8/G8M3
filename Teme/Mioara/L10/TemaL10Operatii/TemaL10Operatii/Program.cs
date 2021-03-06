﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaL10Operatii
{
    class Program


    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alege operatorul pentru a continua: 1.Adunare ; 2.Scadere ; 3.Inmultire ; 4.Impartire");
            ConsoleKeyInfo tastaApasata = Console.ReadKey();

            Console.WriteLine("Introdu primul numar");
            string primaValoare = Console.ReadLine();
            Console.WriteLine("Introdu al doilea numar");
            string aDouaValoare = Console.ReadLine();
            int primaValoareInt = int.Parse(primaValoare);
            int aDouaValoareInt = int.Parse(aDouaValoare);

            if (tastaApasata.Key == ConsoleKey.D1)
            {
                int suma = Adunare(primaValoareInt, aDouaValoareInt);
                Console.WriteLine($"Rezultatul adunarii este {suma}");
            }
            else if (tastaApasata.Key == ConsoleKey.D2)
            {
                int diferenta = Scadere(primaValoareInt, aDouaValoareInt);
                Console.WriteLine($"Rezultatul scaderii este {diferenta}");
            }
            else if (tastaApasata.Key == ConsoleKey.D3)
            {
                int produs = Inmultire(primaValoareInt, aDouaValoareInt);
                Console.WriteLine($"Rezultatul inmultirii este {produs}");
            }
            else if (tastaApasata.Key == ConsoleKey.D4)
            {
                int cat = Impartire(primaValoareInt, aDouaValoareInt);
                Console.WriteLine($"Rezultatul impartirii este {cat}");
            }
            Console.ReadKey();
        }

        static int Adunare(int primaValoare, int aDouaValoare)
        {
            int rezulttulAdunarii = primaValoare + aDouaValoare;
            return rezultatulAdunarii;
        }

        static int Scadere(int primavaloare, int aDouaValoare)
        {
            int rezultatulScaderii = primaValoare - aDouaValoare;
            return rezultatulScaderii;
        }

        static int Inmultire(int primavaloare, int aDouaValoare)
        {
            int rezultatulInmultirii = primaValoare * aDouaValoare;
            return rezultatulInmultirii;
        }

        static int Impartire(int primaValoare, int aDouaValoare)
        {
            int rezulatulImpartirii = primaValoare / aDouaValoare;
            return rezulatulImpartirii;
        }
    }
}
