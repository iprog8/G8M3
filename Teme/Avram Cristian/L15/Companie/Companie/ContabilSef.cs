using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    public class ContabilSef:Contabil
    {
        private string Bilant { get; set; }

        public bool ExecutaBilant(int bilant)
        {
            return true;
        }
    }
}
