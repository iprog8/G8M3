using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaBanca
{
    public class ContBancar
    {
        public ContBancar()
        {
            Init();
        }

        public ContBancar(string nume, Moneda moneda)
        {
            Init();
            Nume = nume;
            Moneda = moneda;

        }
        private void Init()
        {
            CarduriDebit = new List<CardDebit>();
            DataCreare = DateTime.Today;
            Sold = 0;
            Parola = "0000";
            CodBancar = GenereazaCodBancar();
        }

        private string GenereazaCodBancar()
        {
            var codBancar = "RO";
            codBancar += new Random().Next(11111111, 99999999);
            return codBancar;
        }

        public string Nume { get; set; }
        public string CodBancar { get; set; }
        public DateTime DataCreare { get; set; }
        public string Parola { get; set; }
        public decimal Sold { get; set; }
        public Moneda Moneda { get; set; }
        public List<CardDebit> CarduriDebit { get; set; }

        public void DepunereNumerar(int sumaDepusa)
        {
            Sold += sumaDepusa;
        }

        public bool RegtragereNumerar(decimal sumaRetrasa)
        {
            if (sumaRetrasa < 1)
            {
                Console.WriteLine("Suma pe care vrei sa o retragi este mai mica decat 1");
                return false;
            }
            if (sumaRetrasa > Sold)
            {
                Console.WriteLine("Suma pe care vrei sa o retragi este mai mare decat sold ul curent");
                return false;
            }
            Sold -= sumaRetrasa;
            return true;
        }

        public bool SchimbaParola(string parolaVeche, string parolaNoua)
        {
            if(parolaVeche != parolaNoua)
            {
                if (Parola == parolaVeche)
                {
                    Parola = parolaNoua;
                    return true;
                }
            }
            return false;
        }

        public bool Transfera(ContBancar cont, int suma, int valuta)
        {
            if (RegtragereNumerar(suma))
            {
                cont.DepunereNumerar((suma * valuta));
                return true;
            }
            return false;
        }

        public decimal InterogareSold()
        {
            return Sold;
        }
    }

    public enum Moneda
    {
        Leu,
        Euro,
        Usd
    }
}

