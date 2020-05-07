using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class Program
    {
        public static Random rnd = new Random(); 
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
        int incasari;
        public static List<string> angajati = new List<string>()
        {
            "Hanu Gabriel",
            "Avram Cristian",
            "Bogdan Geagu",
            "Vlad Octavian",
            "Letitia Provian"
        };
        static void Main(string[] args)
        {
            Afiseaza();
            AfiseazaPare();
            Console.WriteLine("");
            //tema 2
            int profit = CalculeazaProfit();
            Console.WriteLine($"Profitul companiei este {profit} dolari");
            int pierderi = CalculeazaPierderi();
            Console.WriteLine($"Pierderile companiei sunt {pierderi} dolari");
            Incaseaza(200);
            int datoriiRamase = Plateste(413);
            Console.WriteLine($"Compania mai are {datoriiRamase} datorii ramase");
            Console.ReadKey();
        }
        static void Afiseaza()
        {
            for(int i = 0; i < angajati.Count; i++)
            {
                Console.WriteLine(angajati[i]);
            }
        }
        static void AfiseazaPare()
        {
            Console.WriteLine("Angajatii cu pozitii pare sunt: ");
            for (int i = 0; i < angajati.Count; i++)
            {
                Console.WriteLine(angajati[i]);
            }
        }
        static int CalculeazaProfit()
        {
            int incasari = rnd.Next(1, 100);
            int pierderi = rnd.Next(1, 100);
            incasari -= pierderi;
            return incasari;
        }
        static int CalculeazaPierderi()
        {
            int profit = rnd.Next(1, 100);
            int pierderi = rnd.Next(-100, 1);
            pierderi += profit;
            return pierderi;
        }
        static void Incaseaza(int adunari)
        {
            int incasari = rnd.Next(1, 100);
            incasari += adunari;
            Console.WriteLine($"Incasarile companiei sunt {incasari} dolari");
        }
        static int Plateste(int plata)
        {
            int datorii = rnd.Next(1, 1000);
            datorii -= plata;
            if (plata > datorii) datorii = 0;
            return datorii;
        }
    }
}