using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    public class Lupta
    {
        public Lupta()
        {
            Luptatori = new List<ICaracter>();
        }
        public List<ICaracter> Luptatori { get; set; }
        public bool IntraLuptatori(ICaracter caracter1, ICaracter caracter2)
        {
            if (Luptatori.Count == 0)
            {
                Console.WriteLine($"Luptatorii au intrat in arena \n");
                Luptatori.Add(caracter1);
                Luptatori.Add(caracter2);
                return true;            
            }
                Console.WriteLine("Nu pot intra mai mult de 2 luptatori in arena");
                return false;
        }
        public void IncepeLupta()
        {
            if (Luptatori.Count == 0) return;
                while (Luptatori[0].IViata > 0 && Luptatori[1].IViata > 0)// atat timp cat luptatorii sunt in viata, lupta
                {
                    
                    /*Luptatori[0].IViata -= Luptatori[1].IAtaca();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Luptatori[1].Nume} a atacat pe {Luptatori[0].Nume} cu {(Luptatori[1].IBasicAtac)} damage \n {Luptatori[0].Nume} a ramas cu {Luptatori[0].IViata} viata");
                    if (Luptatori[0].IViata == 0)//daca luptatorul care a fost atacat, a murit, opreste
                    {
                        break;
                    }
                    Luptatori[1].IViata -= Luptatori[0].IAtaca();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"{Luptatori[0].Nume} a atacat pe {Luptatori[1].Nume} cu {Luptatori[0].IBasicAtac} damage \n {Luptatori[1].Nume} a ramas cu {Luptatori[1].IViata} viata");
                    if (Luptatori[1].IViata == 0)
                    {
                        break;
                    }*/
                }
                if (Luptatori[0].IViata > 0)
                {
                    Console.ResetColor();
                    Console.WriteLine($"\n {Luptatori[0].Nume} l a invins pe {Luptatori[1].Nume}");
                }
                Luptatori.Clear();
        }
        private static void AtacaNormal(List<ICaracter> luptatori)
        {
            luptatori[1].IViata -= luptatori[0].IAtaca();
        }
        private static void AtacSpecial(List<ICaracter> luptatori)
        {
        }
    }
}
