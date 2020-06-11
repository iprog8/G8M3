using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcaLuiNoe
{
    public class Mamifer : Animal
    {
        public Mamifer(string denumire, Sex sex) : base(denumire, sex)
        {

        }
        public void NascPui()
        {

        }
        public void Alapteaza()
        {

        }

        public override void Respira(string aer)
        {
            Console.WriteLine($"Mamifer respira folosind nasul si plamanii");
        }
    }
}
