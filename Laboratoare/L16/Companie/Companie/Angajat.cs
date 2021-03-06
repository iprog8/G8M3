﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    public class Angajat: object
    {
        public Angajat()
        {
            Console.WriteLine($"se apeleaza constructorul ${nameof(Angajat)}");
            Nume = "Ion Ion";
            Sex = Sex.F;
            Salariu = 999;
            PinCard = "1234";
            Departament = Departament.ContabilitateHR;
        }
        internal protected string Nume { get; set; }
        public Sex Sex { get; set; }
        protected double Salariu { get; set; }
        protected string PinCard { get; set; }
        internal protected Departament Departament { get; internal set; }

        internal double AflaSalariu(Contabil contabil)
        {
            return Salariu;
        }

        internal double AflaSalariu(Angajat angajat)
        {
            if (angajat is Contabil || angajat is ContabilSef)
            {
                return Salariu;
            }
            //throw new Exception("Nu poti sa vezi salariul acestei persoane");
            return 0;
        }

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
