using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat.GameEngine
{
    public class Turnament : ILupta
    {
        public List<ILuptator> Luptatori { get; private set; }
        public TipTurnament TipTurnament { get; private set; }
        public Turnament(ILuptator luptator1, ILuptator luptator2, ILuptator luptator3, ILuptator luptator4)
        {
            TipTurnament = TipTurnament.Luptatori4;
            Luptatori = new List<ILuptator>();
            Luptatori.Add(luptator1);
            Luptatori.Add(luptator2);
            Luptatori.Add(luptator3);
            Luptatori.Add(luptator4);
        }

        public Turnament(List<ILuptator> listaLuptatori, TipTurnament tipTurnament)
        {
            TipTurnament = tipTurnament;
            switch (tipTurnament)
            {
                case TipTurnament.Luptatori4:
                    if(listaLuptatori.Count != 4)
                    {
                        Console.WriteLine("Numarul de jucatori incorect.");
                    }
                    break;
                case TipTurnament.Luptatori8:
                    if (listaLuptatori.Count != 8)
                    {
                        Console.WriteLine("Numarul de jucatori incorect.");
                    }
                    break;
                case TipTurnament.Luptatori16:
                    if (listaLuptatori.Count != 16)
                    {
                        Console.WriteLine("Numarul de jucatori incorect.");
                    }
                    break;
                case TipTurnament.Luptatori32:
                    if (listaLuptatori.Count != 32)
                    {
                        Console.WriteLine("Numarul de jucatori incorect.");
                    }
                    break;
                default:
                    break;
            }
            Luptatori = listaLuptatori;
        }
        public ILuptator Castigator { get; protected set; }

        public ILuptator Desfasurare()
        {
            throw new NotImplementedException();
        }
    }

    public enum TipTurnament
    {
        Luptatori4,
        Luptatori8,
        Luptatori16,
        Luptatori32
    }
}
