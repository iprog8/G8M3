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
        public double Diametru
        {
            get { return raza * 2; }
            set { Raza = value / 2; }
        }
        public double Raza
        {
            get { return raza; }
            set
            {
                if (value >= 0) raza = value;
            }
        }
        public override double CalculeazaArie()
        {
            Aria =  Math.PI * (Raza * Raza);
            return Aria;
        }
        public override double CalculeazaPerimetru()
        {
            Perimetru = Diametru * Math.PI;
            return Perimetru;
        }

        double aria = 0;
        protected internal override double Aria {
            get { 
                if(aria == 0)
                {
                    return CalculeazaArie();
                }
                else
                {
                    return aria;
                }
            } 
            set => base.Aria = value; 
        }
    }
}
