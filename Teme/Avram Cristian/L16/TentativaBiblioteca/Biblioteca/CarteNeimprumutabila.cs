using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CarteNeimprumutabila : CarteImprumutabila
    {
        public CarteNeimprumutabila(string titlu, string autor)
               : base(titlu, autor)
        {

        }
       
        public bool sePoateImprumuta = false;

    }
 
}    

