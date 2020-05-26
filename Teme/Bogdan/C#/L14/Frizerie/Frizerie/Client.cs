using System;

namespace Frizerie
{
    public class Client
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public void IntraInFrizerie(Client client)
        {
            Console.WriteLine($"Clientul {Nume} {Prenume} a intrat in frizerie.");
        }
        public bool OcupaLoc(ScaunFrizerie locPeScaun)
        {
            if (locPeScaun.OcupatDeClient == null)
            {
                Console.WriteLine("Luati loc. Cum vreti sa va tundem? Aveti urmatoarele optiuni:");
                Console.WriteLine("1.Tuns fara spalat.");
                Console.WriteLine("2.Tuns cu spalat si stilizat.");
                Console.WriteLine("3.Tuns barba.");
                ConsoleKeyInfo tastaApasata = Console.ReadKey();
                if (tastaApasata.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Ati ales tuns fara spalat.");
                    return true;
                }
                else if (tastaApasata.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Ati ales tuns, spalat si stilizat.");
                    return true;
                }
                else if (tastaApasata.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("Ati ales tuns barba.");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Ne pare rau dar momentan nu avem locuri disponibile.");
                return false;
            }
            return true;
        }
    }
}
