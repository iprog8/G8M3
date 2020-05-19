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
            while (true)
            {


                Console.WriteLine("Alege un operator pentru a continua: 1.Adunare ; 2.Scadere ; 3.Inmultire ; 4.Impartire");

                //la declararea unei variabile
                //[tipul] [denumirea variabilei] [egal] [de unde citeste valoarea]
                ConsoleKeyInfo tastaApasata = Console.ReadKey();
                if (tastaApasata.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("\nIntrodu primul numar");
                    string primaValoare = Console.ReadLine();
                    Console.WriteLine("Introdu al doilea numar");
                    string aDouaValoare = Console.ReadLine();
                    int primaValoareInt = int.Parse(primaValoare);
                    int aDouaValoareInt = int.Parse(aDouaValoare);

                    int suma = Adunare(primaValoareInt, aDouaValoareInt);

                    Console.WriteLine($"Rezultatul adunarii este {suma}");
                }

                else if (tastaApasata.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Introdu primul numar");
                    string primaValoare = Console.ReadLine();
                    Console.WriteLine("Introdu al doilea numar");
                    string aDouaValoare = Console.ReadLine();
                    int primaValoareInt = int.Parse(primaValoare);
                    int aDouaValoareInt = int.Parse(aDouaValoare);
                    int scadere = Scadere(primaValoareInt, aDouaValoareInt);
                    Console.WriteLine($"Rezultatul scaderii este {scadere}");
                }

                else if (tastaApasata.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("Introdu primul numar");
                    string primaValoare = Console.ReadLine();
                    Console.WriteLine("Introdu al doilea numar");
                    string aDouaValoare = Console.ReadLine();
                    int primaValoareInt = int.Parse(primaValoare);
                    int aDouaValoareInt = int.Parse(aDouaValoare);
                    int inmultire = Inmultire(primaValoareInt, aDouaValoareInt);
                    Console.WriteLine($"Rezultatul inmultirii este {inmultire}");
                }

                else if (tastaApasata.Key == ConsoleKey.D4)
                {
                    Console.WriteLine("Introdu primul numar");
                    string primaValoare = Console.ReadLine();
                    Console.WriteLine("Introdu al doilea numar");
                    string aDouaValoare = Console.ReadLine();
                    int primaValoareInt = int.Parse(primaValoare);
                    int aDouaValoareInt = int.Parse(aDouaValoare);

                    if (aDouaValoareInt == 0)
                    {
                        Console.WriteLine("Nu alege numarul 0");
                    }
                    else
                    {
                        double impartire = Impartire(primaValoareInt, aDouaValoareInt);
                        Console.WriteLine($"Rezultatul impartirii este {impartire}");
                    }

                }

                else
                {
                    Console.WriteLine("Nu ai selectat nicio operatiune valida");

                }
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

        static double Impartire(int primaValoare, int aDouaValoare)
        {
            double rezultatulImpartirii = (double)primaValoare / aDouaValoare;
            return rezultatulImpartirii;
        }

    }
}
