using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Masina m1 = new Masina();
            m1 = null;

            //m1.Culoare = "Alb";
            //m1.Marca = "Dacia";
            m1.IntraInParcare("1");
            Console.WriteLine($"Aceasta masina este marca {m1.Marca} si are culoarea {m1.Culoare}. ");

            Console.ReadKey();
        }


    }
}
