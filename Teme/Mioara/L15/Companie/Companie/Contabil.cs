using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    public class Contabil
    {
        public string FunctiaInFirma {get;}
        internal protected Angajat Angajati { get; set; }
        protected void CalculeazaProfit(double venituri, double cheltuieli)
        {
            double profit = venituri - cheltuieli;
            Console.WriteLine($"Profitul realizat este {profit}");
        }

    }
}
