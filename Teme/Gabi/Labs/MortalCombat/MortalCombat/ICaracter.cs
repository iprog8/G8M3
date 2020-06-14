using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
     public interface ICaracter
    {
        string Nume { get; set; }
        int IBasicAtac { get; set; }
        //uint IPutereSpeciala { get; set; }
        int IViata { get; set; }
        int IAtaca();
        void IFolosestePutereSpeciala();
    }
}
