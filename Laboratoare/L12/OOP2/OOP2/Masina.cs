using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Masina
    {
        string marca;
        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }
        public string Marca2 { get; set; }

        string culoare;
        public string Culoare
        {
            get
            {
                return culoare;
            }
            set
            {
                culoare = value;
            }
        }
        public void IntraInParcare(string Numar)
        {
            Console.WriteLine($"Masina care are numarul {Numar} a intrat in parcare");
        }
    }
}
