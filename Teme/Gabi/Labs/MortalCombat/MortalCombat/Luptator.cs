using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    public abstract class Luptator : ICaracter
    {
        public string Nume { get; set; }
        public virtual int IBasicAtac { get; set; }
        //public virtual uint IPutereSpeciala { get; set; }
        public virtual int IViata { get; set; }
        public abstract int IAtaca();
        public abstract void IFolosestePutereSpeciala();
    }
}
