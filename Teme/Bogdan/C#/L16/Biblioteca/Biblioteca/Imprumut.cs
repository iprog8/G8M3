using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Imprumut : Carte
    {
        public Imprumut(string _titlu, string _autor, ushort _nrPagini, ushort _anAparitie, ushort _totalExemplare, /*List<Carte> _exemplareInBiblioteca,*/
    string _categorie, string _sectiune, string _editura, bool _imprumutabila) : base(_titlu, _autor, _nrPagini, _anAparitie, _totalExemplare,
        /*_exemplareInBiblioteca,*/ _categorie, _sectiune, _editura, _imprumutabila)
        {
        }
        public List<CarteNeimprumutabila> CartiImprumutate { get; set; }
        public List<CarteNeimprumutabila> CartiCititeInBiblioteca { get; set; }
    }
}
