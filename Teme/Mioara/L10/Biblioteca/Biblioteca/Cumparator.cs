using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cumparator
    {
        public string nume;
        public string prenume;
        public DateTime dataNasterii;
        public int codClient;

        public void Citeste(string denumireCarte)
        {
            Console.WriteLine($"Cumparatorul {nume} {prenume} a citit  cartea {denumireCarte}.");
        }
        public void Cumpara(string denumireCarte)
        {
            Console.WriteLine($"Cumparatorul {nume} {prenume} a citit  cartea {denumireCarte}.");
        }


    }
}