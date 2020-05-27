using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class Muncitor : Angajat
    {
        protected internal string Nume { get; set; }
        protected internal string Prenume { get; set; }
        protected internal string LiniaDeLucru { get; set; }
        protected internal ushort ProgramDeLucru { get; set; }
        protected internal string FunctiaOcupata { get; set; }
        protected internal ushort OreSuplimentare { get; set; }
        protected internal ushort ZileConcediu { get; set; }
        protected internal void IntraInCompanie(Muncitor muncitor)
        {
            Console.WriteLine($"Muncitorul {muncitor.Nume} {muncitor.Prenume} a intrat in companie");
        }
        protected internal ushort MuncestePesteProgram(Muncitor muncitor)
        {
            Console.WriteLine($"{muncitor.Nume} {muncitor.Prenume} a muncit o ora peste program");
            muncitor.OreSuplimentare++;
            ushort oreSuplimentare = muncitor.OreSuplimentare;
            return oreSuplimentare;
        }
    }
}
