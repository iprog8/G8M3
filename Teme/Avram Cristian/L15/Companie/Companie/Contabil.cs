using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    public class Contabil : Angajat
    {
        public string ProgramLucru { get; set; }
        protected string Balanta { get; set; }


        public bool ExecutaBalanta (string balanta)
        {
            return true;
        }
    }
}
