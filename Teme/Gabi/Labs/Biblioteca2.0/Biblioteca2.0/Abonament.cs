using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2._0
{
    public class Abonament
    {
        public Abonament(CititorSimplu cititorSimplu)
        {
            CititorSimplu = cititorSimplu;
            TipAbonament = TipAbonament.AbonamentSimplu;
        }
        public Abonament(CititorVip cititorVip)
        {
            CititorVip = cititorVip;
            TipAbonament = TipAbonament.AbonamentVIP;
        }
        protected internal CititorSimplu CititorSimplu { get; set; }
        protected internal CititorVip CititorVip { get; set; }
        protected internal TipAbonament TipAbonament { get; set; }
    }
    public enum TipAbonament
    {
        AbonamentSimplu,
        AbonamentVIP
    }
}
