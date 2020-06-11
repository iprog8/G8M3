using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    class Cerc: FiguraGeometrica
    {
        

        public Cerc(double raza)
        {
             Raza = raza;
        }

        public double Raza { get; set; }

        public override double CalculeazaArie()
        {
            double aria = 3.14 * Raza * Raza;
            return aria;
        }

        public override double CalculeazaPerimetru()
        {
            double perimetru = 3.14 * Raza * 2;
            return perimetru;
        }
    }
}
