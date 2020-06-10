using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class Contabil:Angajat
    {
        public Contabil(string nume, TipContract tipcontract) : base(nume, tipcontract)
        {
            TipContract = TipContract.Determinat6Luni;
        }
    }
}
