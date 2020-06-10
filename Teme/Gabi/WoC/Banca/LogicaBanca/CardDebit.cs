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
        public CardDebit(ContBancar contBancar)
        {
            Init();
            ContBancar = contBancar;
        }
        private void Init()
        {
            NumarCard = GenerareNumarCard();
            DataEmitere = DateTime.Today;
            DataExpirare = DataEmitere.AddYears(3);
            PIN = "0000";
            CCV = GenereazaCCV();
        }
        private string GenereazaCCV()
        {
            return $"{new Random().Next(111,999)}";
        }
        private string GenerareNumarCard()
        {
            return $"{new Random().Next(11111111, 99999999)}{new Random().Next(11111111, 99999999)}";
        }
        public ContBancar ContBancar { get; set; }
        public string NumarCard { get; set; }
        public string CodCard { get; set; }
        public DateTime DataEmitere { get; set; }
        public DateTime DataExpirare { get; set; }
        public string PIN { get; set; }
        public string CCV { get; set; }
        public string Nume
        {
            get
            {
                if (ContBancar.Nume != null) return ContBancar.Nume;
                else return null;
            }
        }
        public decimal Sold
        {
            get
            {
                if (ContBancar != null) return ContBancar.Sold;
                else return 0;
            }
        }
        public bool DepunereNumerar(int sumaDepusa)
        {
            if(sumaDepusa <= 0)
            {
                Console.WriteLine("Nu ai cum sa depui o suma mai mica decat 0!");
                return false;
            }
            ContBancar.Sold += sumaDepusa;
            return true;
        }
        public bool RetragereNumerar(int sumaRetrasa)
        {
            if(sumaRetrasa <= 0)
            {
                Console.WriteLine("Nu ai cum sa retragi o suma mai mica decat 0");
                return false;
            }
            else if (sumaRetrasa > Sold)
            {
                Console.WriteLine($"Nu ai cum sa retragi o suma mai mare decat sold ul tau: {Sold}");
                return false;
            }
            ContBancar.Sold -= sumaRetrasa;
            return true;
        }
        public decimal VerificaSold()
        {
            return Sold;
        }
        public bool SchimbaPin(string pinVechi, string pinNou)
        {
            if(pinVechi != pinNou)
            {
                if(PIN != pinNou)
                {
                    PIN = pinNou;
                    return true;
                }
            }
            return false;
        }
    }
}
