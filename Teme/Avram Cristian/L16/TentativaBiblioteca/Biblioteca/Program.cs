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
            Carte book1 = new Carte("Solaris", "Stanislaw Lem");
            book1.SeUzeaza();
            book1.SeUzeaza();
            book1.SeUzeaza();
            

            CarteImprumutabila book2 = new CarteImprumutabila("Solaris2", "Stanislaw Lem2");
            book2.SeUzeaza();

            CarteNeimprumutabila book3 = new CarteNeimprumutabila("Solaris3", "Stanislaw Lem3");
            book3.SeUzeaza();

            Bibliotecar bibliotecar1 = new Bibliotecar();
            bibliotecar1.Nume = "Marius";
            CititorSimplu cititors1 = new CititorSimplu();
            cititors1.Nume = "Marcel";
            
            


            Console.ReadKey();

        }

    }
    
}
