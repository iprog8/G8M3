using System;

namespace Biblioteca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cumparator primulCumparator = new Cumparator();
            primulCumparator.nume = "Geagu";
            primulCumparator.prenume = "Bogdan";
            primulCumparator.dataNasterii = new DateTime(1993, 9, 7);
            primulCumparator.codClient = "1";

            Cumparator alDoileaCumparator = new Cumparator();
            alDoileaCumparator.nume = "Pirvan";
            alDoileaCumparator.prenume = "Cristiana";
            alDoileaCumparator.dataNasterii = new DateTime(1993, 9, 5);
            alDoileaCumparator.codClient = "2";

            Cumparator alTreileaCumparator = new Cumparator();
            alTreileaCumparator.nume = "Pirvan";
            alTreileaCumparator.prenume = "Corina";
            alTreileaCumparator.dataNasterii = new DateTime(1990, 3, 7);
            alTreileaCumparator.codClient = "3";

            Carte primaCarte = new Carte();
            primaCarte.nume = "1984";
            primaCarte.an = 1949;
            primaCarte.autor = "George Orwell";
            primaCarte.numarPagini = 344;

            Carte aDouaCarte = new Carte();
            aDouaCarte.nume = "Ferma animalelor";
            aDouaCarte.an = 1945;
            aDouaCarte.autor = "George Orwell";
            aDouaCarte.numarPagini = 208;

            Carte aTreiaCarte = new Carte();
            aTreiaCarte.nume = "Simbolul Pierdut";
            aTreiaCarte.an = 2009;
            aTreiaCarte.autor = "Dan Brown";
            aTreiaCarte.numarPagini = 602;

            primulCumparator.Cumpara(primaCarte);
            Console.WriteLine($"{primulCumparator.nume} {primulCumparator.prenume} a cumparat cartea cu titlul {primaCarte.nume}");
            primulCumparator.Citeste(primaCarte);
            Console.WriteLine("\r\n");

            alDoileaCumparator.Cumpara(aTreiaCarte);
            Console.WriteLine($"{alDoileaCumparator.nume} {alDoileaCumparator.prenume} a cumparat cartea cu titlul {aTreiaCarte.nume}");
            alDoileaCumparator.Citeste(aTreiaCarte);
            Console.WriteLine("\r\n");

            alTreileaCumparator.Cumpara(aDouaCarte);
            Console.WriteLine($"{alTreileaCumparator.nume} {alTreileaCumparator.prenume} a cumparat cartea cu titlul {aDouaCarte.nume}");
            alTreileaCumparator.Citeste(aDouaCarte);
            Console.WriteLine("\r\n");

            Console.ReadKey();
        }

    }
}
