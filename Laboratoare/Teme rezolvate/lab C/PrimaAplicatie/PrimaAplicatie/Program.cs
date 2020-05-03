using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calcule;

namespace PrimaAplicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neata, C#");
            
            Adunare add = new Adunare();
            int suma = add.Calculeaza(5, 7);
            Console.WriteLine(suma);

            Console.ReadKey();
        }
    }
}