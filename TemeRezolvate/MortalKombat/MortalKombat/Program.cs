using MortalKombat.GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat
{
    class Program
    {
        static void Main(string[] args)
        {
            ILuptator mag1 = new Magician("Gigi");
            ILuptator mag2 = new Razboinic("Zizi");

            Arcas magg = new Arcas("zzzz");
            magg.Test(mag2);

            ILupta lupta = new Lupta1vs1(mag1, mag2);
            ILuptator castigator = lupta.Desfasurare();
            Console.WriteLine($"Meciul a fost castigat de {castigator.Rasa} {castigator.Nume}");

            ILupta turnament = new Turnament(mag1, mag2, mag1, mag2);
            ILuptator castigatorturnament = turnament.Desfasurare();
            Console.WriteLine($"Meciul a fost castigat de {castigatorturnament.Rasa} {castigatorturnament.Nume}");

            ILupta turnament16 = new Turnament(new List<ILuptator>(), TipTurnament.Luptatori16);
            ILuptator castigatorturnament16 = turnament16.Desfasurare();
            Console.WriteLine($"Meciul a fost castigat de {castigatorturnament16.Rasa} {castigatorturnament16.Nume}");

        }
    }
}
