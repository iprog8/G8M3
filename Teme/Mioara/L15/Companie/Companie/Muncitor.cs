using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    public class Muncitor : Angajat
    {
        public void IncarcaMarfa(string marfa)
        {
            Console.WriteLine($"Muncitorul {Nume} a incarcat {marfa}.");
        }
    

    }
}
