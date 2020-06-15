using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MortalCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A fost o data ca niciodata o imparatie de poveste. Pe cand oamenii cunosteau legile magiei, razboinicii se indeletniceau cu taina luptei si arcasii isi faceau fala cu iscusinta manuirii sulitelor, se pomeni razboi mare intre clanuri pentru dobandirea suprematiei." +
"Cine va castiga lupta cea apriga ? Magicienii cu vrajile mortale, arcasii cu tolba de sageti sau aprigii razboinici ?");
            ICaracter primulLuptator = AlegeCaracterul(1);
            ICaracter alDoileaLuptator = AlegeCaracterul(2);
            Lupta lupta1 = new Lupta();
            if (lupta1.IntraLuptatori(primulLuptator, alDoileaLuptator))
            {
                lupta1.IncepeLupta();
            }
            /*int y = 1;
            string player = string.Empty;
            string mag = string.Empty;
            string arc = string.Empty;
            while (y > 0)
            {
                player = "X";
                Thread.Sleep(300);
                Console.Write($"\r. . {player} . . . . {player} . .");
                player = "x";
                Thread.Sleep(300);
                Console.Write($"\r. . {player} . . . . {player} . .");
            }*/
            Console.ReadKey();
        }
        private static ICaracter AlegeCaracterul(int player)
        {
            string msg = " Alegeti luptatorul: \n 1.Arcas, \n 2.Razboinic, \n 3.Magician \n";
            Console.WriteLine($"Player {player}:{msg}");
            ConsoleKeyInfo tastaApasata1 = Console.ReadKey();
            switch (tastaApasata1.Key)
            {
                case ConsoleKey.D1:
                    ICaracter arcas = new Arcas("Robin Hood");
                    Console.WriteLine($"Ai ales luptatorul Arcas");
                    return arcas;
                case ConsoleKey.D2:
                    ICaracter razboinic = new Razboinic("Xerxes");
                    Console.WriteLine("Ai ales luptatorul Razboinic");
                    return razboinic;
                case ConsoleKey.D3:
                    ICaracter magician = new Magician("Veigar");
                    Console.WriteLine("Ai ales luptatorul Magician");
                    return magician;
                default:
                    Console.WriteLine("Nu ai apasat o tasta valida");
                    AlegeCaracterul(player);
                    return null;
            }
        }
    }
}
