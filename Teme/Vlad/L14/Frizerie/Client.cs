using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frizerie
{
    public class Client
    {
        public string Nume { get; set; }
        public Tura Tura { get; set; }
        public Frizer Frizer { get; set; }

        public int AlegeTura()
        {
            while (true)
            {
                
                Console.WriteLine($"Va rugam alegeti Tura cand doriti programarea  : 1 reprezinta Tura de  {Tura.TipTura.zi} (interval 10-14) iar 2 reprezinta Tura de {Tura.TipTura.seara} (interval 14-18): ");
                ConsoleKeyInfo TuraAleasa = Console.ReadKey();
                int toIntTuraAleasa;
                Console.ReadKey();
                if ((TuraAleasa.KeyChar != '1') && (TuraAleasa.KeyChar != '2'))
                {
                    Console.WriteLine("Optiunea aleasa nu este valida.");
                }
                else if (TuraAleasa.KeyChar == '1')
                {
                    toIntTuraAleasa = Convert.ToInt32(TuraAleasa.KeyChar.ToString());
                    Console.WriteLine($"Clientul {this.Nume} a ales sa se tunda pe tura {Tura.TipTura.zi}");
                    return toIntTuraAleasa;

                }
                else if (TuraAleasa.Key == ConsoleKey.D2)
                {
                    toIntTuraAleasa = Convert.ToInt32(TuraAleasa.KeyChar.ToString());
                    Console.WriteLine($"Clientul {this.Nume} a ales sa se tunda pe tura {Tura.TipTura.seara}");
                    return toIntTuraAleasa;
                }
                else
                {
                    toIntTuraAleasa = -1;
                    return toIntTuraAleasa;
                }
                // Console.WriteLine($"Va rugam alegeti Tura cand doriti programarea  : 1 reprezinta Tura de  {Tura.TipTura.Zi} (interval 10-14) iar 2 reprezinta Tura de {Tura.TipTura.Seara} (interval 14-18): ");

            }
        }
        public string AlegeZiua()
        {

        }
        public int AlegeFrizer()
        {
            return int .. ;
        }
        public void FaceProgramare()
        {
            Console.WriteLine($"{this.Nume} doreste sa isi faca o programare la Frizerie.");
        }
    }
}
