using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaFunctii
{
    class Progra
    {
   
       
        static void Main(string[] args)
        {
            long profitCalculat = CalculeazaProfit();
            
            Console.WriteLine($"Profitul calculat pentru  {valoareIncasari} si {costuri}  este {profitCalculat}.");
            
        }

        static long CalculeazaProfit()
        {
            long valoareIncasari = 257;
            long costuri = 189;
            long profitCalculat = valoareIncasari - costuri;

            return profitCalculat;
        }

        



    }
}
