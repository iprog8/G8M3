using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulare
{
    class ContBancar
    {
        internal protected string NumeDetinator { get; internal set; }
        public string BancaEmitenta { get; private set; }
        internal protected string Iban { get; private set; }
        private string Pin { get; set; }
        internal int Suma { get; private set; }
        internal void AlimentareCont (int suma)
        {
            //TODO:
        }
        internal int RetragereNumerar(int suma, int pin)
        {
            if (suma <= Suma)
            {
                Suma -= suma;
                return suma;
            }
            else
            {
                //afiseaza mesaj de eroare
                return 0;
            }
        }

    }
}
