using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Cumparator primulCumparator = new Cumparator();
            primulCumparator.nume = "George";
            primulCumparator.prenume = "Georgescu";
            primulCumparator.dataNasterii = new DateTime(1977, 1, 15); //1977;//deocamdata int
            primulCumparator.codClient = 1;
            primulCumparator.Cumpara("Solaris");
            primulCumparator.Citeste("Casa Usher");

            Cumparator alDoileaCumparator = new Cumparator();
            alDoileaCumparator.nume = "Ion";
            alDoileaCumparator.prenume = "Ionescu";
            alDoileaCumparator.dataNasterii = new DateTime(1977, 1, 25);//1977;//deocamdata int
            alDoileaCumparator.codClient = 2;
            alDoileaCumparator.Cumpara("Solaris");
            alDoileaCumparator.Citeste("Casa Usher");
            Console.ReadLine();

            Carte primaCarte = new Carte();
            primaCarte.numeCarte = "Solaris";
            primaCarte.autor = "Stanislaw Lem";
            primaCarte.an = 1970;// deocamdata int
            primaCarte.numarPagini = 204;
            primaCarte.SeUzeaza(primulCumparator.codClient);

            Carte aDouaCarte = new Carte();
            aDouaCarte.numeCarte = "Casa Usher";
            aDouaCarte.autor = "Edgar Allan Poe";
            aDouaCarte.an = 1840;
            aDouaCarte.numarPagini = 155;
            aDouaCarte.SeUzeaza(alDoileaCumparator.codClient);

            Console.ReadKey();
        }
    }
}
