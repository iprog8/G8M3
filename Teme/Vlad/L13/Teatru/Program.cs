using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
- Creati un proiect nou Teatru in care creati clasele Piesa si Bilet;
- Clasa Piesa are urmatoarele proprietati: Titlu, Regizor, ListaActori, LocuriDisponibile, TaxaDeAcces, Bilete si functiile GenereazaBilete, VindeBilete;
- Clasa Bilet are urmatoarele proprietati: Piesa, Loc (de la 1 la x), PretBilet, Vandut;
- Creati un obiect de tip Piesa in care proprietatea "LocuriDisponibile" = 20. Folosind functia "GenereazaBilete" pentru fiecare loc disponibil creati un obiect de tip Bilet;
- Prin apelarea functiei VindeBilete puteti vinde unul sau mai multe bilete.
 
- Sa finalizati tema de la lab 13;
- Sa creati la cele doua clase un constructor in care sa setati cate o valoare default pentru proprietati;
- Creati o functie statica in clasa Bilet care sa numere cate obiecte de tip Bilet au fost create.
*/

namespace Teatru
{
    class Program
    {
        static void Main(string[] args)
        {
            Piesa BurghezulGentilom = new Piesa();
            BurghezulGentilom.Titlu = "Burgezul Gentilom";
            BurghezulGentilom.Regizor = "Nae Caranfil";
            BurghezulGentilom.TaxaDeAcces = 80;

            Piesa ONoapteFurtunoasa = new Piesa();
            ONoapteFurtunoasa.Titlu = "O Noapte Furtunoasa";
            ONoapteFurtunoasa.Regizor = "Mihai Manolescu";
            ONoapteFurtunoasa.TaxaDeAcces = 50;

            BurghezulGentilom.GenereazaBilete(30);
            ONoapteFurtunoasa.GenereazaBilete(24);
          
            int  nrBileteCreate = Bilet.NumaraBilete(BurghezulGentilom.listaBileteDisponibile);   /* momentan, acelasi lucru il face si functia GenereazaBilete() */
            Console.WriteLine($"Au fost generate in total {nrBileteCreate} de bilete la toate piesele");

            BurghezulGentilom.VindeBilete(12);
            BurghezulGentilom.VindeBilete(16);
            BurghezulGentilom.VindeBilete(3);

            ONoapteFurtunoasa.VindeBilete(10);
            ONoapteFurtunoasa.VindeBilete(4);
            ONoapteFurtunoasa.VindeBilete(11);

            Console.ReadKey();
            
        }
        
    }
}
