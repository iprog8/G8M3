using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    public class Magician : Luptator, ICaracter
    {
        public Magician(string nume)
        {
            IViata = 70;
            IBasicAtac = 12;
            Nume = nume;
        }
        private int putereSpeciala;
        private int viata;
        public override int IPutereSpeciala {
            get
            {
                return IBasicAtac * 3;
            }
            set
            {
                putereSpeciala = value;
            }
        }
        public override int IViata
        {
            get
            {
                return viata;
            }
            set
            {
                if (value > 0 && value < 71)
                {
                    viata = value;
                }
                else if (value <= 0)
                {
                    viata = 0;
                }
            }
        }
        public override int IFolosestePutereSpeciala()
        {
            Console.WriteLine($"Magicianul a folosit puterea speciala Minge de Foc");
            NumarAtacuriDate++;
            return IPutereSpeciala;
        }
    }
}
