using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    class Patrat:Dreptunghi
    {
        
        public Patrat(double latura) : base (latura, latura)
        {
            Latura = latura;
        }

        public double Latura {get; set;}

        public override double CalculeazaArie()
        {
            double aria = Latura * Latura;
            return aria;
        }
        public override double CalculeazaPerimetru()
        {
            double perimetru = Latura * 4;
            return perimetru;
        }
    }
}
