using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie2._0
{
    public class Angajat
    {
        public string Nume { get; set; }
        public Sex Sex { get; set; }
        internal protected double Salariu { get; internal set; }
        public bool Munceste()
        {
            return true;
        }
        public double PrimesteSalariu()
        {
            if (Munceste()) Salariu++;
            else Salariu--;
            return Salariu;
        }
    }
    public enum Sex
    {
        Nedefinit,
        Masculin,
        Feminin
    }
}
