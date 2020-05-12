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
        public void Cumpara(int cartiCumparate)
        {
            Console.WriteLine($"Clientul cu numele {nume},prenumele {prenume} ,nascut in data de {dataNasterii} , avand numarul de client {codClient} a cumparat {cartiCumparate} carti");
        }
        public void Citeste(int cartiCitite)
        {
            Console.WriteLine($"Clientul cu numele {nume},prenumele {prenume} citeste {cartiCitite} carti pe saptamana");

        }
    }
}
