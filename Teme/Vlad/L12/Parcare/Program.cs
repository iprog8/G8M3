using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Masinile Dacia si Suzuki trebuie sa iasa din parcare 

namespace Parcare
{
    class Program
    {
        static void Main(string[] args)
        {
      
            List<Masina> ListaMasini = new List<Masina>();
            ListaMasini.Add(new Masina {Marca = "Audi", Tip = "Automobil" });
            ListaMasini.Add(new Masina {Marca = "Mercedes", Tip = "Autocar" });
            ListaMasini.Add(new Masina {Marca = "Iveco", Tip = "Camion" });
            ListaMasini.Add(new Masina {Marca = "Opel", Tip = "Automobil" });
            ListaMasini.Add(new Masina {Marca = "Dacia", Tip = "Automobil" });
            ListaMasini.Add(new Masina {Marca = "Honda", Tip = "Autocar" });
            ListaMasini.Add(new Masina {Marca = "Mitsubishi", Tip = "Microbus" });
            ListaMasini.Add(new Masina { Marca = "Suzuki", Tip = "Autocar" });


            List<LocParcare> ListaLocuriP = new List<LocParcare>();
            ListaLocuriP.Add(new LocParcare { CuloareArie = "Rosie", LiteraRand = "A", Pozitie = 1, TipLoc = "Automobil" });
            ListaLocuriP.Add(new LocParcare { CuloareArie = "Rosie", LiteraRand = "A", Pozitie = 2, TipLoc = "Camion" });
            ListaLocuriP.Add(new LocParcare { CuloareArie = "Rosie", LiteraRand = "A", Pozitie = 3, TipLoc = "Autocar" });
            ListaLocuriP.Add(new LocParcare { CuloareArie = "Galbena", LiteraRand = "B", Pozitie = 1, TipLoc = "Automobil" });
            ListaLocuriP.Add(new LocParcare { CuloareArie = "Galbena", LiteraRand = "B", Pozitie = 2, TipLoc = "Microbus" });
            ListaLocuriP.Add(new LocParcare { CuloareArie = "Galbena", LiteraRand = "B", Pozitie = 3, TipLoc = "Autocar" });

 
            int i, j;
            for (i = 0; i < ListaMasini.Count; i++)
            {
                ListaMasini[i].IntraInParcare();
                for(j=0; j < ListaLocuriP.Count; j++)
                {
                    if (ListaLocuriP[j].OcupatDeMasina != null)
                    {
                        Console.WriteLine($"{ListaMasini[i].Tip}ul {ListaMasini[i].Marca} nu poate  ocupa locul {ListaLocuriP[j].LiteraRand}{ListaLocuriP[j].Pozitie} de tipul {ListaLocuriP[j].TipLoc},acesta este ocupat");

                    }
                    else
                    {
                        if (ListaMasini[i].Tip != ListaLocuriP[j].TipLoc)
                        {
                            Console.WriteLine($"{ListaMasini[i].Tip}ul {ListaMasini[i].Marca} nu poate  ocupa locul {ListaLocuriP[j].LiteraRand}{ListaLocuriP[j].Pozitie} de tipul {ListaLocuriP[j].TipLoc},acesta este de tip diferit");
                        }
                        else
                        {
                            ListaLocuriP[j].OcupatDeMasina = ListaMasini[i];
                            Console.WriteLine($"{ListaMasini[i].Tip}ul {ListaMasini[i].Marca} a ocupat locul {ListaLocuriP[j].LiteraRand}{ListaLocuriP[j].Pozitie} de tipul {ListaLocuriP[j].TipLoc} ");
                            break;
                        }
                    } 
                    if (j == 5)  
                    {
                        ListaMasini[i].IeseDinParcare();
                    }
                } 
            }
            Console.ReadKey();
        }
    }
}
   