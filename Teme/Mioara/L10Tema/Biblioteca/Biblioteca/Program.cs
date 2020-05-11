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
            Carte carte1 = new Carte();
            carte1.nume = "Psihologia Persuasiunii";
            carte1.autor = "Robert P. Cialdini";
            carte1.an = 2008;
            carte1.numarPagini = 189;
            carte1.SeUzeaza();

            Carte carte2 = new Carte();
            carte2.nume = "Psihocibernetica";
            carte2.autor = "Maxwell Maltz";
            carte2.an = 2017;
            carte2.numarPagini = 328;
            carte2.SeUzeaza();


            Cumparator cumparator1 = new Cumparator();
            cumparator1.nume = "Nastasa";
            cumparator1.prenume = "Vlad";
            cumparator1.dataNasterii; //nu stiu care este formaatul ptr dateTime
            cumparator1.codClient = 21;
            cumparator1.Citeste("Psihocibernetica");
            cumparator1.Cumpara("Psihocibernetica");



        
            Cumparator  cumparator2 = new Cumparator();
            cumparator2.nume = "Strat";
            cumparator2.prenume = "Mioara";
            cumparator2.dataNasterii;
            cumparator2.codClient = 16;
            cumparator2.Citeste("Psihologia persuasiunii");
            cumparator2.Cumpara("Psihologia persuasiunii");
            

        }
    }
}
