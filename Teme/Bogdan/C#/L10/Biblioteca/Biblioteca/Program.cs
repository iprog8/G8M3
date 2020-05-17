using System;

namespace Biblioteca
{
    class Program
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
            primaCarte.nume = "Ferma animalelor";
            primaCarte.an = 1945;
            primaCarte.autor = "George Orwell";
            primaCarte.numarPagini = 208;

            Carte aTreiaCarte = new Carte();
            primaCarte.nume = "Simbolul Pierdut";
            primaCarte.an = 2009;
            primaCarte.autor = "Dan Brown";
            primaCarte.numarPagini = 602;
            
            Carte primaCarteCumparata = primulCumparator.Cumpara(primaCarte.nume);
            primulCumparator.Citeste(primaCarte.nume);

            alDoileaCumparator.Cumpara(aTreiaCarte);
            alDoileaCumparator.Citeste(aTreiaCarte);

            alTreileaCumparator.Cumpara(aDouaCarte);
            alTreileaCumparator.Citeste(aDouaCarte);

            Console.ReadKey();
        }

    }
}
