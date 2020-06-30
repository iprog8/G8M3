using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
   public class SefEchipa: Sef
    {
        public SefEchipa(string nume, TipContract tipcontract) : base(nume, tipcontract)
        {
        }
        public void Concediaza(Muncitor muncitor)
        {
            Console.WriteLine($"Contabilul {muncitor.Nume} a fost concediat de catre contabilul sef {this.Nume}");
        }
        public void Angajeaza(Muncitor muncitor)
        {
            Console.WriteLine($"Contabilul {muncitor.Nume} a fost angajat de catre contabilul sef{this.Nume}");
        }
        public void MaresteSalariul(Muncitor muncitor)
        {
            if (muncitor.OreLucrate < 178 && muncitor.SarciniIndeplinite > 45)
            {
                Console.WriteLine($"Contabilului {muncitor.Nume} i-a fost marit salariul");
   
            }
            else
            {
                Console.WriteLine($"Contabilului {muncitor.Nume} nu i-a fost marit salariul.Trebuie sa indeplineasca mai multe sarcini intr-o luna ");

            }
        }
    }
}
