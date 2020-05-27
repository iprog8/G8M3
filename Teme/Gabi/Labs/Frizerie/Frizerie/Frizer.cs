using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frizerie
{
    public class Frizer
    {
        public Frizer(string nume, Sex sex, uint aniExperienta)
        {
            Nume = nume;
            Sex = sex;
            AniExperienta = aniExperienta;
        }
        public string Nume { get; set; }
        public Sex Sex { get; set; }
        public uint AniExperienta { get; set; }
        public List<Programare> Programari { get; set; }
        public bool TundeClient(Programare programare)
        {
            if (this.Programari == null) this.Programari = new List<Programare>();
            this.Programari.Add(programare);
            if (programare.Frizer == this) { Console.WriteLine($"Clientul {programare.Client.Nume} a fost tuns de {this.Nume}"); return true; }
            else { Console.WriteLine("Ai venit cu programarea la frizerul gresit"); return false; }
        }
        public void IntraInTura()
        {
            Console.WriteLine($"Frizerul {this.Nume} a intrat in tura");
        }
        public void IeseDinTura()
        {
            Console.WriteLine($"Frizerul {this.Nume} a iesit din tura");
        }
    }
    public enum Sex
    {
        Nedefinit,
        Feminin,
        Masculin
    }

}
