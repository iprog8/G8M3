using System.Collections.Generic;

namespace Teatru
{
    class Program
    {
        static void Main(string[] args)
        {
            Piesa laTiganci = new Piesa();
            laTiganci.Titlu = "La țigănci";
            laTiganci.Regizor = "Andrei și Andreea Grosu";
            laTiganci.LocuriDisponibile = 20;
            laTiganci.TaxaDeAcces = 27.50;

            int bileteGenerate = laTiganci.GenereazaBilete(20);

            List<Bilet> bileteAchizitionate =  laTiganci.VindeBielte(40);
            bileteAchizitionate = laTiganci.VindeBielte(10);
            bileteAchizitionate = laTiganci.VindeBielte(5);
            bileteAchizitionate = laTiganci.VindeBielte(3);
            bileteAchizitionate = laTiganci.VindeBielte(5);

        }
    }
}
