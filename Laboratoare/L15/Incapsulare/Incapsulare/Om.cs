using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulare
{
    //public inseamna ca e vizibil pretutindeni
    public class Om
    {
        public int Inaltime { get; internal set; }
        public int Greutate { get; protected set; }
        public int AnulNasterii { get; set; }
        internal string Nume { get; set; }
        internal string Telefon { get; set; }
        protected string PinInterfon { get; set; }
        protected string ProgramulTau { get; set; }
        protected string ContBancar { get; set; }
        protected internal string Gratar {get;set;}
        private string Parola { get; set; }
        private string Pin { get; set; }

    }
}
