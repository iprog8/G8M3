using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie2._0
{
    public class SefEchipa:ContabilSef
    {
        public void CoordoneazaEchipa()
        {
            Console.WriteLine($"Echipa este coordonata de seful de echipa {this.Nume}");
        }
    }
}
