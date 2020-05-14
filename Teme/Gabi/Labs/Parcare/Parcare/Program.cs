using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Locurile de Parcare
            LocParcare PrimulLoc = new LocParcare();
            PrimulLoc.CuloareArie = "Verde";
            PrimulLoc.LiteraRand = "A";
            PrimulLoc.Pozitie = 1;
            PrimulLoc.TipLoc = "Camion";
            PrimulLoc.OcupatDeMasina = false;
            //al doilea loc de parcare
            LocParcare AlDoileaLoc = new LocParcare();
            AlDoileaLoc.CuloareArie = "Rosu";
            AlDoileaLoc.LiteraRand = "B";
            AlDoileaLoc.Pozitie = 1;
            AlDoileaLoc.TipLoc = "Camion";
            AlDoileaLoc.OcupatDeMasina = false;
            //Masinile
            Masina PrimaMasina = new Masina();
            PrimaMasina.Marca = "Volvo";
            PrimaMasina.Culoare = "Rosu";
            PrimaMasina.Tip = "Camion";
            PrimaMasina.Numar = "VN-06-JKS";
            //a doua masina
            Masina ADouaMasina = new Masina();
            ADouaMasina.Marca = "Man";
            ADouaMasina.Culoare = "Alba";
            ADouaMasina.Tip = "Camion";
            ADouaMasina.Numar = "VN-02-GHJ";
            //a treia masina
            Masina ATreiaMasina = new Masina();
            ATreiaMasina.Marca = "Mercedes";
            ATreiaMasina.Culoare = "Gri";
            ATreiaMasina.Tip = "Camion";
            ATreiaMasina.Numar = "VN-05-NQM";
            //prima masina intra in parcare
            PrimaMasina.IntraInParcare(PrimaMasina.Numar);
            //a doua masina intra in parcare
            ADouaMasina.IntraInParcare(ADouaMasina.Numar);
            // a treia masina intra in parcare
            ATreiaMasina.IntraInParcare(ATreiaMasina.Numar);

            PrimulLoc.OcupatDeMasina = PrimaMasina.OcupaLoc(PrimaMasina.Numar ,PrimaMasina.Tip, PrimulLoc.TipLoc, PrimulLoc.OcupatDeMasina, PrimulLoc.LiteraRand);

            AlDoileaLoc.OcupatDeMasina = ADouaMasina.OcupaLoc(ADouaMasina.Numar, ADouaMasina.Tip, AlDoileaLoc.TipLoc, AlDoileaLoc.OcupatDeMasina, AlDoileaLoc.LiteraRand);

            PrimulLoc.OcupatDeMasina = ATreiaMasina.OcupaLoc(ATreiaMasina.Numar , ATreiaMasina.Tip, PrimulLoc.TipLoc, PrimulLoc.OcupatDeMasina, PrimulLoc.LiteraRand);

            PrimulLoc.OcupatDeMasina = PrimaMasina.ElibereazaLoc(PrimaMasina.Numar,PrimulLoc.OcupatDeMasina, PrimulLoc.LiteraRand);

            PrimulLoc.OcupatDeMasina = ATreiaMasina.OcupaLoc(ATreiaMasina.Numar, ATreiaMasina.Tip, PrimulLoc.TipLoc, PrimulLoc.OcupatDeMasina, PrimulLoc.LiteraRand);

            PrimaMasina.IeseDinParcare(PrimaMasina.Numar);
            Console.ReadKey();
        }
    }
}
