using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat.GameEngine
{
    public class Razboinic : Luptator, ILuptator
    {
        public Razboinic(string nume): base()
        {
            Viata = 250;
            Damage = 4;
            Rasa = "Razboinic";
            RazaAtac = 1;
        }

        public override double Ataca(ILuptator inamic)
        {
            double damage = Damage * (1 + (new Random().NextDouble() * 5) / 10);
            return inamic.Lovit(damage);
        }
    }
}
