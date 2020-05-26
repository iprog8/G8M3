using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProprietatiSiFunctiiPart2
{
    public class Elev
    {
        public Elev(string nume, Sex sex)
        {
            Nume = nume;
            Sex = sex;
        }
        public string Nume { get; set; }
        public Sex Sex { get; set; }
        public int Clasa { get; set; }
        public string Profil { get; set; }
        public string Scoala { get; set; }
        public DateTime DataNasterii { get; set; }

        public int GetVarsta() { 
            return (int)(DateTime.Today - DataNasterii).TotalDays / 365;
        }

        public void ParticipaLaCurs(string curs)
        {
            //
            Console.WriteLine($"Elevul {Nume} participa la cursul {curs}");
        }

        public bool FaceTema(Materie materie)
        {
            //
            Console.WriteLine($"Elevul {Nume} participa la cursul {materie}");
            return true;
        }
    
    }

    public enum Sex
    {
        Nedefinit,
        M, 
        F
    }

    public enum Materie
    {
        Mate,
        Bio
    }
}
