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
        public void IntraLuptatori(ICaracter caracter1, ICaracter caracter2)
        {
            Console.WriteLine($"Luptatorii au intrat in arena");
            Luptatori.Add(caracter1);
            Luptatori.Add(caracter2);
        }
        public void IncepeLupta()
        {
            if (Luptatori.Count == 2)
            {
                while (Luptatori[0].IViata > 0 && Luptatori[1].IViata > 0)
                {
                    Luptatori[0].IViata -= Luptatori[1].IAtaca();
                    Console.WriteLine($"{Luptatori[1].Nume} a atacat pe {Luptatori[0].Nume} cu {Luptatori[1].IBasicAtac} damage \n {Luptatori[0].Nume} a ramas cu {Luptatori[0].IViata} viata");
                    if(Luptatori[0].IViata == 0)
                    {
                        break;
                    }   
                    Luptatori[1].IViata -= Luptatori[0].IAtaca();
                    Console.WriteLine($"{Luptatori[0].Nume} a atacat pe {Luptatori[1].Nume} cu {Luptatori[0].IBasicAtac} damage \n {Luptatori[1].Nume} a ramas cu {Luptatori[1].IViata} viata");
                    if (Luptatori[1].IViata == 0)
                    {
                        break;
                    }
                }
            }
            else return;
        }
    }
}
