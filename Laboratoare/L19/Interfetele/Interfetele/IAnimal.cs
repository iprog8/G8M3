using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfetele
{
    interface IAnimal
    {
        string DenumireSpecie { get; set; }
        void SeHraneste();
        void SeDeplaseaza();
        void SeInmulteste();
        void Vietuieste();
    }
}
