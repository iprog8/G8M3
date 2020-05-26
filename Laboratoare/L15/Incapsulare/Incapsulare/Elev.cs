using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulare
{
    public class Elev: Om
    {
        public Elev()
        {

            //proprietatile protected sunt vizibile doar in clasa in care au fost create si in clasele copil ale acestei clase
            PinInterfon = "";
            ProgramulTau = "";

            //proprietatile protected internal sunt vizibile in clasa si in clasele copil si in namespace
            Gratar = "Mititei";

            // proprietatile private sunt vizibile doar in interiorul clasei
            //this.Parola = "123";
            //this.Pin = "1234";

        }
    }
}
