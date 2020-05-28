using System;

namespace Companie
{
    class Muncitor : Angajat
    {
        protected internal string Nume { get; set; }
        protected internal string Prenume { get; set; }
        protected internal string LiniaDeLucru { get; set; }
        protected internal string FunctiaOcupata { get; set; }
        protected internal ushort ProgramDeLucru { get; set; }
        protected internal int OreSuplimentare { get; set; }
        protected internal ushort ZileConcediu { get; set; }
        protected internal void IntraInCompanie(Muncitor muncitor)
        {
            Console.WriteLine($"Muncitorul {muncitor.Nume} {muncitor.Prenume} a intrat in companie.");
        }
        protected internal void IesedinCompanie(Muncitor muncitor)
        {
            Console.WriteLine($"Muncitorul {muncitor.Nume} {muncitor.Prenume} a iesit din companie.");
        }

        protected internal int Munceste(Muncitor muncitor)
        {
            Console.WriteLine($"Cate ore a muncit {muncitor.Nume} {muncitor.Prenume}?");
            ConsoleKeyInfo tastaApasata = Console.ReadKey();
            string oreMuncite = tastaApasata.KeyChar.ToString();
            int oreMunciteInt = int.Parse(oreMuncite);
            int programDeLucru = 8;
            int oreRamaseDinProgram = programDeLucru - oreMunciteInt;
            Console.WriteLine($"Angajatul a muncit {oreMunciteInt} ore");
            if (oreMunciteInt < 8)
            {
                Console.WriteLine($"Angajatul mai are {oreRamaseDinProgram} ore de muncit pentru a termina programul.");
                programDeLucru = oreRamaseDinProgram;
                return oreRamaseDinProgram;
            }
            else if (oreMunciteInt == 8)
            {
                Console.WriteLine("Angajatul si-a terminat programul de munca.");
                return oreRamaseDinProgram;
            }
            else
            {
                Console.WriteLine($"Angajatul a muncit {oreRamaseDinProgram} ore peste program.");
                muncitor.OreSuplimentare = oreMunciteInt - programDeLucru;
                return oreRamaseDinProgram;
            }

        }
    }
}
