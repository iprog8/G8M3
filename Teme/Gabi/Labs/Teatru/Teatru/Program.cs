using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatru
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Piesa Piesa1 = new Piesa();
            Piesa1.GenereazaBilete(12);
            Piesa1.GenereazaBilete(23);
            int numarTotalDeBileteVandute = Bilet.NumarBileteVandute(Piesa1.Bilete);
            Console.WriteLine($"Pentru piesa de teatru {Piesa1.Titlu} regizata de {Piesa1.Regizor} s-au creat un total de {numarTotalDeBileteVandute} bilete");
            Piesa1.VindeBilete(0);
            Piesa1.VindeBilete(13);
            Piesa1.VindeBilete(24);
            Console.ReadKey();
        }
    }
}
