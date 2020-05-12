using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcepteDeProgramare
{
    class Program
    {
        static void Main(string[] args)
        {
            Variabile();
        }
        static void Variabile()
        {
            // - variabile
            //js: var/const/let numeVariabila = ''
            int nota = 0; //- 2 mild .... +2 mild
            uint notaUint = 0; // 0 ... 4 mild
            long notaLong = 0; // int la patrat
            ulong notaUlong = 0; // 0 ... 4 mild la patrat
            short notaShort = 0; // -32.??? ... 32.???
            ushort notaUshort = 0; // 0 ... 64.???
            byte notaByte = 0; // -125 ... 126
            string nume = "Alex";
            bool continua = true;
            double pi = 3.14;

            int valoare = 2;
            short valoareShort = 5;
            int rezultat = valoare + valoareShort;
            valoareShort = (short)valoare; //conversie explicita de la int la short
            string valoareString = valoare.ToString();
        }
    }
}
