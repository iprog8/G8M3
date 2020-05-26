using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenire
{
    class Program
    {
        static void Main(string[] args)
        {
            Om om = new Om();
            om.Nume = "Ion Popa";
            om.DataNastere = new DateTime(1988, 5, 3);
            om.Manca("Mici");
            om.Merge(1000);

            Elev gigel = new Elev();
            gigel.Nume = "Gigel Popa";
            gigel.DataNastere = new DateTime(2000, 11, 11);
            gigel.CodMatricol = "A123";
            gigel.Manca("iaurt");
            gigel.Merge(100);
            gigel.Invata("chimie");
        }
    }
}
