using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcareContinuareCurs
{
    public class LocParcare
    {
        public string CuloareArie { get; set; }
        public string LiteraRand { get; set; }
        public int Pozitie { get; set; }
        public TipMasina TipLoc { get; set; } //camion, autocar, microbus, autoturism
        public Masina OcupatDeMasina { get; set; }
        public static LocParcare GasesteLocParcarePentruMasina(List<LocParcare> locParcare, Masina masina)
        {
            for(int i = 0; i < locParcare.Count; i++)
            {
                if (locParcare[i].OcupatDeMasina == null)
                {
                    Console.WriteLine("S-a gasit loc de parcare liber, se verifica compatibilitatea...");
                    if(locParcare[i].TipLoc == masina.Tip)
                    {
                        Console.WriteLine("S-a gasit un loc de parcare gol compatibil cu tipul masinii tale...");
                        return locParcare[i];
                    }
                    else Console.WriteLine("Nu s-a gasit un loc de parcare compatibil cu tipul masinii tale");
                } 
            }
            Console.WriteLine($"Nu s-au gasit locuri libere de parcare pentru masina cu numarul {masina.Numar}");
            return null;
        }
    }
}
