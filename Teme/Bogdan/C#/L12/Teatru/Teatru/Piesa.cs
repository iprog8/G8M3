using System;
using System.Collections.Generic;

namespace Teatru
{
    public class Piesa
    {
        public string Titlu { get; set; }
        public string Regizor { get; set; }
        public List<Actor> PiesaTeatru { get; set; }
        public int LocuriDisponibile { get; set; }
        public double TaxaDeAcces { get; set; }
        public List<Bilet> Bilete { get; set; }

        public Piesa()
        {
            Titlu = "La tiganci";
            Regizor = "Andrei si Andreea Grosu";
            LocuriDisponibile = 20;
            TaxaDeAcces = 27.50;
        }
        public int GenereazaBilete(ushort bileteGenerate)
        {
            bileteGenerate = 20;
            Bilete = new List<Bilet>();
            Console.WriteLine($"La piesa de teatru {Titlu}  s-au pus in vanzare un nr de {bileteGenerate} bilete");
            for (int i = 0; i < bileteGenerate; i++)
            {
                Bilet biletTmp = new Bilet();
                biletTmp.Loc = i;
                biletTmp.Piesa = this;
                biletTmp.PretBilet = 27.50;
                biletTmp.Vandut = false;
                Bilete.Add(biletTmp);
            }
            return Bilete.Count;
        }
        public List<Bilet> VindeBilete(ushort numarBileteDorite)
        {
            List<Bilet> bileteCumparate = new List<Bilet>();
            if (numarBileteDorite < 1)
            {
                Console.WriteLine("Nu poti cumpara mai putin de 1 bilet.");
                return bileteCumparate;
            }

            if (numarBileteDorite > Bilete.Count)
            {
                Console.WriteLine($"Ati ales sa achizitionati un nr de {numarBileteDorite} bilete");
                Console.WriteLine($"Din pacate dispunem doar de un nr de {Bilete.Count} bilete");
                return bileteCumparate;
            }
            else
            {
                //verifica nr de bilete disponibile
                int bileteBisponibile = 0;
                bileteBisponibile = NumaraBileteDisponibile(bileteBisponibile);
                if (bileteBisponibile < numarBileteDorite)
                {
                    Console.WriteLine($"Ati ales sa achizitionati un nr de {numarBileteDorite} bilete.");
                    Console.WriteLine($"Din pacate dispunem doar de un nr de {bileteBisponibile} bilete");
                    return bileteCumparate;
                }

                // vanzare bilete
                Console.WriteLine($"Ati ales sa achizitionati un nr de {numarBileteDorite} bilete. Va uram vizionare placuta!");
                Console.WriteLine();
                bileteCumparate = PregatesteBiletele(numarBileteDorite);

                return bileteCumparate;
            }
        }

        private List<Bilet> PregatesteBiletele(int numarBileteDorite)
        {
            List<Bilet> bileteCumparate = new List<Bilet>();
            foreach (var bilet in Bilete)
            {
                if (!bilet.Vandut)
                {
                    bilet.Vandut = true;
                    bileteCumparate.Add(bilet);
                    if (numarBileteDorite == bileteCumparate.Count)
                    {
                        break;
                    }
                }
            }
            return bileteCumparate;
        }

        private int NumaraBileteDisponibile(int bileteDisponibile)
        {
            foreach (Bilet bilet in Bilete)
            {
                if (!bilet.Vandut)
                {
                    bileteDisponibile++;
                }
            }
            return bileteDisponibile;
        }
    }
}

