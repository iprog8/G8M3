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
            Init("Dacia", "Alb");
        }

        public Masina(string marca)
        {
            Init(marca, "Alb");
        }
        public Masina(string marca, string culoarea)
        {
            Init(marca, culoarea);
        }

        private void Init(string marca, string culoarea)
        {
            AmCreatOMasina();
            Culoare = culoarea;
            Marca = marca;
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

        //Destructor
        ~Masina()
        {
            //dsitruge obiectul

        }
    }
}
