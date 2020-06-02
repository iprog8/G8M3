using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class CarteNeimprumutabila:Carte
    {
        public CarteNeimprumutabila()
        {
            NumeCarte = "Putere nemarginita";
            Autor = "Anthony Robbins";
            AnulAparitiei = 2017;
            NrExemplare = 1;
            Editura = "ACT si Politon";
            TipCarte = TipCarte.CarteNeimprumutabila;
        }

        


    }
}

