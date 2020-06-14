using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    class Patrat:FiguraGeometrica
    {
        public Patrat(double latura)
        {
            Latura = latura;
        }
        public double Latura;
        public double Perimetru { get; set; }
        public double Arie { get; set; }
        public override double CalculeazaPerimetru()
        {
            Perimetru = 4 * this.Latura;
            return Perimetru;
        }
        public override double CalculeazaAria()
        {
            Arie = Math.Pow(Latura, 2);
            return Arie;
        }
    }
}
