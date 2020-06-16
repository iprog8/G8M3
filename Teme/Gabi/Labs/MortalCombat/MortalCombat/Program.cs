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
            Console.WriteLine("A fost o data ca niciodata o imparatie de poveste. Pe cand oamenii cunosteau legile magiei,");
            Console.WriteLine("razboinicii se indeletniceau cu taina luptei si arcasii isi faceau fala cu iscusinta manuirii sulitelor,");
            Console.WriteLine("se pomeni razboi mare intre clanuri pentru dobandirea suprematiei.");
            Console.WriteLine("Cine va castiga lupta cea apriga ? Magicienii cu vrajile mortale, arcasii cu tolba de sageti sau aprigii razboinici ?");
            ICaracter primulLuptator = AlegeCaracterul(1);
            ICaracter alDoileaLuptator = AlegeCaracterul(2);
            Lupta lupta1 = new Lupta();
            if (lupta1.IntraLuptatori(primulLuptator, alDoileaLuptator))
            {
                lupta1.IncepeLupta();
            }
            Console.ReadKey();
        }
        private static ICaracter AlegeCaracterul(int player)
        {
            string msg0 = "Ce nume vrei ca acesta sa aiba?";
            string msg1 = " Alegeti luptatorul: \n 1.Arcas, \n 2.Razboinic, \n 3.Magician \n";
            Console.WriteLine($"Player {player}:{msg1}");
            ConsoleKeyInfo tastaApasata1 = Console.ReadKey();
            switch (tastaApasata1.Key)
            {
                case ConsoleKey.D1:
                    string nume0 = AlegeNumeCarcater("Arcas", msg0);
                    ICaracter arcas = new Arcas(nume0);
                    return arcas;
                case ConsoleKey.D2:
                    string nume1 = AlegeNumeCarcater("Razboinic",msg0);
                    ICaracter razboinic = new Razboinic(nume1);
                    return razboinic;
                case ConsoleKey.D3:
                    string nume2 = AlegeNumeCarcater("Magician",msg0);
                    ICaracter magician = new Magician(nume2);
                    return magician;
                default:
                    Console.WriteLine("Nu ai apasat o tasta valida");
                    AlegeCaracterul(player);
                    return null;
            }
        }
        private static string AlegeNumeCarcater(string tipCaracter, string msg)
        {
            Console.WriteLine($"Ai ales luptatorul {tipCaracter}");
            Console.WriteLine(msg);
            string nume = Console.ReadLine();
            return nume;
        }
    }
}
