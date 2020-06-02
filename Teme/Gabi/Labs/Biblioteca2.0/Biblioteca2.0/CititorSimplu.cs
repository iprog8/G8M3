using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2._0
{
    public class CititorSimplu
    {
        public CititorSimplu(string nume)
        {
            Nume = nume;
        }
        public CititorSimplu()
        {
            Nume = "Marcel";
        }
        protected internal string Nume { get; set; }
        protected internal List<Carte> CartiImprumutate { get; set; }
        protected internal Abonament Abonament { get; set; }
        protected internal bool EsteInBiblioteca { get; set; }

        public CarteImprumutabila ImprumutaCarte(CarteImprumutabila carte, Biblioteca biblioteca)
        {
            if (this.Abonament != null)
            {
                if (biblioteca.Carti.Contains(carte))
                {
                    biblioteca.Carti.Remove(carte);
                    Console.WriteLine($"{this.Nume} a imprumutat cartea {carte.Titlu} in starea {carte.Stare}");
                    return carte;
                }
                else
                {
                    Console.WriteLine("Ne pare rau, dar cartea pe care o doriti nu este in biblioteca noastra");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Ne pare rau, dar nu aveti un abonament, reveniti cand aveti unul");
                return null;
            }
        }
        public void ReturneazaCarte(Carte carte, Biblioteca biblioteca)
        {

        }
        protected internal bool IntraIeseDinBiblioteca(Biblioteca biblioteca)
        {
            if (biblioteca.StareBiblioteca == true)
            {
                if (EsteInBiblioteca == false)
                {
                    Console.WriteLine($"{this.Nume} a intrat in biblioteca");
                    return true;
                }
                else if (EsteInBiblioteca == true)
                {
                    Console.WriteLine($"{this.Nume} a iesit din biblioteca");
                    return true;
                }
            }
            Console.WriteLine("Nu poti intra in biblioteca deoarece aceasta este inchisa");
            return false;
        }
        public string Citeste(Carte carte)
        {
            Console.WriteLine($"{this.Nume} a inceput sa citeasca cartea {carte.Titlu}");
            return "Folosita";
        }
    }
}
