using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class Program
    {
        static List<string> listaAngajati = new List<string>();
        static void Main(string[] args)
        {
            Variabile();
            VariabilaLista();
            Afiseaza();
            Console.ReadKey();
        }
        static void Variabile()

        {
            string numeCompanie = "ScoalaDeAcasa.ro";
            string tipCompanie = "PFA";
            string dataInfiintarii = "04/05/2020";
            string CUI = "454783";
            string nrTelefon = "0744378299";
            string localitate = "Bucuresti";
            string tara = "Romania";
            bool areTvVA = true;
            long cifraDeAfaceri;
            long datorii;
            long incasari;
        }

        static void VariabilaLista()
        {
            listaAngajati.Add("Chirica Denis");
            listaAngajati.Add("Chirila Sofia");
            listaAngajati.Add("Mitroi Maria");
        }


        static void Afiseaza()
        {
            //Console.WriteLine(listaAngajati);
            foreach (var angajat in listaAngajati)
            {
                Console.WriteLine(angajat);
            }

        }


    }

}

