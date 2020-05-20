using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Teatru
{
    public class Piesa
    {
        public Piesa()
        {
            Titlu = "Cardul Hamlet";
            Regizor = "Georghe Visu";
            LocuriDisponibile = 1;
            TaxeDeAcces = 12.3;
        }
        public string Titlu { get; set; }
        public string Regizor { get; set; }
        public List<string> Actori { get; set; }
        public int LocuriDisponibile { get; set; }
        public double TaxeDeAcces { get; set; }
        public List<Bilet> Bilete = new List<Bilet>();
       
        public int GenereazaBilete(int numarBileteGenerate = 20)
        {
            if (numarBileteGenerate < 1) Console.WriteLine("Nu poti genera mai putin de un bilet");            
            else if(numarBileteGenerate >= 1)
            {
                for(int i = 0; i < numarBileteGenerate; i++)
                {
                    Bilet biletTemporar = new Bilet() {Loc = (Bilete.Count == 0) ? 0 : (Bilete.Count + 1), Piesa = this, PretBilet = 12.3, Vandut = false};
                    Bilete.Add(biletTemporar);
                }
            }
            return numarBileteGenerate;
        }
        public List<Bilet> VindeBilete(int NumarBileteCerute)
        {
            List<Bilet> bileteCumparate = new List<Bilet>();
            if(NumarBileteCerute < 1)
            {
                Console.WriteLine("Nu poti cumpara mai putin de un bilet");
                return bileteCumparate;                
            }
            else if(NumarBileteCerute > Bilete.Count)
            {
                Console.WriteLine($"Nu puteti achizitiona un numar de bilete mai mare decat cele actuale: {Bilete.Count} bilete");
                return bileteCumparate;
            }
            else
            {
                for(int i = 0; i < NumarBileteCerute; i++)
                {                 
                    bileteCumparate.Add(Bilete[i]);
                    Bilete[i].Vandut = true;
                }                
                Bilete.RemoveRange(0, NumarBileteCerute);
                Console.WriteLine($"Ai cumparat {NumarBileteCerute} bilete si au mai ramas {Bilete.Count} bilete");
            }
            return bileteCumparate;
        }
    }
}
