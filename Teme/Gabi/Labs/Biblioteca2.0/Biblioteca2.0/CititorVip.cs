using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2._0
{
    public class CititorVip : CititorSimplu //(care poate accesa carti neimprumutabile)
    {
        public CititorVip(string nume)
        {
            Nume = nume;   
        }
        protected internal bool EsteInSalaLectura {get;set;}
        protected internal List<CarteNeimprumutabila> CartiDeCititInSalaDeLectura { get; set; }
        public bool IntraIeseDinSalaDeLectura()
        {
            if(EsteInSalaLectura == false)
            {
                Console.WriteLine($"{this.Nume} a intrat in sala de lectura");
                return true;
            }
            else if(EsteInSalaLectura == true)
            {
                if(this.CartiDeCititInSalaDeLectura.Count > 0)
                {
                    Console.WriteLine($"Nu poti parasi sala de lectura pana cand nu inapoiezi cartile");
                    return true;
                }
                Console.WriteLine($"{this.Nume} a iesit din sala de lectura");
                return false;
            }
            return true;
        }
        protected internal string CitesteCarteInSalaDeLectura(CarteNeimprumutabila carteNeimprumutabila)
        {
            if(this.EsteInSalaLectura == false)
            {
                Console.WriteLine("Trebuie sa fii in sala de lectura ca sa poti citi aceasta carte");
                return "";
            }
            else
            {
                this.CartiDeCititInSalaDeLectura.Add(carteNeimprumutabila);
                Console.WriteLine($"{this.Nume} a inceput sa citeasca in sala de lectura");
                return "Folosita";
            }
        }
        protected internal CarteNeimprumutabila InapoiazaCarteaDinSalaDeLectura(CarteNeimprumutabila carteNeimprumutabila)
        {
            if(this.CartiDeCititInSalaDeLectura.Count == 0)
            {
                Console.WriteLine($"Nu ai cum sa inapoiezi carti daca tu nu le ai");
                return null;
            }
            else
            {
                Console.WriteLine($"Ai inapoiat cartea {carteNeimprumutabila.Titlu}");
                return carteNeimprumutabila;
            }
        }
    }
}
