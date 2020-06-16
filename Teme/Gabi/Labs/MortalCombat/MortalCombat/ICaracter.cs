using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    public interface ICaracter
    {
        int NumarAtacuriDate { get; set; }
        string Nume { get; set; }
        int IBasicAtac { get; set; }
        int IPutereSpeciala { get; set; }
        int IViata { get; set; }
        int IAtaca();
        int IFolosestePutereSpeciala();
    }
}
