using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Masina dacia = new Masina("Dacia", "Gri", 2020, 33333);
            dacia.Motor = new Motor(1400, 72, TipCombustibil.Benzina, "zzz");
            dacia.RoataDeRezerva = new Roata(1234, 123, 4);
            dacia.RoataDreaptaFata = new Roata(1234, 123, 4);
            dacia.RoataDreaptaSpate = new Roata(1234, 123, 4);
            dacia.RoataStangaFata = new Roata(1234, 123, 4);
            dacia.RoataStangaSpate = new Roata(1234, 123, 4);
        }
    }
}
