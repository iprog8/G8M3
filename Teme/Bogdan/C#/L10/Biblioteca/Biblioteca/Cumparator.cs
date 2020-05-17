using System;

namespace Biblioteca
{
    public class Cumparator
    {
        public string nume;
        public string prenume;
        public DateTime dataNasterii;
        public string codClient;

        public bool Cumpara(Carte carte)
        {
            if (carte == null)
            {
                Console.WriteLine($"Clientul nu a cumparat nicio carte");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Citeste(Carte carte)
        {
            if (carte != null)
            {
                Console.WriteLine("S-a apucat de citit?\r\n1.Da\r\n2.Nu");
                ConsoleKeyInfo tastaApasata = Console.ReadKey();
                if (tastaApasata.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Ne bucuram ca te-am ajutat sa gasesti o carte pe gustul tau !");
                    Console.WriteLine("In timp cartea se va uza, dar placerea cititului va ramane nemuritoare!");
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