using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaClasa
{
    public class Cursant
    {
        public string nume;
        public int vasta;

        public void ParticipaLaCurs(string denumireCurs)
        {
            Console.WriteLine($"Cursantul {nume} participa la cursul {denumireCurs}");
        }
    }
}
