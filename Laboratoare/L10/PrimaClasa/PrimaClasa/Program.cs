using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaClasa
{
    class Program
    {
        static void Main(string[] args)
        {
            Cursant primulCursant = new Cursant();
            primulCursant.nume = "Ion";
            primulCursant.vasta = 22;
            primulCursant.ParticipaLaCurs("Modul 1");

            Cursant cursant2 = new Cursant();
            cursant2.nume = "Vasile";
            cursant2.vasta = 33;
            cursant2.ParticipaLaCurs("Modul 2");
        }
    }
}
