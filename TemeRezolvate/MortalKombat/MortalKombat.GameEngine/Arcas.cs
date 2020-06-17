using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat.GameEngine
{
    public class Arcas : Luptator, ILuptator
    {
        public Arcas(string nume): base(nume)
        {
            Viata = 170;
            Damage = 5;
            Rasa = "Arcas";
            RazaAtac = 10;
        }

        public override double Ataca(ILuptator inamic)
        {
            double damage = Damage * (1 + (new Random().NextDouble() * 4 - 2) / 10);
            return inamic.Lovit(damage);
        }

        public void Test(ILuptator inamic)
        {
            this.Ataca(inamic);
            base.Ataca(inamic);
        }
    }
}
