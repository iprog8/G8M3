using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    class Dreptunghi : FiguraGeometrica
    {
        public Dreptunghi(double lungime, double latime)
        {
            Lungime = lungime;
            Latime = latime;
        }

        public double Lungime { get; set; }
        public double Latime { get; set; }

        public override double CalculeazaArie()
        {
            double aria =  Lungime * Latime;
            return aria;
        }
        public override double CalculeazaPerimetru()
        {
            double perimetru = (Lungime + Latime) * 2;
            return perimetru;
        }
    }
}
