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
        int numarAngajati;
        string tipCompanie;
        DateTime dataInfiintarii = new DateTime(2004, 1, 4);
        ushort CUI;
        string numarTelefon;
        string localitate;
        string tara;
        bool areTVA;
        ulong cifraDeAfaceri;
        int datorii;
        ulong incasari;
        static List<string> angajati = new List<string>();
        static void Main(string[] args)
        {
            angajati.Add("Hanu Gabriel");
            angajati.Add("Avram Cristian");
            angajati.Add("Bogdan Geagu");
            angajati.Add("Vlad Octavian");
            angajati.Add("Letitia Provian");
            //afisare toti angajatii
            for (int i = 0; i < angajati.Count; i++)
            {
                Console.WriteLine(angajati[i]);
            }
            for (int i = 0; i < angajati.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(angajati[i]);
                }
            }
        }
    }
}
