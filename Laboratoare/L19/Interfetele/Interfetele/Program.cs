using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfetele
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nume = new List<string>();
            nume.Add("asdf");

            List<IAnimal> animale = new List<IAnimal>();
            animale.Add(new Om("Gigi", "Gigi"));

            Om adam = new Om("Popescu", "Adam");
            animale.Add(adam);
            adam.SeDeplaseaza();
            adam.SeHraneste();
            adam.SeInmulteste();

            IAnimal ana = new Om("Popescu", "Ana");
            ana.SeDeplaseaza();
            ana.SeHraneste();
            ana.SeInmulteste();
            animale.Add(ana);

            IAnimal anaconda = new Sarpe();
            anaconda.SeDeplaseaza();
            anaconda.SeHraneste();
            anaconda.SeInmulteste();
            animale.Add(anaconda);
        }
    }
}
