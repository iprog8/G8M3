using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class CititorSimplu
    {
        public CititorSimplu()
        {
            Nume = "Ion Aurescu";
            CartiImprumutate = new List<CarteImprumutabila>();
        }

        protected internal string Nume { get; set; }

        protected internal List<CarteImprumutabila> CartiImprumutate { get; set; }
        public void ImprumutaCarte(CarteImprumutabila carteImprumutata)
        {

        }



    }
}
