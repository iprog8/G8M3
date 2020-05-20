using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProprietatiSiFunctiiPart2
{
    class Program
    {
        public static void Main()
        {
            
            Masina focus = new Masina();
            new Masina();
            focus = new Masina();

            if (focus != null)
            {
                focus.Culoare = "Rosu";
                focus.Marca = "Ford Focus";
                focus.SeDeplaseaza(100);
            }

            
            Masina mondeo = new Masina();
            mondeo.Culoare = "Rosu";
            mondeo.Marca = "Ford MOndeo";
            mondeo.SeDeplaseaza(100);
            
        }
    }
}
