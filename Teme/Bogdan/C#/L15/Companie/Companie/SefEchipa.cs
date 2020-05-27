using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class SefEchipa : Muncitor
    {
        protected internal List<Muncitor> Subalterni { get; set; }
        protected bool AprobConcediu(Muncitor zileConcediu)
        {
            if(zileConcediu != null)
            {
                Console.WriteLine($"Se aproba concediul pentru {zileConcediu.Nume} {zileConcediu.Prenume}.");
                return true;
            }
            else
            {
                Console.WriteLine($"{zileConcediu.Nume} {zileConcediu.Prenume} nu mai are zile de concediu.");
                return false;
            }
        }
    }
}
