using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2._0
{
    public class Carte
    {
        public Carte(string titlu, string autor, uint numarPagini, string editura, DateTime dataLansarii)
        {
            Titlu = titlu;
            Autor = autor;
            NumarPagini = numarPagini;
            Stare = "Noua";
            Editura = editura;
            DataLansarii = dataLansarii;
        }
        public Carte()
        {
            Titlu = "Carte";
            Autor = "OmCunoscut";
            NumarPagini = 120;
            Stare = "Noua";
            Editura = "Art";
            DataLansarii = DateTime.Today;
        }
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public uint NumarPagini { get; set; }
        public string Stare { get; set; }
        public string Editura { get; set; }
        public DateTime DataLansarii { get; set; }
        public string SeUzeaza()
        {
            return "da";
        }
    }
}
