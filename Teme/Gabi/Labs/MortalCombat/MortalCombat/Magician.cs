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
            IBasicAtac = 6;
            Nume = nume;
            puteriSpeciale = new List<string>() 
            { 
                "MingeDeFoc",
                "Fulger",
                "Otrava"
            };
        }
        private int putereSpeciala;
        public List<string> puteriSpeciale { get; set; }
        //private int putereSpeciala;
        public override int IBasicAtac { get; set; }
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
            }
        }
        public override int IAtaca()
        {
                return IBasicAtac;
        }
        public override int IFolosestePutereSpeciala()//puterea speciala a magicianului este 
        {
            Console.WriteLine($"Magicianul a folosit puterea speciala Minge de Foc");
            //IPutereSpeciala = IBasicAtac * 3;
            return IPutereSpeciala;
        }
    }
}
