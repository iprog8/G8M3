using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    public class ContabilSef:Contabil
    {
        public ContabilSef()
        {
            Console.WriteLine($"se apeleaza constructorul ${nameof(ContabilSef)}");
            Bilant = "Bilant 2020 S1";
            Salariu = 2999;
        }
        private string Bilant { get; set; }

        public bool ExecutaBilant(int bilant)
        {
            return true;
        }
    }
}
