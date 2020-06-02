using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2._0
{
    public class Bibliotecar : CititorSimplu
    {
        public Bibliotecar(string nume)
        {
            Nume = nume;
        }
        protected internal bool InchideDeschideBiblioteca(Biblioteca biblioteca)
        {
            if (biblioteca.StareBiblioteca == false)
            {
                Console.WriteLine("Biblioteca a fost dechisa si puteti intra");
                return true;
            }
            else if (biblioteca.StareBiblioteca == true)
            {
                Console.WriteLine("Ne pare rau, dar programul bibliotecii s-a terminat si o inchidem");
                return false;
            }
            return true;
        }
        protected internal Abonament CreazaAbonamentSimplu(CititorSimplu cititorSimplu)
        {  
            if(cititorSimplu.Abonament == null)
            {
                Abonament abonamentTemporar = new Abonament(cititorSimplu);
                Console.WriteLine($"{cititorSimplu.Nume} tocmai a creat un abonament simplu");
                return abonamentTemporar;
            }
            Console.WriteLine($"{cititorSimplu.Nume} are deja un abonament si nu mai poate face unul");
            return cititorSimplu.Abonament;
        }
        protected internal Abonament CreeazaAbonamentVip(CititorVip cititorVip)
        {
            if(cititorVip.Abonament == null)
            {
                Abonament abonamentTemporar = new Abonament(cititorVip);
                Console.WriteLine($"{cititorVip.Nume} tocmai a creat un abonament VIP");
                return abonamentTemporar;
            }
            Console.WriteLine($"{cititorVip.Nume} are deja un abonament si nu mai poate face unul");
            return cititorVip.Abonament;
        }
    }
}
