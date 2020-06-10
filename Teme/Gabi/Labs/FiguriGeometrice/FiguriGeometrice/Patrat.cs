using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    public class Patrat : FiguriGeometrice
    {
        public Patrat(double laturaPatrat)
        {
            Latura = laturaPatrat;
        }
        private double latura;
        public double Latura
        {
            get { return latura; }
            set
            {
                if(value > 0) latura = value;
            }
        }
        public double Diagonala { get; set; }
        public override double CalculeazaArie()
        {
            return Latura * Latura;
        }
        public override double CalculeazaPerimetru()
        {
            return 4 * Latura;
        }
        public double CalculeazaDiagonala()
        {
            return Latura * Math.Sqrt(2);
        }
    }
}
