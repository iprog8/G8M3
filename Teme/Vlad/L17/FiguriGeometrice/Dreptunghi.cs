using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    class Dreptunghi:FiguraGeometrica
    {
        public Dreptunghi(double lungime,double latime)
        {
            Lungime = lungime;
            Latime = latime;
        }
        public double Lungime { get; set; }
        public double Latime { get; set; }
        public double Perimetru { get; set; }
        public double Arie { get; set; }
        public override double CalculeazaPerimetru()
        {
            Perimetru = 2 *this.Latime + 2*this.Lungime;
            return Perimetru;
        }
        public override double CalculeazaAria()
        {
            Arie = Lungime * Latime;
            return Arie;
        }
    }
}
