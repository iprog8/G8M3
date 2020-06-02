using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frizerie
{
    public class Tura
    {
        public enum TipTura
        {
            zi =1,
            seara =2
        };
        public TipTura tipTura;
        public ZiSaptamana ziSaptamana;
        public Tura(TipTura _tipTura)
        {
            tipTura = _tipTura;
        }
        //public List<Frizer> ListaFrizeri;
        //public List<Programare> Programare ;
      
        public enum ZiSaptamana
        {
            Luni,
            Marti,
            Miercuri,
            Joi,
            Vineri
        }
    }
}
