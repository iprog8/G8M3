using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    public class Arcas : Luptator
    {
        public Arcas(string nume)
        {
            IViata = 100;
            IBasicAtac = 12;
            Nume = nume;
        }
        private int viata;
        public override int IBasicAtac { get; set; }
        //public override uint IPutereSpeciala { get; set; }
        public override int IViata {
            get
            {
                return viata;
            }
            set
            {
                if (value > 0 && value  < 101)
                {
                    viata = value;
                   
                }
                else if (value <= 0)
                {
                    viata = 0; 

                }
                else
                {
                    viata = 100;
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
