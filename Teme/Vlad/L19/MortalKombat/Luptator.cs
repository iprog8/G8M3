using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat
{
    public class Luptator
    {
        public string Nume { get; set; }
        public virtual uint Viata { get; set; }
        public virtual uint Atac { get; set; }
        public virtual uint Stamina { get; set; }
       // public bool  PareazaAtac();
        public  bool AtacInitiat();
    }
}
