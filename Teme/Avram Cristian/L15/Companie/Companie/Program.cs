using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabil contabil1 = new Contabil();
            contabil1.Sex = Sex.F;
            contabil1.Nume = "Alina Dumitrescu";
            contabil1.Munceste();
            contabil1.ExecutaBalanta("ianuarie2020");
            //contabil1.ExecutaBilant(2019); Metoda nu poate fi accesata deoarece implica o proprietate "private"
            //contabil1.ExecutaNorma(100); Metoda nu poate fi accesata deoarece chiar daca este publica are un parametru protected si clasa in care a fost scrisa nu are o relatie de mostenire cu clasa care a facut obiectul contabil1.

            ContabilSef contabilSef = new ContabilSef();
            contabilSef.Nume = "Gheorgita Stefanescu";
            contabilSef.Munceste();
            contabilSef.ExecutaBalanta("februarie2020");//Executa metoda din clasa mostenita.
            contabilSef.ExecutaBilant(2019);

            Muncitor muncitor1 = new Muncitor();
            muncitor1.Nume = "Virgil Vasilescu";
            muncitor1.Specializare = "zidar";
            muncitor1.Munceste();
            //muncitor1.Salariu = 2440.1; salariul nu poate fi setat deoarece am pus "protected" pe set.
            muncitor1.ExecutaNorma(200);

            SefEchipa sefEchipa = new SefEchipa();
            sefEchipa.Nume = "Dragos Andreescu";
            sefEchipa.ExecutaNorma(300);
            sefEchipa.OrganizeazaMuncitori();
            contabilSef.IeseDinFirma();
            //sefEchipa.ExecutaBilant(); metoda nu poate fi accesata pentru ca este dintr-o clasa care nu are o relatie vizibila cu clasa ce a creat "sefEchipa".


              Console.ReadKey();
        }
        
    }
}
