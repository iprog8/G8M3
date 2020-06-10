using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    public class Muncitor: Angajat
    {
        public Muncitor(string nume, TipContract tipcontract) : base(nume, tipcontract)
        {
            TipContract = TipContract.Determinat3Luni;
        }
    }
}
