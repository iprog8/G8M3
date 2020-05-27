using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frizerie
{
    public class Programare
    {
        public Programare(Client client, DateTime data,Frizer frizer)
        {
            TimpPentruTuns = 30;
            Client = client;
            DataProgramarii = (data < DateTime.Now) ? DateTime.Today : data;
            Frizer = frizer;
        }
        public uint TimpPentruTuns { get; set; } //In minute
        public  Client Client { get; set; }
        public DateTime DataProgramarii { get; set; }
        public Frizer Frizer { get; set; }
    }
}
