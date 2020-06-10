using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    public class Dreptunghi: FiguriGeometrice
    {
        public Dreptunghi(double lungime, double latime)
        {
            Lungime = lungime;
            Latime = latime;
        }
        private double latime;
        private double lungime;
        public double Lungime
        {
            get { return lungime; }
            set
            {
                if(value > latime && value >= 0) lungime = value;
            }
        }
        public double Latime
        {
            get { return latime; }
            set
            {
                if(value < lungime && value >= 0) latime = value;
            }
        }
        public double Diagonala { get; set; }
        public override double CalculeazaArie()
        {
            return Lungime * Latime;
        }
        public override double CalculeazaPerimetru()
        {
            return 2 * (Lungime + Latime);
        }
        public double CalculeazaDiagonala()
        {
            return Math.Sqrt((Lungime * Lungime)+(Latime * Latime));
        }
    }
}
