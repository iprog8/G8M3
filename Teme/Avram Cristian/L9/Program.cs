using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functii
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculeazaProfit();
            CalculeazaPierderi();
            Incaseaza(12345.5);
            Plateste(123.4);
            Console.ReadKey();
        }

        static double investitie = 2100000.5;
        static double incasare = 1000000.3;
        static double balanta = incasare - investitie;
        static double datorii = 300000.4;
        



        static double CalculeazaProfit()
        {
           if (balanta<0)
                Console.WriteLine($"Firma inregistreaza un profit in valoare de {balanta}");
            return balanta;
        }



        static double CalculeazaPierderi()
        {
            if (balanta>0)
                Console.WriteLine($"Firma inregistreaza pierderi in valoare de -{balanta}");
            return balanta;
        }


        static void Incaseaza(double primaIncasare)
        {
            incasare += primaIncasare;
            Console.WriteLine($"Firma inregistreaza incasari curente in valoare de {incasare}");
            
        }



        static double Plateste(double parteDatorie)
        {
            datorii -=parteDatorie;

            Console.WriteLine($"Firma inregistreaza datorii curente in cuantum de {datorii}");
            return datorii;
        }

    }
}
