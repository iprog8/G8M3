using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    public class Razboinic :Luptator
    {
        public Razboinic(string nume)
        {
            IViata = 200;
            IBasicAtac = 13;
            Nume = nume;
        }
        public override int IBasicAtac { get; set; }
        //public override uint IPutereSpeciala { get; set; }
        public override int IViata { get; set; }
        public override int IAtaca()
        {
            return IBasicAtac;
        }
        public override void IFolosestePutereSpeciala()
        {
            
        }
    }
}
