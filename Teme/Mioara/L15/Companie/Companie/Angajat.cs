using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    public class Angajat
    {
        public string Nume { get; set; }
        public Sectia Sectia { get; set; }

        internal int Salariu { get; }

        public void FinalizeazaPiese (int numar)
        {
            Console.WriteLine($"Angajatul{Nume} a finalizat {numar} piese. ");
            Console.ReadKey();
        }
       

    }


    public enum Sectia
    {
        Nedefinit,
        Productie,
        Management,
        Distributie,
        Contabilitate,

    }

}
