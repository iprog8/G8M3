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
            IViata = 150;
            IBasicAtac = 10;
            Nume = nume;
        }
        public int ViataAdaugata = 30;
        public override int IBasicAtac { get; set; }
        public override int IViata { get; set; }
        public override int IFolosestePutereSpeciala()
        {
            NumarAtacuriDate++;
            return ViataAdaugata;
        }
    }
}
