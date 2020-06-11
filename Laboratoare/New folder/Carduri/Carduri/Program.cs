using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carduri
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card("Gigi");
            card1.AlimentareCard(150);
            Console.WriteLine($"PE card aveti {card1.InterogareSold()} lei.");

            CardCredit cardCredit1 = new CardCredit("Zizi", 1000);
            cardCredit1.AlimentareCard(150);
            Console.WriteLine($"PE card credit aveti {cardCredit1.InterogareSold()} lei.");

            bool rezultatPlata = card1.Plateste(80, "0000");
            Console.WriteLine($"Rezultat plata = {rezultatPlata}");
            Console.WriteLine($"PE card aveti {card1.InterogareSold()} lei.");

            rezultatPlata = cardCredit1.Plateste(80, "0000");
            Console.WriteLine($"Rezultat plata = {rezultatPlata}");
            Console.WriteLine($"PE card aveti {cardCredit1.InterogareSold()} lei."); 
            
            rezultatPlata = card1.Plateste(80, "0000");
            Console.WriteLine($"Rezultat plata = {rezultatPlata}");
            Console.WriteLine($"PE card aveti {card1.InterogareSold()} lei.");

            rezultatPlata = cardCredit1.Plateste(80, "0000");
            Console.WriteLine($"Rezultat plata = {rezultatPlata}");
            Console.WriteLine($"PE card aveti {cardCredit1.InterogareSold()} lei.");

            rezultatPlata = cardCredit1.Plateste(1500, "0000");
            Console.WriteLine($"Rezultat plata = {rezultatPlata}");
            Console.WriteLine($"PE card aveti {cardCredit1.InterogareSold()} lei.");

            rezultatPlata = cardCredit1.Plateste(1500, "0000");
            Console.WriteLine($"Rezultat plata = {rezultatPlata}");
            Console.WriteLine($"PE card aveti {cardCredit1.InterogareSold()} lei.");

            Console.ReadKey();
        }
    }
}
