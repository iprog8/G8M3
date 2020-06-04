using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcaLuiNoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Om adam = new Om(Sex.M);
            Om om2 = new Om();
            Delfin delfin1 = new Delfin(Sex.M);

            Mamifer leoaica = new Mamifer("Leu", Sex.F);

            adam.SeDeplaseaza(5, 1);
            om2.SeDeplaseaza(7, 2);
            delfin1.SeDeplaseaza(10, 2);
            leoaica.SeDeplaseaza(10, 2);

            adam.Comunica();
            om2.Comunica();
            delfin1.Comunica();
            leoaica.Comunica();
        }
    }
}
