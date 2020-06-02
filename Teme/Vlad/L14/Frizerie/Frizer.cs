using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frizerie
{
    public class Frizer
    { 
        public string Nume { get; set; }
        public Tura Tura{ get; set; }
        public List<Programare> ListaProgramari;
        public void Tunde(Client client, Tura Tura)
        {
            //if ()
            Console.WriteLine($"{this.Nume} tunde clientul {client.Nume} pe tura {Tura.tipTura}");
        }
        public List<Programare> Programari()
        {
            return ListaProgramari;
        }
    }   
}
