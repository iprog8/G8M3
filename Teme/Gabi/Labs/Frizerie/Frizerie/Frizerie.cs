using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frizerie
{
    public class Frizerie
    {
        public Frizerie()
        {
            Nume = "FrizeriaMea";
        }
        public string Nume { get; set; }
        public List<Client> Clienti { get; set; }
        public List<Frizer> Frizeri { get; set; }
        public Tura Tura { get; set; }
    }
}
