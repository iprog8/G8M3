using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcepteDeProgramare2
{
    class Program
    {
        static List<string> listaAngajati = new List<string>()
        {
            "Ion Vasile",
            "Claudiu Constantin",
            "Maria Popa"
        };
        static DateTime dataNasterii;

        static void Main(string[] args)
        {
            //apelarea unei functii care nu are parametri si nu returneaza nimic
            AfiseazaAngajati();

            //apelarea unei functii care are un parametru si nu returneaza nimic
            SalveazaDataNasterii(new DateTime(1986,5,1));
            AfiseazaPatratulNumarului(7);

            //apelarea unei functii care are mai multi paraetri si nu returneaza nimic
            AfiseazaSuma(7, 14);

            //apelarea unei functii fara parametri care returneaza ceva
            DateTime dataNastere = RetuneazaDataNasterii();
            int varstaCalculata = CalculeazaVarsta();
            Console.WriteLine($"Varsta calculata pentru dataNasterii {dataNastere} este {varstaCalculata}.");
            Console.WriteLine($"Varsta calculata pentru dataNasterii {RetuneazaDataNasterii()} este {CalculeazaVarsta()}.");

            //apelarea uneifunctii cu un parametru si care returneaza ceva
            int patratulNumarului = CalculeazaPatratulNumarului(5);
            int patratulNumarului2 = CalculeazaPatratulNumarului(9);

            //apelarea unei functii cu mai multi parametri si care returneaza ceva
            int sumaNumerelor = CalculeazaSuma(6, 3);
            int sumaNumerelor2 = CalculeazaSuma(patratulNumarului, patratulNumarului2);

            Console.WriteLine($"Suma numerelor {patratulNumarului} si {patratulNumarului2} este {sumaNumerelor2}");

            //ca sa nu se inchida consola
            Console.ReadKey();
        }
        //o functie poate sa aiba sau nu parametri
        //o functie poate sa returneze sau nu ceva

        //crearea unei functii care nu are parametri si nu returneaza nimic
        static void AfiseazaAngajati()
        {
            foreach (var angajat in listaAngajati)
            {
                Console.WriteLine("Acesta este angajatul: " + angajat);
            }
        }

        // crearea unei functii care are un parametru si care nu returneaza nimic
        static void SalveazaDataNasterii(DateTime dataNastere)
        {
            dataNasterii = dataNastere;
        }

        static void AfiseazaPatratulNumarului(int numar)
        {
            int patratulNUmarului = CalculeazaPatratulNumarului(numar);
            Console.WriteLine("Patratul numarului " + numar + " este " + patratulNUmarului);
            Console.WriteLine($"Patratul numarului {numar} este {patratulNUmarului}");
        }

        // crearea unei functii cu mai multi parametri si care nu returneaza nimic
        static void AfiseazaSuma(int termen1, int termen2)
        {
            int suma = CalculeazaSuma(termen1, termen2);
            Console.WriteLine($"Suma dintre {termen1} si {termen2} este {suma}");

        }

        //crearea unei functii fara parametri si care returneaza ceva
        static DateTime RetuneazaDataNasterii()
        {
            return dataNasterii;
        }

        static int CalculeazaVarsta()
        {
            int varsta = (DateTime.Now - dataNasterii).Days;
            return varsta;
        }

        //crearea unei funcii cu un parametru si care retuneaza ceva
        static int CalculeazaPatratulNumarului(int numar)
        {
            int patratulNumarului = numar * numar;
            return patratulNumarului;
        }

        //crearea unei functii cu mai multi parametri si care returneaza ceva
        static int CalculeazaSuma(int termen1, int termen2)
        {
            int suma = termen1 + termen2;
            return suma;
        }

    }
}
