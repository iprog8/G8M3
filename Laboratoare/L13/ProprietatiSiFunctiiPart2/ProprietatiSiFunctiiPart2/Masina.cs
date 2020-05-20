using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProprietatiSiFunctiiPart2
{
    public class Masina
    {
        public Masina()
        {
            AmCreatOMasina();
            Culoare = "Alb";
            Marca = "Dacia";
            KmBord = 550;
        }

        public string Culoare { get; set; }
        public string Marca { get; set; }
        public int KmBord { get; set; }

        public void SeDeplaseaza(int km)
        {
            KmBord += km;
        }

        public static void Servisare()
        {

        }

        public static int NumarMasini { get; set; }

        public static void AmCreatOMasina()
        {
            NumarMasini++;
            Console.WriteLine($"Avem {NumarMasini} de masini create");
        }
    }
}
