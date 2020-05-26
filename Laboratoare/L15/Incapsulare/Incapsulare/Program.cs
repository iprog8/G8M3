using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulare
{
    class Program
    {
        static void Main(string[] args)
        {
            Om gigel = new Om();
            //proprietatile public sunt vizibile pretutindeni
            gigel.Inaltime = 177;
            int greutateaLuiGigel = gigel.Greutate;
            gigel.AnulNasterii = 1988;

            //proprietatile internal sunt vizibile doar in interiorul namespace-ului
            gigel.Nume = "Gigel";
            gigel.Telefon = "0722222222";

            //proprietatile protected sunt vizibile doar in clasa in care au fost create si in clasele copil ale acestei clase
            //gigel.PinInterfon = "";
            //gigel.ProgramulTau = "";

            //proprietatile protected internal sunt vizibile in clasa si in clasele copil si in namespace
            gigel.Gratar = "Mititei";

            // proprietatile private sunt vizibile doar in interiorul clasei
            //gigel.Parola = "123";
            //gigel.Pin = "1234";

            Elev gigi = new Elev();
        
        }
    }
}
