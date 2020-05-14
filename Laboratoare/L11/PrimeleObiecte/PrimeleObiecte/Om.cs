using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeleObiecte
{
    
    //Declararea clasei Om
    public class Om
    {

        //Declararea proprietatilor clasei Om
        public string Nume { get; set; }
        public DateTime DataNasterii { get; set; }
        public int Greutate { get; set; }

        //Declararea functiilor/metodelor clasei Om
        public void Merge(int numarPasi)
        {
            Greutate -= (numarPasi / 50000);
            Console.WriteLine($"Omul {Nume} a mers {numarPasi} de pasi.");

        }
        public void Mananca(string felDeMancare)
        {
            Greutate += 1;
            Console.WriteLine($"Omul {Nume} a mancat {felDeMancare} si acum are {Greutate} kg.");
        }
    }
}
