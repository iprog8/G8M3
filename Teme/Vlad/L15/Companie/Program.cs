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
            Muncitor Gigi = new Muncitor("Gigi", TipContract.Determinat3Luni);
            Muncitor Gogu = new Muncitor("Gogu", TipContract.Determinat3Luni);
            Muncitor Gica = new Muncitor("Gica", TipContract.Determinat3Luni);
            Muncitor Stelica = new Muncitor("Stelica", TipContract.Determinat3Luni);
            List<Muncitor> ListaMuncitori = new List<Muncitor>();
            ListaMuncitori.Add(Gigi);
            ListaMuncitori.Add(Gogu);
            ListaMuncitori.Add(Gica);
            ListaMuncitori.Add(Stelica);

            Contabil Mirel = new Contabil("Mirel", TipContract.Determinat6Luni);
            Contabil Fane = new Contabil("Fane", TipContract.Determinat6Luni);
            Contabil George = new Contabil("George", TipContract.Determinat6Luni);
            Contabil Marius = new Contabil("Marius", TipContract.Determinat6Luni);
            List<Contabil> ListaContabili = new List<Contabil>();
            ListaContabili.Add(Mirel);
            ListaContabili.Add(Fane);
            ListaContabili.Add(George);
            ListaContabili.Add(Marius);

            ContabilSef Alexandru = new ContabilSef("Alexandru", TipContract.Nedeterminat);
            SefEchipa Daniel = new SefEchipa("Daniel", TipContract.Nedeterminat);

            GenerareOreSarciniContabili(ListaContabili, 150, 20);
            GenerareOreSarciniMuncitori(ListaMuncitori, 180, 30);

            Daniel.MaresteSalariul(Gigi);
            Daniel.MaresteSalariul(Gogu);
            Daniel.MaresteSalariul(Gica);
            Daniel.MaresteSalariul(Stelica);
            Alexandru.MaresteSalariul(Mirel);
            Alexandru.MaresteSalariul(Fane);
            Alexandru.MaresteSalariul(George);
            Alexandru.MaresteSalariul(Marius);

            Console.ReadKey();

        }
        private static void GenerareOreSarciniContabili(List<Contabil> ListaContabili,uint oreLucrate,uint sarciniIndeplinite)
        {
            for (int i = 0; i < ListaContabili.Count(); i++)
            {
                ListaContabili[i].OreLucrate = oreLucrate + Convert.ToUInt32(new Random().Next(25, 50));
                ListaContabili[i].SarciniIndeplinite = sarciniIndeplinite + Convert.ToUInt32(new Random().Next(5, 15));
                Console.WriteLine($"Contabilul {ListaContabili[i].Nume} a lucrat {ListaContabili[i].OreLucrate} ore si a indeplinit {ListaContabili[i].SarciniIndeplinite} sarcini");
            }
        }
        private static void GenerareOreSarciniMuncitori(List<Muncitor> ListaMuncitori, uint oreLucrate, uint sarciniIndeplinite)
        {
            for (int i = 0; i < ListaMuncitori.Count(); i++)
            {
                ListaMuncitori[i].OreLucrate = oreLucrate + Convert.ToUInt32(new Random().Next(40, 80));
                ListaMuncitori[i].SarciniIndeplinite = sarciniIndeplinite + Convert.ToUInt32(new Random().Next(10, 20));
                Console.WriteLine($"Contabilul {ListaMuncitori[i].Nume}a lucrat {ListaMuncitori[i].OreLucrate} ore si a indeplinit {ListaMuncitori[i].SarciniIndeplinite} sarcini");
            }
        }
    }
}
