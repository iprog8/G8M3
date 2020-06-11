using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcaLuiNoe
{
    public abstract class Animal
    {
        public Animal(string denumire, Sex sex)
        {
            Denumire = denumire;
            Sex = sex;
        }
        public string Denumire { get; set; }
        public Sex Sex { get; set; }
        public string Specie { get; set; }
        public virtual void SeDeplaseaza(int viteza, int timp)
        {
            Console.WriteLine($"{Denumire} se deplaseaza cu viteza {viteza} timp de {timp} => {viteza*timp}.");
        }
        public void Mananca(string hrana)
        {

        }

        public abstract void Respira(string aer);

        public void Comunica()
        {
            //
            Console.WriteLine($"{Denumire} comunica.");
        }
    }

    public enum Sex
    {
        Unknown, 
        M, 
        F
    }
}
