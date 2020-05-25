using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frizerie
{
    public class Tura
    {
        Tura()
        {
            TimpTura = 120;
        }
        uint TimpTura { get; set; } //in minute
        List<Frizer> Frizeri { get; set; }
    }
}
