using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeleObiecte
{
    class Program
    {
        static void Main(string[] args)
        {
            //crearea obiectului ionut folosind clasa Om
            Om ionut = new Om();

            //setarea proprietatilor obiectului ionut
            ionut.Nume = "Ionut Popescu";
            ionut.DataNasterii = new DateTime(1999, 6, 5);
            ionut.Greutate = 76;

            //crearea obiectului maria folosind clasa Om
            Om maria = new Om();

            //setarea proprietatilor obiectului maria
            maria.Nume = "Maria Grigoriu";
            maria.DataNasterii = new DateTime(2000, 6, 8);
            maria.Greutate = 65;

            //folosirea functiilor obiectului ionut
            ionut.Mananca("alune");
            ionut.Merge(50000);

            //folosirea functiilor obiectului maria
            maria.Mananca("prajituri");
            maria.Merge(10000);

            //modificarea proprietatilor obiectului ionut
            ionut.Nume = "Vasile Pop";

            //folosirea functiilor obiectului ionut
            ionut.Mananca("alune");

            Om mihai = new Om();
            mihai.Nume = "Dan Fasola";
            mihai.DataNasterii = new DateTime(1988, 11, 11);
            mihai.Greutate = 88;

            mihai.Mananca("cipsuri");
            mihai.Merge(5000);

            int primulNumar = 11;
            int alDoileaNumar = primulNumar;

            Console.WriteLine($"AlDoileaNumar = {alDoileaNumar}");

            Om gigi = maria;

            Console.WriteLine($"Nume cetatean = {gigi.Nume}");

            gigi.Merge(100000);
        }
    }
}
