using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2._0
{
    public class Biblioteca
    {
        public Biblioteca(string nume) 
        {
            Nume = nume;
            StareBiblioteca = false;
        }
        public string Nume { get; set; }
        public bool StareBiblioteca { get; set; } //dechisa sau inchisa
        protected internal List<Abonament> Abonamente { get; set; }
        protected internal List<Carte> Carti { get; set; }
        protected internal List<CarteImprumutabila> CartiImprumutabile { get; set; }
        protected internal List<CarteNeimprumutabila> CarteNeimprumutabile { get; set; }
        protected internal List<CititorSimplu> Cititorisimpli { get; set; }
        protected internal List<CititorVip> CititoriVIP { get; set; }
        protected internal List<Bibliotecar> Bibliotecari { get; set; }
        protected internal SalaDeLectura SalaDeLectura { get; set; }
    }
}
