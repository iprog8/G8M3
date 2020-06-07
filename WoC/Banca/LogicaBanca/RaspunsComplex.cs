using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaBanca
{
    public class RaspunsComplex
    {
        public RaspunsComplex(bool rezultat, string message)
        {
            this.Succes = rezultat;
            this.Mesaj = message;
        }

        public bool Succes { get; set; }
        public string Mesaj { get; set; }

    }
}
