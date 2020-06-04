using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcAuto
{
    public class Roata
    {
        public Roata(int diametru, int latime, int prezoane)
        {
            Diametru = diametru;
            Latime = latime;
            NumarPrezoane = prezoane;
        }
        public int Diametru { get; set; }
        public int Latime { get; set; }
        public int NumarPrezoane { get; set; }

    }
}
