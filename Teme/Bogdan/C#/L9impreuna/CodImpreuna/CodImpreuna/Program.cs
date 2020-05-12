using System;

namespace CodImpreuna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alege 1 pentru adunare, 2 pentru scadere, 3 pentru inmultire, 4 pentru impartire");
            ConsoleKeyInfo tastaApasata = Console.ReadKey();
            if (tastaApasata.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Ai ales adunare");
                Console.WriteLine("Introdu primul numar");
                string primaValoare = Console.ReadLine();
                Console.WriteLine("Introdu cel de-al doilea numar");
                string aDouaValoare = Console.ReadLine();
                int primaValoareInt = int.Parse(primaValoare);
                int aDouaValoareInt = int.Parse(aDouaValoare);
                int suma = Adunare(primaValoareInt, aDouaValoareInt);
                Console.WriteLine($"Rezultatul adunarii celor 2 numere este {suma}");
                Console.ReadKey();
            }
            if (tastaApasata.Key == ConsoleKey.D2)
            {
                Console.WriteLine("Ai ales scadere");
                Console.WriteLine("Introdu primul numar");
                string primaValoare = Console.ReadLine();
                Console.WriteLine("Introdu cel de-al doilea numar");
                string aDouaValoare = Console.ReadLine();
                int primaValoareInt = int.Parse(primaValoare);
                int aDouaValoareInt = int.Parse(aDouaValoare);
                int scadere = Scadere(primaValoareInt, aDouaValoareInt);
                Console.WriteLine($"Rezultatul scaderii celor 2 numere este {scadere}");
                Console.ReadKey();
            }
            if (tastaApasata.Key == ConsoleKey.D3)
            {
                Console.WriteLine("Ai ales inmultire");
                Console.WriteLine("Introdu primul numar");
                string primaValoare = Console.ReadLine();
                Console.WriteLine("Introdu cel de-al doilea numar");
                string aDouaValoare = Console.ReadLine();
                int primaValoareInt = int.Parse(primaValoare);
                int aDouaValoareInt = int.Parse(aDouaValoare);
                int inmultire = Inmultire(primaValoareInt, aDouaValoareInt);
                Console.WriteLine($"Rezultatul inmultirii celor 2 numere este {inmultire}");
                Console.ReadKey();
            }
            if (tastaApasata.Key == ConsoleKey.D4)
            {
                Console.WriteLine("Ai ales impartire");
                Console.WriteLine("Introdu primul numar");
                string primaValoare = Console.ReadLine();
                Console.WriteLine("Introdu cel de-al doilea numar");
                string aDouaValoare = Console.ReadLine();
                int primaValoareInt = int.Parse(primaValoare);
                int aDouaValoareInt = int.Parse(aDouaValoare);
                int impartire = Impartire(primaValoareInt, aDouaValoareInt);
                Console.WriteLine($"Rezultatul impartirii celor 2 numere este {impartire}");
                Console.ReadKey();
            }
        }
        static int Adunare(int primaValoare, int aDouaValoare)
        {
            int rezultatulAdunarii = primaValoare + aDouaValoare;
            return rezultatulAdunarii;
        }
        static int Scadere(int primaValoare, int aDouaValoare)
        {
            int rezultatulScaderii = primaValoare - aDouaValoare;
            return rezultatulScaderii;
        }
        static int Inmultire(int primaValoare, int aDouaValoare)
        {
            int rezultatulInmultirii = primaValoare * aDouaValoare;
            return rezultatulInmultirii;
        }
        static int Impartire(int primaValoare, int aDouaValoare)
        {
            int rezultatulImpartirii = primaValoare / aDouaValoare;
            return rezultatulImpartirii;
        }
    }
}
