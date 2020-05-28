using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class SefEchipa:Muncitor
    {
        public void OrganizeazaMuncitori()
        {
            Console.WriteLine($"{Nume} organizeaza echipa de muncitori.");//desi nu am scris proprietatea "Nume", aceasta a fost mostenita.
        }
    }
}
