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
            IBasicAtac = 9;
            Nume = nume;
        }
        private int ViataAdaugata = 35;
        //public int Armura { get; set; }
        public override int IBasicAtac { get; set; }
        //public override int IPutereSpeciala { get; set; }
        public override int IViata { get; set; }
        public override int IAtaca()
        {
            return IBasicAtac;
        }
        public override int IFolosestePutereSpeciala()//puterea speciala a razboinicului este de isi mari viata
        {
            return ViataAdaugata;
        }
    }
}
