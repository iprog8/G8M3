using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    public abstract class Luptator : ICaracter
    {
        public int NumarAtacuriDate { get; set; }
        public string Nume { get; set; }
        public int IBasicAtac { get; set; }
        public virtual int IPutereSpeciala { get; set; }
        public virtual int IViata { get; set; }
        public int IAtaca()
        {
            NumarAtacuriDate++;
            return IBasicAtac;
        }
        public abstract int IFolosestePutereSpeciala();
    }
}
