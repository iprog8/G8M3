using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Clasa Masina sa aiba urmatoarele proprietati(cu get si set ca la ultimul curs): Marca, Culoare, 
Tip(Camion, Autocar, Microbus, Automobil), Numar iar ca functii: IntraInParcare, IeseDinParcare, 
OcupaLoc, ElibereazaLoc; |*/

namespace Parcare
{
    public class Masina
    {
        public string Marca { get; set; }
        //public string Culoare { get; set; }
        public string Tip { get; set; }
        //public string NumarInmatriculare { get; set; }
        //public LocParcare LocOcupat { get; set; }

        public void IntraInParcare()
        {
            Console.WriteLine($"{Tip}ul {Marca} intra in parcare");
        }
        public void IeseDinParcare()
        {
            Console.WriteLine($"{Tip}ul {Marca} iese din parcare");

        }
        public bool OcupaLoc() { return true; }
        /* public bool OcupaLoc(LocParcare locParcare)
         {
             if(locParcare.OcupatDeMasina == null)
             {
                 Console.WriteLine($"Locul de parcare {locParcare.LiteraRand}, {locParcare.Pozitie} este liber");
                 locParcare.OcupatDeMasina = this;
                 Console.WriteLine($"Masina {NumarInmatriculare} a fost parcata ");
                 return true;
             }
             else
             {
                 Console.WriteLine($"Locul de parcare {locParcare.LiteraRand}, {locParcare.Pozitie} este ocupat");
                 return false;
             }
         }*/
    }



}
