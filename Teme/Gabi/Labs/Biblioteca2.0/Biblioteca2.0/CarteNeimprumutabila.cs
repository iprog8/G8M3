using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2._0
{
    public class CarteNeimprumutabila : Carte  //(care poate fi studiata doar in sala de lectura)
    {
        public CarteNeimprumutabila(string titlu, string autor, uint numarPagini, string editura, DateTime dataLansarii)
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
