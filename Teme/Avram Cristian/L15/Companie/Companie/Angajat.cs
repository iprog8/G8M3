using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    public class Angajat
    {
        internal protected string Nume { get;  set; }
        public Sex Sex { get;  set; }
        internal protected double Salariu { get;  protected set; }
        private string PinCard { get; set; }
        internal protected Departament Departament { get; internal set; }

       
        public void IntraInFirma()
        {
            Console.WriteLine($"Angajatul {Nume} intra in firma.");
        }
        public bool Munceste()
        {
            return true;
        }

        public double IncaseazaSalariu(double Salariu)
        {
            return Salariu;//returneaza quantum cont curent, dupa adaugare salariu
        }

        public void IeseDinFirma()
        {
            Console.WriteLine($"Angajatul {Nume} iese din firma.");
        }

        public string SchimbaPin()
        {
            ///////////////
            return PinCard;
        }
    }
    public enum Sex
    {
        Nedefinit,
        M,
        F
    }
    public enum Departament
    {
        Nedefinit,
        Executii,
        Vanzari,
        ContabilitateHR,
        
    }
}
