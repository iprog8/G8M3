using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carte
    {
        public string nume;
        public string autor;
        public DateTime an = new DateTime();
        public uint numarPagini;
        public string statusCarte;
        public string seUzeaza(string statusCarte)
        {
            return statusCarte;
        }
    }
}
