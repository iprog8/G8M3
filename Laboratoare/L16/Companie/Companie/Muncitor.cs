using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    public class Muncitor: Angajat
    {
        public string Specializare { get; set; }
        protected int Norma { get; set; }

        public bool ExecutaNorma(int norma)
        {
            return true;
        }
    }
}


   
