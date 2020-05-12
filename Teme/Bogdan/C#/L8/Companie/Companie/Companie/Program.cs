using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class Program
    {
        //string numeCompanie = "AliExpress";
        //ushort numarAngajati = 500;
        //string tipCompanie = "S.A.";
        //DateTime dataInfiintarii = new DateTime(2020, 26, 4);
        //uint CUI = 3007457;
        //string nrTelefon = "0744254824";
        //string localitate = "Hangzhou";
        //string tara = "China";
        // bool areTVA = true;
        //ulong cifraDeAfaceri = 49040275685;
        //long datorii = 0;
        //ulong incasari = 55045715617;
        static void Main(string[] args)
        {
            Afiseaza();
        }
       static void Afiseaza()
        {
            List<string> Angajati = new List<string>();
            Angajati.Add("Popescu Ion");
            Angajati.Add("Marcu Alina");
            Angajati.Add("Radu Marius");
            for (int i= 0; i < Angajati.Count; i++)
            {
                Console.WriteLine($"{Angajati[i]}");
            }
        }
    }
}
