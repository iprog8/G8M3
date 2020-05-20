using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Teatru
{
    public class Bilet
    {
        public Bilet()
        {
            Loc = 1;
            PretBilet = 12.4;
            Vandut = false;
        }
        public Piesa Piesa { get; set; }
        public int Loc { get; set; }
        public double PretBilet { get; set; }
        public bool Vandut { get; set; }
        public static int NumarBileteVandute(List<Bilet> bilete)
        {
            int totalBilete = 0;
            for(int i = 0; i < bilete.Count; i++)
            {
                totalBilete -= -1;
            }
            return totalBilete;
        }
    }
}
