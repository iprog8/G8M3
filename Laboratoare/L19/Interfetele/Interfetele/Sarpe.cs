using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfetele
{
    class Sarpe : IAnimal
    {
        public Sarpe()
        {
            DenumireSpecie = "Sarpe";
        }
        public string DenumireSpecie { get; set; }

        public void SeDeplaseaza()
        {
            Console.WriteLine($"{DenumireSpecie} se deplaseaza pe uscatsi apa folosind undirea");
        }

        public void SeHraneste()
        {
            Console.WriteLine($"{DenumireSpecie} se hraneste cu vietati mici");
        }

        public void SeInmulteste()
        {
            Console.WriteLine($"{DenumireSpecie} inmulteste vivipar sau ovovivipar");
        }

        public void Vietuieste()
        {
            Console.WriteLine($"{DenumireSpecie} vietuieste pe uscat si in apa");
        }
    }
}
