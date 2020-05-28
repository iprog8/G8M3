using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie2._0
{
    public class Muncitor:Angajat
    {
        public string Program { get; set; }
        public void VineLaMunca()
        {
            Console.WriteLine($"Muncitorul {this.Nume} a venit la munca");
        }
        public void PleacaDeLaMunca()
        {
            Console.WriteLine($"Muncitorul {this.Nume} a plecat de la munca");
        }
    }
}
