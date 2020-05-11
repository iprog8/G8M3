using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
- Creati o functie fara parametri CalculeazaProfit care sa returneze profitul realizat de companie.
Daca firma realizeaza pierdere, rezultatul returnat va fi un numar negativ;
-Creati o functie fara parametri CalculeazaPierderi care sa returneze pierderile realizate de companie.
Daca firma inregistreaza profit, rezultatul va fi un numar negativ.
-Creati functia Incaseaza cu un parametru si care nu returneaza nimic, care sa adauge la incasari valoarea trimisa ca parametru;
-Creati functia Plateste cu un parametru si care returneaza un numar. Functia scade din datorii valoarea trimisa ca parametru si returneaza cat a mai ramas din datorii.
-Folositi functiile de mai sus in functia Main.;*/


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
        static double investitii = 205345.50;
        static double cheltuieli1 = 15000.28;
        static double incasariCurente = 120000.85;
        static string[] listaAngajati = { "Marius", "Sergiu", "Valentina", "Alexandru", "Camelia", "Florentina", "Tiberiu", "Maria" };
        
        static void Main(string[] args)
        {
            double profitFinal = CalculeazaProfit();
            Console.WriteLine($"Firma a inregistrat un profit de : {profitFinal}");
            Console.ReadKey();
            double pierderiFinale = CalculeazaPierderi();
            Console.WriteLine($"Firma a inregistrat un profit de : {pierderiFinale}");
            Console.ReadKey();
            Incaseaza(10000);
            Console.WriteLine($"Firma a inregistrat o noua incasare in valoare de : {incasariCurente}");
            Console.ReadKey();
            double cheltuieliFinale = Plateste(20000);
            Console.WriteLine($"Firma a inregistrat noi cheltuieli in valoare de  : {cheltuieliFinale}");
            Console.ReadKey();
        }
       
        static double CalculeazaProfit()
        {
            double profit = incasariCurente - cheltuieli1;
            return profit;
        }

        static double CalculeazaPierderi()
        {
            double pierderi = incasariCurente - cheltuieli1 - investitii;
            return pierderi;
        }
        static void Incaseaza(double incasare)
        {
            incasariCurente = incasariCurente + incasare;
        }
        static double Plateste(double cheltuieli2)
        {
          double cheltuieliFinale = cheltuieli1 - cheltuieli2;
          return cheltuieliFinale;
        }
    }   
    
        
}
