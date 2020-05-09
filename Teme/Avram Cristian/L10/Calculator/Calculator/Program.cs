 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alegeti un operator pentru a continua : 1.Adunare  ||  2.Scadere  ||  3.Inmultire  || 4.Inpartire");
            ConsoleKeyInfo optiune = Console.ReadKey();
            if (optiune.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Introdu primul termen:");
                string termen1 = Console.ReadLine();
                Console.WriteLine("Introdu cel de-al doilea termen:");
                string termen2 = Console.ReadLine();
                int termen1int = int.Parse(termen1);
                int termen2int = int.Parse(termen2);
                int rezultatulAdunarii = Aduna(termen1int, termen2int);
                Console.WriteLine($"Rezulatatul adunarii este {rezultatulAdunarii}");
                Console.ReadKey();
            }
            if (optiune.Key == ConsoleKey.D2)
            {
                Console.WriteLine("Introdu primul termen:");
                string termen1 = Console.ReadLine();
                Console.WriteLine("Introdu cel de-al doilea termen:");
                string termen2 = Console.ReadLine();
                int termen1int = int.Parse(termen1);
                int termen2int = int.Parse(termen2);
                int rezultatulScaderii = Scade(termen1int, termen2int);
                Console.WriteLine($"Rezulatatul scaderii este {rezultatulScaderii}");
                Console.ReadKey();
            }
            if (optiune.Key == ConsoleKey.D3)
            {
                Console.WriteLine("Introdu primul termen:");
                string termen1 = Console.ReadLine();
                Console.WriteLine("Introdu cel de-al doilea termen:");
                string termen2 = Console.ReadLine();
                int termen1int = int.Parse(termen1);
                int termen2int = int.Parse(termen2);
                int rezultatulInmultirii = Inmulteste(termen1int, termen2int);
                Console.WriteLine($"Rezulatatul inmultirii este {rezultatulInmultirii}");
                Console.ReadKey();
            }
            if (optiune.Key == ConsoleKey.D4)
            {
                Console.WriteLine("Introdu primul termen:");
                string termen1 = Console.ReadLine();
                Console.WriteLine("Introdu cel de-al doilea termen:");
                string termen2 = Console.ReadLine();
                int termen1int = int.Parse(termen1);
                int termen2int = int.Parse(termen2);
                int rezultatulImpartirii = Imparte(termen1int, termen2int);
                Console.WriteLine($"Rezulatatul impartirii este {rezultatulImpartirii}");
                Console.ReadKey();
            }
        }

        static int Aduna(int termen1, int termen2)
        {
            int rezultatulAdunarii = termen1 + termen2;
            return rezultatulAdunarii;
        }

        static int Scade(int termen1, int termen2)
        {
            int rezultatulScaderii = termen1 - termen2;
            return rezultatulScaderii;
        }
        static int Inmulteste(int termen1, int termen2)
        {
            int rezultatulInmultirii = termen1 * termen2;
            return rezultatulInmultirii;
        }
        static int Imparte(int termen1, int termen2)
        {
            int rezultatulImpartirii = termen1 / termen2;
            return rezultatulImpartirii;
        }

    }
}
