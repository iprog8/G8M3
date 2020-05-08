using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodImpreuna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alege operatorul pentru a continua: 1.Adunare ; 2.Scadere ; 3.Inmultire ; 4.Impartire");

            //la declararea unei variabile
            //[tipul] [denumirea variabilei] [egal] [de unde citeste valoarea]
            int i = 0;
            ConsoleKeyInfo tastaApasata = Console.ReadKey();
            if(tastaApasata.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Introdu primul numar");
                string primaValoare = Console.ReadLine();
                Console.WriteLine("Introdu al doilea numar");
                string aDouaValoare = Console.ReadLine();
                int primaValoareInt = int.Parse(primaValoare);
                int aDouaValoareInt = int.Parse(aDouaValoare);

                int suma = Adunare(primaValoareInt, aDouaValoareInt);
                Console.WriteLine($"Rezultatul adunarii este {suma}");
                Console.ReadKey();

            }
        }

        static int Adunare(int primaValoare, int aDouaValoare)
        {
            int rezultatulAdunarii = primaValoare + aDouaValoare;
            return rezultatulAdunarii;
        }
    }
}

