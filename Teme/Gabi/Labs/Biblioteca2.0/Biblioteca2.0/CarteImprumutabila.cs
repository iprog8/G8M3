using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2._0
{
    public class CarteImprumutabila: Carte 
    {
        public CarteImprumutabila(string titlu, string autor, uint numarPagini, string editura, DateTime dataLansarii)
        {
            Titlu = titlu;
            Autor = autor;
            NumarPagini = numarPagini;
            Stare = "Noua";
            Editura = editura;
            DataLansarii = dataLansarii;
        }
    }
}
