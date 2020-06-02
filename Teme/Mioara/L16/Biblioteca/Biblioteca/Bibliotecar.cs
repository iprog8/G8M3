using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Bibliotecar
    {
        public Bibliotecar()
        {
            Nume = "Nastasa Ioana";
            Vechime = 8;
            Sectia = "Copii";



        }
        public string Nume { get; }
        public int Vechime { get; set; }
        public string Sectia { get; }
        public bool ImprumutaCarti(Carte carte)
        { if (carte is CarteImprumutabila)
            {
                Console.WriteLine($"Nu va putemimprumuta aceasta carte.");
                return true;
            }
            else
               
            {
                return false;
            }
        }
        

    }
}
