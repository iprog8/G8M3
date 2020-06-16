using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private string msgBasic = "\n Ce doriti sa faceti? \n 1. Atac Basic";
        private string msgForAtacSpecial = "\n 2. Atac Special";
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
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (Luptatori.Count == 0) return;
                while (Luptatori[0].IViata > 0 && Luptatori[1].IViata > 0)// atat timp cat luptatorii sunt in viata, lupta
                {
                    if(Runda(Luptatori,0, 1,msgBasic, msgForAtacSpecial))
                    {
                        Runda(Luptatori, 1, 0, msgBasic, msgForAtacSpecial);
                    }
                }
                if (Luptatori[0].IViata > 0)
                {
                    AfiseazaCastigator(Luptatori, 0, 1);
                }
                else
                {
                    AfiseazaCastigator(Luptatori, 1, 0);
                }
                Luptatori.Clear();
        }
        private static void AfiseazaCastigator(List<ICaracter> luptatori , int player1, int player2)
        {
            Console.ResetColor();
            Console.Beep();
            Console.WriteLine($"\n{luptatori[player1].Nume} l-a invins pe {luptatori[player2].Nume}");
        }
        private static void AtacaNormal(List<ICaracter> luptatori, int player1, int player2)
        {
            string tastaIncorecta = "Nu ai apasat tasta corecta, mai incearca odata";
            ConsoleKeyInfo tastaApasata = Console.ReadKey();
            switch (tastaApasata.Key)
            {
                case ConsoleKey.D1:
                    luptatori[player2].IViata -= luptatori[player1].IAtaca();
                    Console.WriteLine($"{luptatori[player1].GetType().Name}ul, {luptatori[player1].Nume} l-a atacat pe {luptatori[player2].Nume} cu {luptatori[player1].IBasicAtac} damage");
                    break;
                default:
                    Console.WriteLine(tastaIncorecta);
                    AtacaNormal(luptatori,player1,player2);
                    break;
            }
        }
        private static void AtacSpecial(List<ICaracter> luptatori, int player1, int player2)
        {
            string tastaIncorecta = "Nu ai apasat tasta corecta, mai incearca odata";
            ConsoleKeyInfo tastaApasata = Console.ReadKey();
            switch (tastaApasata.Key)
            {
                case ConsoleKey.D1:
                    luptatori[player2].IViata -= luptatori[player1].IAtaca();
                    Console.WriteLine($"{luptatori[player1].GetType().Name}ul, {luptatori[player1].Nume} l-a atacat pe {luptatori[player2].Nume} cu {luptatori[player1].IBasicAtac} damage");
                    break;
                case ConsoleKey.D2:
                    switch (luptatori[player1].GetType().Name)
                    {
                        case "Arcas":
                            luptatori[player2].IViata -= luptatori[player1].IFolosestePutereSpeciala();
                            Console.WriteLine($"Arcasul a folosit puterea lui speciala pe {luptatori[player2].GetType().Name}ul, {luptatori[player2].Nume} si i-a scazut {luptatori[player1].IPutereSpeciala} damage");
                            break;
                        case "Razboinic":
                            luptatori[player1].IViata += luptatori[player1].IFolosestePutereSpeciala();
                            Console.WriteLine($"Razboinicul a folosit puterea lui speciala pentru a isi regenera viata cu {luptatori[player1].IFolosestePutereSpeciala()} viata");
                            break;
                        case "Magician":
                            luptatori[player2].IViata -= luptatori[player1].IFolosestePutereSpeciala();
                            Console.WriteLine($"Magicianul a folosit puterea lui speciala pentru a isi mari puterea de atac la {luptatori[player1].IPutereSpeciala} damage");
                            break;
                        default:
                            Console.WriteLine(tastaIncorecta);
                            AtacSpecial(luptatori, player1, player2);
                            break;
                    }
                    break;
                default:
                    Console.WriteLine(tastaIncorecta);
                    AtacSpecial(luptatori, player1, player2);
                    break;
            }
        }
        private static bool Runda(List<ICaracter> luptatori ,int player1, int player2, string msg, string msgSpecial)
        {
            if (player1 == 0)
                Console.BackgroundColor = ConsoleColor.Blue;
            else 
                Console.BackgroundColor = ConsoleColor.Green;
            int p1 = player1 + 1;
            int p2 = player2 + 1;
            Console.WriteLine($"Randul playerului {p1}:");
            if (luptatori[player1].NumarAtacuriDate == 0 || luptatori[player1].NumarAtacuriDate % 3 != 0)
            {
                Console.WriteLine($"Player {p1}:" + msg);
                AtacaNormal(luptatori, player1, player2);
            }
            else if (luptatori[player1].NumarAtacuriDate % 3 == 0)
            {
                Console.WriteLine($"Player {p1}:" + msg + msgSpecial);
                AtacSpecial(luptatori, player1, player2);
            }
            Console.WriteLine($"{luptatori[player2].Nume} a ramas in {luptatori[player2].IViata} viata");
            if (luptatori[player2].IViata == 0) return false;
            return true;
        }
    }
}
