using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class ContabilSef: Sef
    {
        public ContabilSef(string nume, TipContract tipcontract) : base(nume, tipcontract)
        {
        }
        public void Concediaza(Contabil contabil)
        {
            Console.WriteLine($"Contabilul {contabil.Nume} a fost concediat de catre contabilul sef {this.Nume}");
        }
        public void Angajeaza(Contabil contabil)
        {
            Console.WriteLine($"Contabilul {contabil.Nume} a fost angajat de catre contabilul sef{this.Nume}");
        }
        public bool MaresteSalariul(Contabil contabil)
        {
            if (contabil.OreLucrate <178 && contabil.SarciniIndeplinite > 20)
            {
                Console.WriteLine($"Contabilului {contabil.Nume} i-a fost marit salariul");
                return true;
            }
            else
            {
                Console.WriteLine($"Contabilului {contabil.Nume} nu i-a fost marit salariul.Trebuie sa indeplineasca mai multe sarcini intr-o luna ");
                return false;
            }
        }
    }
}
