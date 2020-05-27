using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class Angajat
    {
        protected internal string CurriculumVitae { get; private set; }
        protected internal string AngajatAlCompaniei { get; set; }
        protected internal string ContractLocDeMunca { get; private set; }
        protected internal double Salariu { get; private set; }
        protected internal List<ZileLibereLegale> ZileLibereLegale { get; set; }
        protected internal double PrimaDeSarbatori { get; private set; }
        protected internal double BonusuriCompanie { get; private set; }
        protected bool PrelungireContract(Muncitor muncitor)
        {
            Console.WriteLine($"Muncitorului {muncitor.Nume} {muncitor.Prenume} i se termina contractul de munca. I-l prelungim? 1.Da  2.Nu");
            ConsoleKeyInfo tastaApasata = Console.ReadKey();
            if(tastaApasata.Key == ConsoleKey.D1 )
            {
                Console.WriteLine($"Muncitorului {muncitor.Nume} {muncitor.Prenume} i s-a prelungit contractul");
                return true;
            }
            else
            {
                Console.WriteLine($"Muncitorului {muncitor.Nume} {muncitor.Prenume} nu i s-a prelungit contractul");
                return false;
            }
        }
        protected internal double IntroduPrimaDeSarbatori(Muncitor muncitor)
        {
            if ((DateTime.Now.ToString("MMMM dd") == "December 24") || (DateTime.Now.ToString("MMMM dd") == "April 19"))
            {
                Console.WriteLine($"{muncitor.Nume} {muncitor.Prenume} a primit prima de sarbatori.");
                double salariuCuPrima = muncitor.Salariu + muncitor.PrimaDeSarbatori;
                return salariuCuPrima;
            }
            else
            {
                return muncitor.Salariu;
            }
        }

    }
}
