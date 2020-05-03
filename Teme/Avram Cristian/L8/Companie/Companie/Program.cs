using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class Program
    {
        string numeCompanie;
        ushort numarAngajati;
        string tipCompanie;
        DateTime dataInfiintarii;
        string CUI;
        string nrTelefon;
        string localitate;
        string tara;
        bool areTVA;
        ulong cifraDeAfaceri;
        ulong datorii;
        ulong incasari;

        static void Main(string[] args)
        {
            Afiseaza();
            AfiseazaPare();     
        }

        static void Afiseaza()
        {
            List<string> Angajati = new List<string>();
            Angajati.Add("Popescu");
            Angajati.Add("Ionescu");
            Angajati.Add("Marinescu");

             for (int i = 0; i < Angajati.Count; i++)
            {
                Console.WriteLine(Angajati[i]);
            }

        }
        static void AfiseazaPare()
        {
            List<string> Angajati = new List<string>();
            Angajati.Add("Popescu");
            Angajati.Add("Ionescu");
            Angajati.Add("Marinescu");



            for (int i = 0; i < Angajati.Count; i++)
            {
                if (i % 2 ==0)
                Console.WriteLine(Angajati[i]);
            }

        }
    }
}
