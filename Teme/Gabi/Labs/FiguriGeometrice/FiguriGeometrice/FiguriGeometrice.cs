using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    public abstract class FiguriGeometrice
    {
        protected internal virtual double Aria { get; set; }
        protected internal double Perimetru { get; set; }
        public abstract double CalculeazaArie();
        public abstract double CalculeazaPerimetru();
    }
}
