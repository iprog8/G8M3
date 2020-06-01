using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Bibliotecar
    {
        protected internal string Ecuson { get; set; }
        protected internal string NumeBiblioteca { get; set; }
        protected internal bool EsteDeschisaBiblioteca { get; set; }
        public Bibliotecar(string _ecuson, string _numeBiblioteca, bool _bibliotecaDeschisa)
        {
            Ecuson = _ecuson;
            NumeBiblioteca = _numeBiblioteca;
            EsteDeschisaBiblioteca = _bibliotecaDeschisa;
        }

        protected internal bool IntraInBiblioteca()
        {
            Console.WriteLine($"{Ecuson} a intrat in biblioteca. Biblioteca este deschisa!");
            EsteDeschisaBiblioteca = true;
            return EsteDeschisaBiblioteca;
        }

        protected internal bool IeseDinBiblioteca()
        {
            Console.WriteLine("Biblioteca este inchisa.");
            EsteDeschisaBiblioteca = false;
            return EsteDeschisaBiblioteca;
        }

        protected internal bool AreMembership (CititorSimplu cititor)
        {
            Console.WriteLine("Aveti card de membru?  1.Da    2.Nu");
            ConsoleKeyInfo tastaApasata = Console.ReadKey();
            if(tastaApasata.Key == ConsoleKey.D1)
            {
                Console.WriteLine("In regula, va caut imediat in sistem.");
                return true;
            }
            else
            {
                Console.WriteLine("Nu-l aveti la dumneavoastra? Va caut imediat in sistem.");
                return false;
            }
            
        }
        protected internal void DoritiOCarte(CititorSimplu cititor)
        {
            Console.WriteLine($"Bine ati venit in biblioteca {NumeBiblioteca}. Doriti o carte?");
            Console.ReadKey();
        }
        public bool ImprumutaCartea(Carte carte)
        {
            if (carte.Imprumutabila == true)
            {
                Console.WriteLine($"Puteti imprumuta cartea {carte.TitluCarte}.");
                //CartiDisponibile--;
                carte.TotalExemplare--;

                return true;
            }
            else
            {
                Console.WriteLine($"Cartea {carte.TitluCarte} nu poate fi imprumutata, dar o puteti citi in biblioteca");
                return false;
            }
        }
    }
}
