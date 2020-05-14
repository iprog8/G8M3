using System;
using System.Collections.Generic;

namespace Companie
{
    class Program
    {
        static string numeCompanie = "AliExpress";
        static ushort numarAngajati = 500;
        static string tipCompanie = "S.A.";
        //static DateTime dataInfiintarii = new DateTime(2020, 26, 4);
        static uint CUI = 3007457;
        static string nrTelefon = "0744254824";
        static string localitate = "Hangzhou";
        static string tara = "China";
        static bool areTVA = true;
        static ulong cifraDeAfaceri = 49040275685;
        static ulong datorii = 500;
        static ulong incasari = 55045715617;
        static ulong profit = 55045715617;
        static void Main(string[] args)
        {
            Afiseaza();
            AfiseazaPare();
            double profitCompanie = CalculeazaProfit();
            double pierderiCompanie = CalculeazaPierderi();
            Incaseaza(300);
            double datoriiDupaPlata = Plateste(250);
        }
        static void Afiseaza()
        {
            List<string> Angajati = new List<string>();
            Angajati.Add("Popescu Ion");
            Angajati.Add("Marcu Alina");
            Angajati.Add("Radu Marius");
            Console.WriteLine("Angajatii in lista sunt:");
            for (int i = 0; i < Angajati.Count; i++)
            {
                Console.WriteLine($"{Angajati[i]}");
            }
        }
        static void AfiseazaPare()
        {
            List<string> Angajati = new List<string>();
            Angajati.Add("Popescu Ion");
            Angajati.Add("Marcu Alina");
            Angajati.Add("Radu Marius");
            Console.WriteLine("Angajatii pe pozitii pare in lista sunt:");
            for (int i = 0; i < Angajati.Count; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"{Angajati[i]}");
            }
        }
        static double CalculeazaProfit()
        {
            ulong calculeazaProfit = incasari - datorii;
            Console.WriteLine($"Profitul inregistrat de catre companie este de {calculeazaProfit} dolari");
            return calculeazaProfit;
        }
        static double CalculeazaPierderi()
        {
            ulong calculeazaPierderi = datorii;
            Console.WriteLine($"Pierderile inregistrate de catre companie sunt de {calculeazaPierderi} dolari");
            return calculeazaPierderi;
        }
        static void Incaseaza(ulong incaseaza)
        {
            incasari += incaseaza;
            Console.WriteLine($"Am incasat suma de {incaseaza} dolari care se adauga la incasarile in suma de {incasari} dolari");
        }
        static double Plateste(ulong plata)
        {
            datorii -= plata;
            Console.WriteLine($"Am platit suma de {plata} dolari in contul de datorii, acestea ajungand la valoare de {datorii} dolari");
            Console.ReadKey();
            return datorii;
        }
    }
}

