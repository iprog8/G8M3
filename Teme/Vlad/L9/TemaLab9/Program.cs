using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 -Creati un proiect nou in C# de tip exe cu numele de Companie;
- In fisierul Program.cs in clasa Program creati urmatoarele variabile: numeCompanie, numarAngajati, tipCompanie, dataInfiintarii, CUI, nrTelefon, localitate, tara, areTVA, cifraDeAfaceri, datorii, incasari;
- In fisierul Program.cs in clasa Program Creati o variabila de tip lista cu lista de angajati si adaugati in ea 2-3 angajati;
- Creati o functie Afiseaza si afisati toti angajatii folosind o structura repetitiva la alegere;
- Apelati functia Afiseaza In functia Main;
- Creati o functie AfiseazaPare in care sa afisati doar angajatii care sunt pe pozitii pare in lista;*/
namespace TemaLab9
{
    class Program
    {
        static string numeCompanie = "WebDev";
        static int numarAngajati = 8;
        static string tipCompanie = "";
        static DateTime dataInfiintarii = new DateTime(2010, 2, 20);
        static string CUI = "J89234832";
        static string nrTelefon = "0720100500";
        static string localitate = "Bucuresti";
        static string tara = "Romania";
        static bool areTVA = true;
        static double cifraDeAfaceri = 250250.50;
        static double datorii = -35000.28;
        static double incasari = 120000.85;
        static string[] listaAngajati = { "Marius", "Sergiu", "Valentina", "Alexandru", "Camelia", "Florentina", "Tiberiu", "Maria" };
        
        static void Main(string[] args)
        {
            Afiseaza();
            AfiseazaPare();
        }
        static void Afiseaza()
        {
            foreach ( string i in listaAngajati)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }
        }
        static void AfiseazaPare() 
        {
            for (int i = 0;  i < listaAngajati.Length; i ++)
            {
                if (i % 2 == 0)
                    {
                        Console.WriteLine(listaAngajati[i]);
                        Console.ReadKey();
                    }
            }
                
        }
        static double CalculeazaProfit()
        {
            double profit = incasari - datorii;
            return profit;
        }

        static void CalculeazaPierderi()
        {

        }
        static void Incaseaza(parametru)
        {

        }
        static void Plateste(parametru2)
        {

        }
    }   
    
        
}
