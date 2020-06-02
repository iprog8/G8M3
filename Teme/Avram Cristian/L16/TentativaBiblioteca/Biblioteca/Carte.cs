using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carte
    {

        public Carte(string titlu, string autor)
        {
            Titlu = titlu;
            Autor = autor;
        }

        public string Titlu { get; set; }
        public string Autor { get; set; }
        public bool SePoateImprumuta = true;
        public int nivelUzura { get; set; }

        public int SeUzeaza()
        {
            nivelUzura++;

            Console.WriteLine($"Cartea cu titlul {Titlu}, scrisa de catre {Autor} se uzeaza.");
            Console.WriteLine($"Cartea cu titlul {Titlu}, scrisa de catre {Autor} are nivelul de uzura {nivelUzura}.");

            return  nivelUzura;
        }

    }
}
