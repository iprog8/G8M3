using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProprietatiSiFunctiiPart2
{
    class Program
    {
        public static void Main()
        {

            Elev ionel = new Elev("Ionel Popescu", Sex.M);
            ionel.ParticipaLaCurs("mate");
            ionel.Clasa = 5;
            if (ionel.FaceTema(Materie.Bio))
            {
                Console.WriteLine($"Bravo {ionel.Nume}");
            }

            Elev marioara = new Elev("Marioara Ghita", Sex.F);
            marioara.Clasa = 5;
            marioara.ParticipaLaCurs("mate");
            if (marioara.FaceTema(Materie.Bio))
            {
                Console.WriteLine($"Bravo {marioara.Nume}");
            }


            Masina focus = new Masina();
            new Masina();
            focus = new Masina("Ford Focus", "Rosu");

            if (focus != null)
            {
                focus.SeDeplaseaza(100);
            }

            
            Masina mondeo = new Masina("Ford MOndeo", "Rosu");
            mondeo.SeDeplaseaza(100);

            Masina clio = new Masina("Renault", "Gri");
            clio.SeDeplaseaza(59);

            Masina laguna = new Masina("Renault Laguna");
            laguna.SeDeplaseaza(999);

            OperatiiMatematice mate = new OperatiiMatematice();
            int resInt = mate.Adunare(6, 7);
            resInt = mate.Adunare(6, 7, 8);
            double resDbl = mate.Adunare(6.7, 8.9);

            Console.ReadKey();

        }
    }
}
