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
        public uint dataNasterii;// am incercat sa ii pun datetime ca tip de variabila dar m-am pierdut in formaturi de data si am lasat-o momentan asa.
        public uint codClient;

        public void Cumpara(string numeCarte)
        {
            Console.WriteLine($"Cumparatorul {nume} {prenume} cu codul {codClient} a cumparat cartea {numeCarte}");
        }

        public void Citeste(string numeCarte)
        {
            Console.WriteLine($"Cumparatorul {nume} {prenume} cu codul {codClient} citeste cartea {numeCarte}");
        }
    }
}
