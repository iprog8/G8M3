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
        public uint TimpPentruTuns { get; set; } //In minute
        public  Client Client { get; set; }
        public DateTime DataProgramarii { get; set; }
        public Frizer Frizer { get; set; }
    }
}
