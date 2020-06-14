using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    class Cerc : FiguraGeometrica
    {
        public Cerc(double raza)
        {
            Raza = raza;
        }
        public double Raza { get; set; }
        public double Perimetru { get; set;}
        public double Arie { get; set; }
        public override double CalculeazaPerimetru()
        {
            Perimetru = 2 * Math.PI * this.Raza;
            return Perimetru;
        }
        public override double CalculeazaAria()
        {
            Arie = Math.Pow(this.Raza, 2) * Math.PI;
            return Arie;
        }
    }
}
