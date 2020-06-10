using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FiguriGeometrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //creare obiecte
            Cerc primulCerc = new Cerc(2.12);
            Cerc alDoileaCerc = new Cerc(50);
            Patrat primulPatrat = new Patrat(-12);
            Patrat alDoileaPatrat = new Patrat(6.123);
            Dreptunghi primulDreptunghi = new Dreptunghi(1,12);
            Dreptunghi alDoileaDreptunghi = new Dreptunghi(5.12, 1.45);
            //folosire obiecte
            
            //atribuire de valori obiectelor
            primulCerc.Perimetru = primulCerc.CalculeazaPerimetru();
            primulCerc.Aria = primulCerc.CalculeazaArie();

            alDoileaCerc.Perimetru = alDoileaCerc.CalculeazaPerimetru();
            alDoileaCerc.Aria = alDoileaCerc.CalculeazaArie();

            primulPatrat.Perimetru = primulPatrat.CalculeazaPerimetru();
            primulPatrat.Aria = primulPatrat.CalculeazaArie();
            primulPatrat.Diagonala = primulPatrat.CalculeazaDiagonala();

            alDoileaPatrat.Perimetru = alDoileaPatrat.CalculeazaPerimetru();
            alDoileaPatrat.Aria = alDoileaPatrat.CalculeazaArie();
            alDoileaPatrat.Diagonala = alDoileaPatrat.CalculeazaDiagonala();

            primulDreptunghi.Perimetru = primulDreptunghi.CalculeazaPerimetru();
            primulDreptunghi.Aria = primulDreptunghi.CalculeazaArie();
            primulDreptunghi.Diagonala = primulDreptunghi.CalculeazaDiagonala();

            alDoileaDreptunghi.Perimetru = alDoileaDreptunghi.CalculeazaPerimetru();
            alDoileaDreptunghi.Aria = alDoileaDreptunghi.CalculeazaArie();
            alDoileaDreptunghi.Diagonala = alDoileaDreptunghi.CalculeazaDiagonala();
            //afisare rezultate
            Console.WriteLine($"Perimetrul primului cerc este {primulCerc.Perimetru}, iar aria cercului este {primulCerc.Aria}");
            Console.WriteLine($"Perimetrul celui de al doilea cerc este {alDoileaCerc.Perimetru}, iar aria acestui cerc este {alDoileaCerc.Aria}");

            Console.WriteLine($"Perimetrul primului patrat este {primulPatrat.Perimetru}, iar aria patratului este {primulPatrat.Aria}");
            Console.WriteLine($"Perimetrul celui de al doilea patrat este {alDoileaPatrat.Perimetru}, iar aria acestui patrat este {alDoileaPatrat.Aria}");

            Console.WriteLine($"Perimetrul primului dreptunghi este {primulDreptunghi.Perimetru}, iar aria dreptunghiului este {primulDreptunghi.Aria}");
            Console.WriteLine($"Perimetrul celui de al doilea dreptunghi este {alDoileaDreptunghi.Perimetru}, iar aria acestui dreptunghi este {alDoileaDreptunghi.Aria}");
            
            Console.ReadKey();
        }
    }
}
