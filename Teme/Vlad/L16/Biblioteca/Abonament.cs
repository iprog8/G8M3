using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Abonament
    {
        public Abonament(TipAbonament tipAbonament)
        {
            TipAbonament = TipAbonament.AbonamentSimplu;
        }
        public Abonament(TipAbonament tipAbonament,uint pret)
        {
            TipAbonament = TipAbonament.AbonamentVIP;
            Pret = pret;
        }
        public uint Pret { get; set; }
        public TipAbonament TipAbonament { get; set; }
    }
  
    public enum TipAbonament
    {
        AbonamentSimplu,
        AbonamentVIP
    }
}
