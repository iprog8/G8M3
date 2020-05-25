using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frizerie
{
    public class Programare
    {
        Programare()
        {
            TimpPentruTuns = 30;
        }
        uint TimpPentruTuns { get; set; } //In minute
        Client Client { get; set; }
        DateTime DataProgramarii { get; set; }
        Frizer Frizer { get; set; }
    }
}
