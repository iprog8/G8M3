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
        public List<CardDebit> CarduriDebit { get; set; }

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
            if (Parola == parolaVeche && parolaNoua != parolaVeche)
            {
                Parola = parolaNoua;
                return true;
            }
            return false;
        }

        public RaspunsComplex TransferaLocal(int sumaDeTransferat, ContBancar contDestinatar)
        {
            string message = string.Empty;
            if (sumaDeTransferat > 0)
            {
                if (Sold >= sumaDeTransferat)
                {
                    Sold -= sumaDeTransferat;
                    contDestinatar.Sold += sumaDeTransferat;

                    message = $"In contul {contDestinatar.CodBancar} a fost transferata suma de {sumaDeTransferat} din contul {CodBancar}";
                    return new RaspunsComplex(true, message);
                }
                else
                {
                    message = $"Suma transferata este mai mare decat soldul contului.";
                    return new RaspunsComplex(false, message);
                }
            }
            else
            {
                message = $"Suma transferata nu poate fi negativa.";
                return new RaspunsComplex(false, message);
            }


        }
        public Tranzactie TransferaInterbancar( int suma, string iban)
        {
            if(suma < 1)
            {
                Console.WriteLine($"Nu ati introdus o suma valida");
                return null;
            }
            if(suma > Sold)
            {
                Console.WriteLine($"Nu aveti destui bani in cont");
                return null;
            }

            Tranzactie tranzactie = new Tranzactie
            {
                Data = DateTime.Now,
                Status = StatusTranzactie.Creata,
                IbanExpeditor = CodBancar,
                IbanDestinatar = iban,
                Suma = suma
            };
            return tranzactie;
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
