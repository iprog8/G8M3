using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class Program
    {
        //2. crearea de variabile
        static string numeCompanie = string.Empty;
        static ushort numarAngajati = 0;
        static string tipCompanie = string.Empty;
        static DateTime dataInfiintarii;
        static string CUI = string.Empty;
        static string nrTelefon = string.Empty;
        static string localitate = string.Empty;
        static string tara = string.Empty;
        static bool areTVA = false;
        static decimal cifraDeAfaceri = 0;
        static decimal datorii = 0;
        static decimal incasari = 0;
        //3. crearea variabilei lista
        static List<string> listaAngajati = new List<string>();
        static void Main(string[] args)
        {
            //3. adaugam angajati
            listaAngajati.Add("Ion Vasile");
            listaAngajati.Add("Dan Popa");
            listaAngajati.Add("Maria Popescu");

            AfiseazaAngajati();
            AfiseazaPare();

            Console.ReadKey();
        }

        //4. afisati toti angajatii
        static void AfiseazaAngajati()
        {
            foreach (var angajat in listaAngajati)
            {
                Console.WriteLine(angajat);
            }
        }

        //6. afiseaza angajatii de pe pozitiile pare 
        static void AfiseazaPare()
        {
            for (int i = 0; i < listaAngajati.Count; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(listaAngajati[i]);
                }
            }
        }
    }
}
