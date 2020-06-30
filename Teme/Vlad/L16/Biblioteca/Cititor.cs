using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cititor
    {
        public Cititor(string nume)
        {
            Nume = nume;

        }
        protected internal Abonament Abonament { get; set; }
        protected internal string Nume { get; set; }    
        protected internal List<CarteImprumutabila> CartiImprumutate { get; set; }
        protected internal List<CarteNeimprumutabila> CartiNeimprumutabile { get; set; }

        protected internal void ImprumutCarte(CarteImprumutabila Carte)
        {
            Console.WriteLine($"Cititorul {this.Nume} imprumuta cartea {Carte.Titlu}");
            Carte.NrExemplare--;
        }
        protected internal void CitesteCarteSalaLectura(CarteNeimprumutabila Carte)
        {
            Console.WriteLine($"Cititorul {this.Nume} va citi cartea {Carte.Titlu} in sala de lectura");
            Carte.NrExemplare--;
        }
    }
    
}
