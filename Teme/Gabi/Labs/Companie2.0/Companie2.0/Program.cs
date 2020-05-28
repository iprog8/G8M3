using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Angajat angajat1 = new Angajat();
            angajat1.Nume = "Gigel";
            Muncitor muncitor1 = new Muncitor();
            muncitor1.VineLaMunca();
            muncitor1.PrimesteSalariu();
            Console.WriteLine($"Muncitorul {muncitor1.Nume} are salariul de {muncitor1.Salariu}");
            muncitor1.PleacaDeLaMunca();
            ContabilSef contabilSef = new ContabilSef();
            contabilSef.Angajeaza(angajat1);
            SefEchipa sefEchipa = new SefEchipa();
            sefEchipa.CoordoneazaEchipa();
            contabilSef.Concediaza(angajat1);

            Console.ReadKey();
        }
    }
}
