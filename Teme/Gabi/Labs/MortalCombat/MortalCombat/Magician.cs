using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    public class Magician : Luptator
    {
        public Magician(string nume)
        {
            IViata = 50;
            IBasicAtac = 5;
            Nume = nume;
        }
        public override int IBasicAtac { get; set; }
        //public override uint IPutereSpeciala { get; set; }
        private int viata;
        public override int IViata
        {
            get
            {
                return viata;
            }
            set
            {
                if (value > 0 && value < 51)
                {
                    viata = value;

                }
                else if (value <= 0)
                {
                    viata = 0;

                }
                else
                {
                    viata = 50;
                }
            }
        }
        public override int IAtaca()
        {
            return IBasicAtac;
        }
        public override void IFolosestePutereSpeciala()
        {

        }
    }
}
