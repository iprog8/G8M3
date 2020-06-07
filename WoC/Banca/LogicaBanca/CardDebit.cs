using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaBanca
{
    public class CardDebit
    {
        public CardDebit()
        {
            Init();
        }

        public CardDebit(ContBancar cont)
        {
            Init();
            ContBancar = cont;
        }

        private void Init()
        {
            NumarCard = GenerareNumarCard();
            DataEmitere = DateTime.Today;
            DataExpirare = DataEmitere.AddYears(3);
            PIN = "0000";
            CCV = GenerareCCV();
        }

        private string GenerareCCV()
        {
            return $"{new Random().Next(111,999)}";
        }

        private string GenerareNumarCard()
        {
            return $"{new Random().Next(11111111, 99999999)}{new Random().Next(11111111, 99999999)}";
        }

        public ContBancar ContBancar { get; set; }
        public string NumarCard { get; set; }
        public DateTime DataEmitere { get; set; }
        public DateTime DataExpirare { get; set; }
        public string PIN { get; set; }
        public string CCV { get; set; }
        public string Nume
        {
            get
            {
                if (ContBancar != null)
                    return ContBancar.Nume;
                else
                    return null;
            }
        }
        public decimal Sold
        {
            get
            {
                if (ContBancar != null)
                    return ContBancar.Sold;
                else
                    return 0;
            }
        }

        public bool DepunereNumerar(int sumaDepusa)
        {
            return true;
        }

        public bool RetragereNumerar(int sumaRetrasa)
        {
            return true;
        }

        public decimal VerificaSold()
        {
            return Sold;
        }

        public bool SchimbaPin(string pinVechi, string pinNou)
        {
            return true;
        }
    }
}
