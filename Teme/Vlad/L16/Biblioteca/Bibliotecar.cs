using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Bibliotecar
    {
        public Bibliotecar(string nume)
        {
            Nume = nume;
        }
        public string Nume { get; set; }
        public void AbonamentSimplu(Cititor Cititor)
        {
            if (Cititor.Abonament == null)
            {
                Abonament abonamentSimplu = new Abonament(TipAbonament.AbonamentSimplu);
                Cititor.Abonament = abonamentSimplu;
                Console.WriteLine($"Bibliotecarul {this.Nume} a creat un abonament simplu pentru cititorul {Cititor.Nume}.");
            }
            else
            {
                Console.WriteLine("Aveti deja un abonament simplu pe numele dumneavoastra.");
                return;
            }
        }
        public void AbonamentVIP(Cititor Cititor)
        {
            if (Cititor.Abonament == null)
            {
                Abonament abonamentVIP = new Abonament(TipAbonament.AbonamentSimplu, 50);
                Cititor.Abonament = abonamentVIP;
                Console.WriteLine($"Bibliotecarul {this.Nume} a creat un abonament VIP cu pretul de {Cititor.Abonament.Pret} pentru cititorul {Cititor.Nume}.");
            }
            else if (Cititor.Abonament.TipAbonament == TipAbonament.AbonamentSimplu)
            {
                Console.WriteLine($"Aveti deja un abonament simplu pe numele dumneavoasta.Va rugam alegeti optiunea Schimbare Abonament");
                return;
            }
        }
        public void SchimbaAbonament (Cititor Cititor)
        {
            if (Cititor.Abonament == null)
            {
                Console.WriteLine($"Nu aveti niciun abonament pe numele dvs.");
                return;
            }
            else if (Cititor.Abonament.TipAbonament == TipAbonament.AbonamentSimplu)
            {
                Cititor.Abonament.TipAbonament = TipAbonament.AbonamentVIP;
                Cititor.Abonament.Pret = 50;
                Console.WriteLine($"Aveti deja un abonament simplu pe numele dumneavoasta.Il vom schimba intr-unul VIP.Trebuie sa achitati taxa de 50 lei pe luna.");
            }
            else
            {
                Cititor.Abonament.TipAbonament = TipAbonament.AbonamentSimplu;
                Cititor.Abonament.Pret = 0;
                Console.WriteLine($"Va vom schimba abonamentul VIP intr-unul simplu care este gratis.");
            }
        }
        public void InchideAbonament(Cititor Cititor)
        {
            if (Cititor.Abonament == null)
            {
                Console.WriteLine($"Nu aveti niciun abonament pe numele dvs.");
                return;
            }
            else
            {
                Cititor.Abonament = null;
                Console.WriteLine($"Abonamentul a fost inchis.");
            }
        }
    }
}
