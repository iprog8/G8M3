using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcepteDeProgramare
{
    //Concepte de programare
    // - variabile
    // - variabile de tip lista
    // - structuri decizionale

    // - functii
    // - functii cu parametri
    // - operatori (mate + booleni)
    // - evenimente
    // - structuri repetitive
    class Program
    {
        static void Main(string[] args)
        {
            StructuriRepetitive();
            StructuriDecizionale();
            VariabileLista();
            Variabile();
        }
        static void Variabile()
        {
            // - variabile
            //js: var/const/let numeVariabila = ''
            int nota = 0; //- 2 mild .... +2 mild
            uint notaUint = 0; // 0 ... 4 mild
            long notaLong = 0; // int la patrat
            ulong notaUlong = 0; // 0 ... 4 mild la patrat
            short notaShort = 0; // -32.??? ... 32.???
            ushort notaUshort = 0; // 0 ... 64.???
            byte notaByte = 0; // -125 ... 126
            string nume = "Alex";
            bool continua = true;
            double pi = 3.14;

            int valoare = 2;
            short valoareShort = 5;
            int rezultat = valoare + valoareShort;
            valoareShort = (short)valoare; //conversie explicita de la int la short
            string valoareString = valoare.ToString();
        }

        static void VariabileLista()
        {
            List<string> orase = new List<string>();
            orase.Add("Bucuresti");
            orase.Add("Constanta");
            orase.Add("Iasi");
            int numarOrase = orase.Count();
            orase.Insert(0, "Bacau");
            orase.RemoveAt(0);
            orase.Remove("Iasi");
            int pozitieOras = orase.IndexOf("Constanta");
            bool contineIasi = orase.Contains("Iasi");
            orase.Clear(); // le sterge pe toate
        }

        static void StructuriDecizionale()
        {
            int a = 5;
            int b = 7;
            if (a < b)
            {
                Console.WriteLine("A < B");
            }

            if (a > b)
            {
                Console.WriteLine("A > B");
            }
            else
            {
                Console.WriteLine("A < B");
            }

            string actiune = "creste";
            switch (actiune)
            {
                case "scade":
                    Console.WriteLine("Nivelul marii scade");
                        break;
                case "creste":
                    Console.WriteLine("Nivelul marii creste");
                    break;
                default:
                    Console.WriteLine("Nivelul marii ramane neschimbat");
                    break;
            }
        }

        static void StructuriRepetitive()
        {
            string text = "Mama are mere";
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(text[i]);
                }
            }
            foreach (char caracter in text)
            {
                Console.WriteLine(caracter);
            }

            List<int> numere = new List<int>();
            do
            {
                Random random = new Random();
                int numarNou = random.Next(1, 49);
                if (!numere.Contains(numarNou))
                {
                    numere.Add(numarNou);
                }
            } while (numere.Count < 6);
            foreach (var nr in numere)
            {
                Console.WriteLine(nr);
            }

            TimeSpan secunde = new TimeSpan();
            DateTime startMoment = DateTime.Now;
            Console.WriteLine(startMoment.ToLongTimeString());
            while (secunde < new TimeSpan(0, 0, 10))
            {
                secunde = DateTime.Now - startMoment;
                Thread.Sleep(0);
            }
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}
