using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    public abstract class Luptator : ICaracter
    {
        public Luptator()
        {
            rnd = new Random();
        }
        public Random rnd { get; set; }
        public string Nume { get; set; }
        public virtual int IBasicAtac { get; set; }
        public virtual int IPutereSpeciala { get; set; }
        public virtual int IViata { get; set; }
        public abstract int IAtaca();
        public abstract int IFolosestePutereSpeciala();
    }
}
