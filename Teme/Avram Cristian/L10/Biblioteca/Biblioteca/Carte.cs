using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carte
    {
        public string numeCarte;
        public string autor;
        public uint an; // am incercat sa ii pun datetime ca tip de variabila dar m-am pierdut in formaturi de data si am lasat-o momentan asa.
        public uint numarPagini;

        public bool SeUzeaza(int codClient)
        {
            Console.WriteLine($"Cartea cu titlul {numeCarte} este utilizata de catre cumparatorul cu codul {codClient}");
            return true;
        }
    }
}
