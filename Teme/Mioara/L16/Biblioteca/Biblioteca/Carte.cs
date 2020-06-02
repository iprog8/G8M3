using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Carte
    {
        public Carte()
        {
            NumeCarte = "Manual de NLP";
            Autor = "Joseph O'Connor";
            AnulAparitiei = 2010;
            Editura = "Curtea Veche";
            TipCarte = TipCarte.CarteImprumutabila;
            NrExemplare = 3;
           
        }
        public string NumeCarte { get; set; }
        public string Autor { get; set; }
        public int AnulAparitiei { get; set; }
        public string Editura { get; set; }
        public TipCarte TipCarte { get; set; }
        public int NrExemplare { get; set; }
        public List<CarteImprumutabila> CartiImprumutabile { get; }
        public List<CarteNeimprumutabila> CartiNeimprumutabile { get; }





    }

    public enum TipCarte 
    {
        Nedefinit,
        CarteImprumutabila,
        CarteNeimprumutabila
    }
}
