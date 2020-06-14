using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            ICaracter arcas1 = new Arcas("Fanel");
            ICaracter razboinic1 = new Razboinic("Marcel");
            ICaracter magician1 = new Magician("Ion");
            Lupta lupta1 = new Lupta();
            lupta1.IntraLuptatori(arcas1,magician1);
            lupta1.IncepeLupta();
            Console.ReadKey();
        }
    }
}
