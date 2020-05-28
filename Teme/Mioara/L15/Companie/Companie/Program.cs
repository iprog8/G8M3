using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companie
{
    class Program
    {
        static void Main(string[] args)
        {
            Angajat angajat1 = new Angajat();
            angajat1.Nume = "Vasilescu Petre";
            angajat1.Sectia = Sectia.Productie;
            angajat1.FinalizeazaPiese(20);

            Angajat angajat2 = new Angajat();
            angajat2.Nume = "Popa George";
            angajat2.Sectia = Sectia.Productie;
            angajat2.FinalizeazaPiese(30);

            Angajat angajat3 = new Angajat();
            angajat3.Nume = "Cristea Vasile";
            angajat3.Sectia = Sectia.Productie;
            angajat3.FinalizeazaPiese(15);

            Muncitor muncitor1 = new Muncitor();
            muncitor1.Nume = "Ionescu Iulian";
            muncitor1.Sectia = Sectia.Productie;
            muncitor1.FinalizeazaPiese(15);
            muncitor1.IncarcaMarfa("cherestea");
                


        }
    }
}
