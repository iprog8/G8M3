using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CarteNeimprumutabila : CarteImprumutabila
    {
        public CarteNeimprumutabila(string _titlu, string _autor, ushort _nrPagini, ushort _anAparitie, ushort _totalExemplare, /*List<Carte> _exemplareInBiblioteca,*/
    string _categorie, string _sectiune, string _editura) : base(_titlu, _autor, _nrPagini, _anAparitie, _totalExemplare,
        /*_exemplareInBiblioteca,*/ _categorie, _sectiune, _editura, false)
        {
        }
    }
}
