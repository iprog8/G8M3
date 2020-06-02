using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Bibliotecar
    {
        public string Nume { get; set; }

        public void Imprumuta(CarteImprumutabila carteImprumutabila)
        {
            Console.WriteLine($"......... imprumuta cartea cu titlul {carteImprumutabila.Titlu}"); 

        }
    }


}
