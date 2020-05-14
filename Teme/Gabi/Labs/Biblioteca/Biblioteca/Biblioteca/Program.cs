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
            //prima carte
            Carte primaCarte = new Carte();
            primaCarte.nume = "Inima de Samurai";
            primaCarte.autor = "Margi Preus";
            primaCarte.an = new DateTime(2016, 01, 01);
            primaCarte.numarPagini = 256;
            primaCarte.statusCarte = primaCarte.SeUzeaza("buna");
            //a doua carte
            Carte aDouaCarte = new Carte();
            aDouaCarte.nume = "Linux Bible";
            aDouaCarte.autor = "Christopher Negus";
            aDouaCarte.an = new DateTime(2018, 01, 01);
            aDouaCarte.numarPagini = 860;
            aDouaCarte.statusCarte = aDouaCarte.SeUzeaza("decenta");
            //Cumparatorii
            //Primul cumparator
            Cumparator primulCumparator = new Cumparator();
            primulCumparator.nume = "Ion";
            primulCumparator.prenume = "Popescu";
            primulCumparator.dataNasterii = new DateTime(1999, 02, 03);
            primulCumparator.codClient = 1;
            string carteCumparata = primulCumparator.Cumpara(primaCarte.nume);
            bool carteCitita = primulCumparator.Citeste(false);
            Console.WriteLine($"Cumparatorul cu numele {primulCumparator.nume} {primulCumparator.prenume} a cumparat cartea {carteCumparata}");
            //Al doilea cumparator
            Cumparator alDoileaCumparator = new Cumparator();
            alDoileaCumparator.nume = "Grigore";
            alDoileaCumparator.prenume = "Stefan";
            alDoileaCumparator.dataNasterii = new DateTime(2000, 01, 01);
            alDoileaCumparator.codClient = 2;
            string carteCumparata2 = alDoileaCumparator.Cumpara(aDouaCarte.nume);
            bool aDouaCarteCititie = alDoileaCumparator.Citeste(true);
            Console.WriteLine($"Cumparatorul cu numele {alDoileaCumparator.nume} {alDoileaCumparator.prenume} a cumparat cartea {carteCumparata2}");
            Console.ReadKey();
        }
    }
}
