using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat.GameEngine
{
    public interface ILuptator
    {
        double Damage { get; }
        double Viata { get; }
        string Rasa { get; }
        int RazaAtac { get; }
        string Nume { get; }
        double Ataca(ILuptator inamic);
        double Lovit(double damagePrimit);
    }
}
