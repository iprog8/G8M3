using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carte
    {
        public string TitluCarte { get; set; }
        public string Autor { get; set; }
        public ushort NumarPagini { get; set; }
        public ushort AnAparitie { get; set; }
        public string Editura { get; set; }
        public enum StareCarte
        {
            Noua,
            Folosita,
            Veche
        }
        public ushort TotalExemplare { get; set; }
        public string Categorie { get; set; }
        public string Sectiune { get; set; }
        public bool Imprumutabila { get; set; }
        public List<Carte> CartiDisponibile { get; set; }

        public Carte(string _titlu, string _autor, ushort _nrPagini, ushort _anAparitie, ushort _totalExemplare, /*List<Carte> _exemplareInBiblioteca,*/
    string _categorie, string _sectiune, string _editura, bool _imprumutabila)
        {
            TitluCarte = _titlu;
            Autor = _autor;
            NumarPagini = _nrPagini;
            AnAparitie = _anAparitie;
            TotalExemplare = _totalExemplare;
            //CartiDisponibile = _exemplareInBiblioteca;
            Categorie = _categorie;
            Sectiune = _sectiune;
            Editura = _editura;
            Imprumutabila = _imprumutabila;
        }
    }
}
