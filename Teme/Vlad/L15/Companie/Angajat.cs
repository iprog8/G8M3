using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    public class Angajat
    {
        public Angajat(string nume, TipContract tipcontract)
        {
            Nume = nume;
            TipContract = tipcontract;
        }

        public string Nume { get; set; }

        public uint OreLucrate { get; set; }
        internal uint SarciniIndeplinite { get; set; }
        protected double Salariu { get; set; }
        public TipContract TipContract { get; set; }

    }
    public enum TipContract
    {
        Nedeterminat,
        Determinat3Luni,
        Determinat6Luni
    }
       
}
