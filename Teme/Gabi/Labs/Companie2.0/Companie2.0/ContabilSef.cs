using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie2._0
{
    public class ContabilSef:Contabil
    {
        public void Angajeaza(Angajat angajat)
        {
            Console.WriteLine($"{angajat.Nume} a fost angajat");
        }
        public void Concediaza(Angajat angajat)
        {
            Console.WriteLine($"{angajat.Nume} a fost concediat");
        }
    }
}
