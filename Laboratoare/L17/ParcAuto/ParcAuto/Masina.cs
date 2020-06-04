using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcAuto
{
    public class Masina
    {
        public Masina(string marca, string culoare, int an, int km)
        {
            Marca = marca;
            Culoare = culoare;
            An = an;
            Km = km;
        }
        public string Marca { get; set; }
        public string Culoare { get; set; }
        public int An { get; set; }
        public int Km { get; set; }
        public Motor Motor { get; set; }
        public Roata RoataStangaFata { get; set; }
        public Roata RoataStangaSpate { get; set; }
        public Roata RoataDreaptaFata { get; set; }
        public Roata RoataDreaptaSpate { get; set; }
        public List<Roata> RotiMontate { get; set; }
        public Roata RoataDeRezerva { get; set; }
        public bool AreCarligRemorca { get; set; }
        //public DetaliiRemorca DetaliiRemorca { get; set; }

        public void Merge(int km)
        {
            if (RoataDreaptaFata == null || RoataDreaptaSpate == null || RoataStangaFata == null || RoataStangaSpate == null)
            {
                Console.WriteLine($"Masina {Marca} nu are toate rotile, deci nu poate sa mearga");
                return;
            }
            Km += km;
        }
    }

    public enum TipCombustibil
    {
        Necunoscut,
        Benzina,
        Motorina,
        GPL,
        Electric,
        Hibrid
    }
}
