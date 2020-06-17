using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat.GameEngine
{
    public class Luptator : ILuptator
    {
        public Luptator()
        {
            Nume = "Default Name";
        }
        public Luptator(string nume)
        {
            Nume = nume;
        }
        public Luptator(string nume, double damage)
        {
            Nume = nume;
            Damage = damage;
        }
        public double Damage { get; protected set; }
        public string Nume { get; protected set; }
        public double Viata { get; protected set; }
        public string Rasa { get; protected set; }
        public int RazaAtac { get; protected set; }

        public virtual double Ataca(ILuptator inamic)
        {
            return inamic.Lovit(Damage);
        }

        public virtual double Lovit(double damagePrimit)
        {
            //TODO: mecanism de ferit sau parat o parte din damage
            Viata -= damagePrimit;
            return damagePrimit;
        }
    }
}
