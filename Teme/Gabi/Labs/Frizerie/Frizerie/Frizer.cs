using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frizerie
{
    public class Frizer
    {
        Frizer()
        {
            Nume = "Popescu Ion";
            Sex = Sex.Masculin;
            AniExperienta = 1;
        }
        public string Nume { get; set; }
        public Sex Sex { get; set; }
        public uint AniExperienta { get; set; }
        public List<Programare> Programari { get; set; }
        public void TundeClienti()
        {

        }
        public void IntraInTura()
        {

        }
        public void IeseDinTura()
        {

        }
    }
    public enum Sex
    {
        Nedefinit,
        Feminin,
        Masculin
    }

}
