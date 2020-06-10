using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    public class Sef : Angajat
    {
        public Sef(string nume, TipContract tipcontract):base(nume,tipcontract)
        {
            TipContract = TipContract.Nedeterminat;
        }
    }
}
