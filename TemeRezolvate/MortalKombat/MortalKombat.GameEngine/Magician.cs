using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat.GameEngine
{
    public class Magician : Luptator, ILuptator
    {
        public Magician(string nume): base(nume, 10)
        {
            Viata = 97;
            Rasa = "Mag";
            RazaAtac = 20;
        }

        public override double Ataca(ILuptator inamic)
        {
            double damage = Damage * (1 + (new Random().NextDouble() * 2 - 1) / 10);
            return inamic.Lovit(damage);
        }
    }
}
