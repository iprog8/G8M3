using System;
using System.Collections.Generic;

namespace Teatru
{
    class Program
    {
        static void Main(string[] args)
        {
            Piesa piesaTeatru = new Piesa();
            piesaTeatru.Titlu = "La tiganci";
            piesaTeatru.Regizor = "Andrei si Andreea Grosu";
            piesaTeatru.LocuriDisponibile = 20;
            piesaTeatru.TaxaDeAcces = 27.50;

            List<Actor> actorInPiesa = new List<Actor>();
            Actor primulActor = new Actor();
            actorInPiesa.Add(primulActor);
            primulActor.Nume = "Bovnoczki";
            primulActor.Prenume = "Richard";
            primulActor.Rol = "- profesorul Gavrilescu";

            Actor alDoileaActor = new Actor();
            actorInPiesa.Add(alDoileaActor);
            alDoileaActor.Nume = "Pintileasa";
            alDoileaActor.Prenume = "Liviu";
            alDoileaActor.Rol = "- controlorul de bilete";

            Actor alTreileaActor = new Actor();
            actorInPiesa.Add(alTreileaActor);
            alTreileaActor.Nume = "Trofimov";
            alTreileaActor.Prenume = "Mihaela";
            alTreileaActor.Rol = "-matroana";

            Actor alPatruleaActor = new Actor();
            actorInPiesa.Add(alPatruleaActor);
            alPatruleaActor.Nume = "Tilea";
            alPatruleaActor.Prenume = "Florentina";
            alPatruleaActor.Rol = "- tiganca";

            Actor alCincileaActor = new Actor();
            actorInPiesa.Add(alCincileaActor);
            alCincileaActor.Nume = "Gleznea";
            alCincileaActor.Prenume = "Florina";
            alCincileaActor.Rol = "- tiganca";

            Actor alSaseleaActor = new Actor();
            actorInPiesa.Add(alSaseleaActor);
            alSaseleaActor.Nume = "Casian";
            alSaseleaActor.Prenume = "Cristina";
            alSaseleaActor.Rol = "- tiganca";

            Actor alSapteleaActor = new Actor();
            actorInPiesa.Add(alSapteleaActor);
            alSapteleaActor.Nume = "Cotlet";
            alSapteleaActor.Prenume = "Bogdan";
            alSapteleaActor.Rol = "- pata de culoare si normalitate in lumea lui Eliade";

            SaInceapaSpectacolul();


            void SaInceapaSpectacolul()
            {
                Console.WriteLine($"Bine ati venit la piesa de teatru {piesaTeatru.Titlu} regizata de catre {piesaTeatru.Regizor} , cu distributia ...");
                Console.WriteLine();
                for (int i = 0; i < actorInPiesa.Count; i++)
                {
                    Console.WriteLine(actorInPiesa[i].Nume + " " + actorInPiesa[i].Prenume + " " + actorInPiesa[i].Rol);
                }
                Console.WriteLine();
            }

            int bileteGenerate = piesaTeatru.GenereazaBilete(20);

            List<Bilet> bileteAchizitionate = piesaTeatru.VindeBilete(40);
            bileteAchizitionate = piesaTeatru.VindeBilete(10);
            bileteAchizitionate = piesaTeatru.VindeBilete(5);
            bileteAchizitionate = piesaTeatru.VindeBilete(3);
            bileteAchizitionate = piesaTeatru.VindeBilete(5);
            Console.ReadKey();
        }
    }
}
