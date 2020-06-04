using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcaLuiNoe
{
    public class Om: Mamifer
    {
        public Om(Sex sex) : base("Om", sex)
        {

        }
        public Om() : base("Om", Sex.Unknown)
        {

        }
        public override void SeDeplaseaza(int viteza, int timp)
        {
            Console.WriteLine($"{Denumire} merge pe doua picioare cu viteza {viteza} timp de {timp} => {viteza * timp}.");
        }
    }
}
