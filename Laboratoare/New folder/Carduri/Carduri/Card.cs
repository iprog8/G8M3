using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carduri
{
    public class Card
    {
        public Card(string nume)
        {
            Nume = nume;
            PIN = new Random().Next(1111, 9999).ToString();
            Cod = $"{new Random().Next(11111111, 99999999).ToString()}{new Random().Next(11111111, 99999999).ToString()}";
            DataExpirare = DateTime.Today.AddYears(3);
            Sold = 0;
            MaxContactless = 100;
        }
        public string Nume { get; protected set; }
        protected string PIN { get; set; }
        public string Cod { get; protected set; }
        public DateTime DataExpirare { get; protected set; }
        protected decimal Sold { get; set; }
        public int MaxContactless { get; protected set; }

        public virtual decimal InterogareSold()
        {
            return Sold;
        }
        public bool AlimentareCard(int sumaDepusa)
        {
            if(sumaDepusa > 0)
            {
                Sold += sumaDepusa;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Aceasta functie realizeaza platile in mod normal (prin introducerea cardului in POS).
        /// </summary>
        /// <param name="sumaDePlata">Suma pe care doriti sa o platiti</param>
        /// <param name="pin">Pin-ul de autorizare al platii (cunoscut doar de proprietar)</param>
        /// <returns>Returneaza true daca plata s-a efectuat cu succes, altfel returneaza false.</returns>
        public virtual bool Plateste(int sumaDePlata, string pin)
        {
            if(PIN != pin)
            {
                return false;
            }
            if(sumaDePlata > Sold)
            {
                return false;
            }
            if(sumaDePlata < 1)
            {
                return false;
            }
            Sold = Sold - sumaDePlata;
            return true;
        }

        //overload
        /// <summary>
        /// Aceasta functie realizeaza platile contactless.
        /// </summary>
        /// <param name="sumaDePlata">Suma pe care doriti sa o platiti</param>
        /// <returns>Returneaza true daca plata s-a efectuat cu succes, altfel returneaza false.</returns>
        public bool Plateste(int sumaDePlata)
        {
            if(sumaDePlata > MaxContactless)
            {
                return false;
            }
            if (sumaDePlata > Sold)
            {
                return false;
            }
            if (sumaDePlata < 1)
            {
                return false;
            }
            Sold = Sold - sumaDePlata;
            return true;
        }
    }
}
