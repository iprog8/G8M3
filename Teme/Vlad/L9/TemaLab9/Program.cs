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
        //tring numeCompanie = "WebDev";
        //int numarAngajati = 8;
        //string tipCompanie = "";
        //DateTime dataInfiintarii = new DateTime(2010, 2, 20);
        //string CUI = "J89234832";
        //string nrTelefon = "0720100500";
        //string localitate = "Bucuresti";
        //string tara = "Romania";
        //bool areTVA = true;
        //float cifraDeAfaceri = 250250.50F;
        //float datorii = 0;
        //float incasari = 120000.85F;
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

    }
}
