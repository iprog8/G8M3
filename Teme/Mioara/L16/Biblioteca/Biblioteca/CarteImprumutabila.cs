using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class CarteImprumutabila:CarteNeimprumutabila
    {
        public CarteImprumutabila() 
        {
            NumeCarte = "Biologia credintei";
            Autor = "Bruce Lipton";
            AnulAparitiei = 2017;
            NrExemplare = 1;
            Editura = "For You";
            TipCarte = TipCarte.CarteImprumutabila;
            
            
        }
        protected internal CititorSimplu NumeCititor { get; set; }

        public DateTime DataLaCareDevineDisponibila { get; }
        public bool EsteDisponibila ( bool disponibilitate)

        {
            if
                (disponibilitate == true)

            {
                Console.WriteLine($"Cartea {NumeCarte} scrisa de {Autor}  si aparuta in anul {AnulAparitiei} la editura {Editura} este disponibila.");
                return true;
            }
            else
            {
                Console.WriteLine($"Cartea {NumeCarte} scrisa de {Autor}  si aparuta in anul {AnulAparitiei} la editura {Editura} nu este disponibila.");
                return false;
            }
            
        }
       
        
        

       

    }


    
}
