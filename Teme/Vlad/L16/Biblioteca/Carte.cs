using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Carte
    {
        public Carte(string titlu, string autor, uint nrexemplare)
        {
            Titlu = titlu;
            Autor = autor;
            NrExemplare = nrexemplare;
        }
        public string Autor { get; set; }
        public string Titlu { get; set; }
        public uint NrExemplare { get; set; }
    }
}
