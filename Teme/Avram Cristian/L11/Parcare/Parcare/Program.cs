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
            LocParcare parcela1 = new LocParcare();
            parcela1.CuloareArie = "rosie";
            parcela1.LiteraRand = "H";
            parcela1.Pozitie = 2;
            parcela1.TipLoc = "Automobil";

            LocParcare parcela2 = new LocParcare();
            parcela2.CuloareArie = "verde";
            parcela2.LiteraRand = "A";
            parcela2.Pozitie = 3;
            parcela2.TipLoc = "Camion";

            Masina masina1 = new Masina();
            masina1.Numar = "DJ01ABC";
            masina1.Marca = "Logan";
            masina1.Tip = "Automobil";
            masina1.Culoare = "alb";

            Masina masina2 = new Masina();
            masina2.Numar = "B02EFG";
            masina2.Marca = "Scania";
            masina2.Tip = "Camion";
            masina2.Culoare = "neagra";

            Masina masina3 = new Masina();
            masina3.Numar = "AG03RPQ";
            masina3.Marca = "Mercedes";
            masina3.Tip = "Microbus";
            masina3.Culoare = "Albastra";

            

            masina1.IntraInParcare();
            masina1.OcupaLoc(parcela1.LiteraRand, parcela1.Pozitie, parcela1.CuloareArie, parcela1.TipLoc);
            parcela1.OcupatDeMasina(masina1.Numar);

            // la debug, 'Parcare.LocParcare.OcupatDeMasina' imi returneaza false, dupa cum speram si asteptam, dar nu stiu sa ma folosesc de o entitate de tipul asta.
            // as fi vrut sa trec fiecare parcela intr-un status de fals, de fiecare data cand se apeleaza functia OcupatDeMasina in contextul fiecarei parcele
            // ca apoi sa verific cumva status-ul cand vreau sa parchez tot acolo. Daca e true, sa ruleze mai departe, sa parcheze(si sa o treaca in status de false)...iar daca e deja false sa afisez un mesaj.
            // sa pun totul intr-un while status == true, eventual.

            masina2.IntraInParcare();
            masina2.OcupaLoc(parcela2.LiteraRand, parcela2.Pozitie, parcela2.CuloareArie, parcela2.TipLoc);
            parcela1.OcupatDeMasina(masina2.Numar);

            Console.ReadKey();
        }
    }
}
