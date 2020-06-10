using BazaDate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaBanca
{
    public class Date : Database
    {
        //public List<Client> Clienti { get; set; }
        public List<ContBancar> ConturiBancare { get; set; }
        public Date() : base(nameof(Date))
        {
            //Clienti = new List<Client>();
            ConturiBancare = new List<ContBancar>();
        }
    }
}
