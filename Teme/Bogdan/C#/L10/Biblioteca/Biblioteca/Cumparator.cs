using System;

namespace Biblioteca
{
    public class Cumparator
    {
        public string nume;
        public string prenume;
        public DateTime dataNasterii;
        public string codClient;

        public void Cumpara(Carte carte)
        {
            if (carte == null)
            {
                Console.WriteLine($"Clientul nu a cumparat nicio carte");
            }
            else
            {
                Console.WriteLine($"Clientul a cumparat cartea {carte}");
            }
        }
        public bool Citeste(Carte carte)
        {
            if (carte != null)
            {
                Console.WriteLine($"Clientul {nume} {prenume} a cumparat cartea {carte}. S-a apucat de citit? /n 1. Da /n 2.Nu");
                ConsoleKeyInfo tastaApasata = Console.ReadKey();
                if (tastaApasata.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Ne bucuram ca te-am ajutat sa gasesti o carte pe gustul tau !");
                    return true;
                }
                else
                {
                    Console.WriteLine("Nu-i timpul pierdut, te asteptam si cu alte sugestii de carti !");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"Clientul {nume} {prenume} nu a cumparat carti.");
                return false;
            }
        }

    }
}