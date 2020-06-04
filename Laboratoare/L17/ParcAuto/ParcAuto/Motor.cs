using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcAuto
{
    public class Motor
    {
        public Motor(int capacitate, int cai, TipCombustibil tipCombustibil, string ulei)
        {
            Capacitate = capacitate;
            CaiPutere = cai;
            Combustibil = tipCombustibil;
            UleiRecomandat = ulei;
        }
        public int Capacitate { get; set; }
        public int CaiPutere { get; set; }
        public TipCombustibil Combustibil { get; set; }
        public string UleiRecomandat { get; set; }

    }
}
