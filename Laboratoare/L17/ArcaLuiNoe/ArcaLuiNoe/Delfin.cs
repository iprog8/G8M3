using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcaLuiNoe
{
    public class Delfin: Mamifer
    {
        public Delfin(Sex sex) : base("Delfin", sex)
        {

        }
        public override void SeDeplaseaza(int viteza, int timp)
        {
            Console.WriteLine($"{Denumire} inota cu viteza {viteza} timp de {timp} => {viteza * timp}.");
        }
    }
}
