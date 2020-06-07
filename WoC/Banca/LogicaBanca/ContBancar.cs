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

        //public string CreareCont()
        //public string StergeCont()
        public void DepunereNumerar(int sumaDepusa)
        {
            Sold += sumaDepusa;
        }

        public bool RegtragereNumerar(int sumaRetrasa)
        {
            if(sumaRetrasa < 1)
            {
                return false;
            }
            if(sumaRetrasa > Sold)
            {
                return false;
            }
            Sold = Sold - sumaRetrasa;
            return true;
        }

        public bool SchimbaParola(string parolaVeche, string parolaNoua)
        {
            if (Parola == parolaVeche)
            {
                Parola = parolaNoua;
                return true;
            }
            return false;
        }

        public bool Transfera(string cont, int suma)
        {
            return true;
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
