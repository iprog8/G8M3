using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Teatru
{
    public class Piesa
    {
        public Piesa()
        {
            TaxaDeAcces = 25;
        }
        public string Titlu { get; set; }
        public string Regizor { get; set; }
        //public int BileteGenerate { get; set; }
        public int TaxaDeAcces { get; set; }
        public int Bilete { get; set; }
        public List<Bilet> listaBileteDisponibile = new List<Bilet>();
        public List<Bilet> listaBileteVandute = new List<Bilet>();

        public int nrDeBileteDisponibile;

        public int GenereazaBilete(int BileteDisponibile)
        {
           
            Console.WriteLine($"La piesa de teatru {Titlu} s-au pus in vanzare {BileteDisponibile} de bilete");
        
            for (int i = 0; i< BileteDisponibile; i++)
            {
                Bilet biletDisponibil = new Bilet()
                {
                    Loc = i,
                    Piesa = this,
                    PretBilet = 80,
                    Vandut = false
                };
                listaBileteDisponibile.Add(biletDisponibil);
            }
            nrDeBileteDisponibile = listaBileteDisponibile.Count;
            return nrDeBileteDisponibile;
        }

        public List<Bilet> VindeBilete(int nrBileteCerute)
        {
            listaBileteVandute.Clear();
            if (nrBileteCerute < 1)
            {
                Console.WriteLine("Nu poti cumpara mai putin de 1 bilet.");
                return listaBileteVandute;
            }
            else if (nrBileteCerute > listaBileteDisponibile.Count)
            {
                Console.WriteLine($"Nr de bilete cerute: {nrBileteCerute} depaseste nr de bilete disponibile: {listaBileteDisponibile.Count}");
                return listaBileteVandute;
            }
            else
            {               
                for (int j = 0; j < nrBileteCerute; j++)
                {
                    Bilet biletCerut = new Bilet()
                    {
                        Loc = j,
                        Piesa = this,
                        PretBilet = 80,
                        Vandut = true
                    };
                    listaBileteVandute.Add(biletCerut);
                }
                listaBileteDisponibile.RemoveRange(0, listaBileteVandute.Count);
                Console.WriteLine($"Ati achizitionat {listaBileteVandute.Count} bilete");
                Console.WriteLine($"Pentru piesa {Titlu}',au mai ramas {listaBileteDisponibile.Count} bilete");
            }
           
            return listaBileteVandute;
        }

        private List<Bilet> VerificaDisponibilitate(int nrBileteCerute)
        {
            for (int j = 0; j < nrBileteCerute; j++)
            {   
                Bilet biletCerut = new Bilet()
                {
                    Loc = j,
                    Piesa = this,
                    PretBilet = 80,
                    Vandut = true
                };
                listaBileteVandute.Add(biletCerut);
                listaBileteDisponibile.RemoveRange(0, listaBileteVandute.Count);
            }
            return listaBileteVandute;
        }
    }

}
