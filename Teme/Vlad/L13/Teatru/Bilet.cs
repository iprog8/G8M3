using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Clasa Bilet are urmatoarele proprietati: Piesa, Loc(de la 1 la x), PretBilet, Vandut;

namespace Teatru
{
    public class Bilet
    {
        public Piesa Piesa { get; set; }
        public int Loc { get; set; }
        public int PretBilet { get; set; }
        public bool Vandut;

        public static int NumaraBilete (List<Bilet> listaBileteDisponibile)
        {
            int BileteCreate = 0;
            for (int i=0;i< listaBileteDisponibile.Count; i++)
            {
                BileteCreate++;
            }
            return BileteCreate;
        }
    }
}
