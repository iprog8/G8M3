using System;

namespace Interfetele
{
    public class Om: IAnimal
    {
        public Om(string nume, string prenume)
        {
            DenumireSpecie = "Om";
            Nume = nume;
            Prenume = prenume;
        }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataNastere { get; set; }

        public string DenumireSpecie { get; set; }

        public void SeDeplaseaza()
        {
            Console.WriteLine($"{DenumireSpecie} {Prenume} {Nume} se deplaseaza pe uscat folosind doua picioare");
        }

        public void SeHraneste()
        {
            Console.WriteLine($"{DenumireSpecie} {Prenume} {Nume} se hraneste omnivor");
        }

        public void SeInmulteste()
        {
            Console.WriteLine($"{DenumireSpecie} {Prenume} {Nume} se inmulteste facnad sex cu placere");
        }

        public void Vietuieste()
        {
            Console.WriteLine($"{DenumireSpecie} {Prenume} {Nume} vietuieste pe sol in case(supraaetajate)");
        }
    }
}