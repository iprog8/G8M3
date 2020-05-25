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
            Talent = true;
        }
        string Nume { get; set; }
        Sex Sex { get; set; }
        uint AniExperienta { get; set; }
        bool Talent { get; set; }
        List<Programare> Programari { get; set; }
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
