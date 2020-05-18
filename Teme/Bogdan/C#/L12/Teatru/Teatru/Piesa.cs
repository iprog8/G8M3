using System;
using System.Collections.Generic;

namespace Teatru
{
    public class Piesa
    {
        public string Titlu { get; set; }
        public string Regizor { get; set; }
        public List<string> ListaActori { get; set; }
        public int LocuriDisponibile { get; set; }
        public double TaxaDeAcces { get; set; }
        public int Bilete { get; set; }


        public int GenereazaBilete(ushort bileteGenerate)
        {
            bileteGenerate = 20;
            Console.WriteLine($"La spectacolul {Titlu} regizat de catre {Regizor} s-a pus la vanzare un nr de {bileteGenerate}");
            return Bilete;
        }
        public int VindeBielte()
        {
            Console.WriteLine("Cate bilete vreti sa cumparati?");
            string nrBilete = Console.ReadLine();
            int nrBileteInt = int.Parse(nrBilete);
            if (nrBileteInt > Bilete)
            {
                Console.WriteLine($"Din pacate dispunem doar de un nr de {Bilete} bilete");
                return Bilete;
            }
            else
            {
                Console.WriteLine($"Ati achizitionat {nrBileteInt} bilete la spectacolul {Titlu} regizat de {Regizor}");
                Bilete -= nrBileteInt;
                Console.WriteLine($"Au ramas la vanzare un nr de {Bilete} bilete");
                return Bilete;
            }
        }

    }
}

