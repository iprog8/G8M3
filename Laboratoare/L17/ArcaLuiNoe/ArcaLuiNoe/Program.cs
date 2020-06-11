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
            //cu clasele abstracte nu se pot crea obiecte in mod direct
            //Animal animal1 = new Animal("animal", Sex.F);

            Om adam = new Om(Sex.M);
            Om eva = new Om(Sex.F);
            Delfin delfin1 = new Delfin(Sex.M);

            Mamifer leoaica = new Mamifer("Leu", Sex.F);

            adam.SeDeplaseaza(5, 1);
            eva.SeDeplaseaza(7, 2);
            delfin1.SeDeplaseaza(10, 2);
            leoaica.SeDeplaseaza(10, 2);

            adam.Respira("aer");
            eva.Respira("aer");
            delfin1.Respira("aer");
            leoaica.Respira("aer");

            adam.Comunica();
            eva.Comunica();
            delfin1.Comunica();
            leoaica.Comunica();

            Console.ReadKey();
        }
    }
}
