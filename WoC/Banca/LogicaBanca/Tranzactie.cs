using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaBanca
{
    public class Tranzactie
    {
        public string IbanExpeditor { get; set; }
        public string IbanDestinatar { get; set; }
        public DateTime Data { get; set; }
        public int Suma { get; set; }
        public StatusTranzactie Status { get; set; }
        public string MesajDeEroare { get; set; }
    }

    public enum StatusTranzactie
    {
        Creata,
        Succes,
        Esuat
    }
}
