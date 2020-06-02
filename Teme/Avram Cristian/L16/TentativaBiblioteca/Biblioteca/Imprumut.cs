using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Imprumut
    {
        public CititorSimplu Statut { get; set; }
        public Carte carteDisponibila { get; set; }
        public Bibliotecar bibliotecarDisponibil { get; set; }
    }
}
