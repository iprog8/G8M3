using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    public class Cerc : FiguriGeometrice
    {
        public Cerc(double razaCercului)
        {
            Raza = razaCercului;
        }
        private double raza;
        private double diametru;
        public double Diametru
        {
            get { return raza * 2; }
            set { diametru = value; }
        }
        public double Raza {
            get { return raza; }
            set { 
                if (value >= 0) raza = value;
            } 
        }
        public double Pi
        {
            get { return Math.PI; }
            set { Pi = value; }
        }
        public override double CalculeazaArie()
        {
            return Pi * (Raza * Raza);
        }
        public override double CalculeazaPerimetru()
        {
            return Diametru * Pi;
        }
    }
}
