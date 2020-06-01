using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class CititorVip : CititorSimplu
    {
        public CititorVip(string _nume, string _prenume, ushort _membership, ushort _cartiImprumutate) : base (_nume, _prenume, _membership, _cartiImprumutate)
        {
            Nume = _nume;
            Prenume = _prenume;
            Membership = _membership;
            CartiImprumutate = _cartiImprumutate;
        }
        protected internal ushort UpgradeMembership(CititorSimplu cititor)
        {
            Console.WriteLine("Ati achizitionat abonamentul de membru VIP, felicitari!");
            Console.WriteLine("Acum ai acces nelimitat la toate cartile.");
            Membership = 1;
            return Membership;
        }
    }
}
