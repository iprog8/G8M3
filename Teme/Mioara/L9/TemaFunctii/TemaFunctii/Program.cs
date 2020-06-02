using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaFunctii
{
    class Program
    {
        long valoareIncasari = 257;
        long costuri = 189;


        static void Main(string[] args)
        {
            long profitCalculat = CalculeazaProfit();
            
            Console.WriteLine($"Profitul calculat pentru  {valoareIncasari} si {costuri}  este {profitCalculat}.");

            long pierderi = CalculeazaPierderi();

            Console.WriteLine($"Pierderile calculate pentru  {valoareIncasari} si {costuri}  sunt  {pierderi}.");

            Incaseaza(83);

            long datoriiRamase = Plateste(93);
            

        }

        static long CalculeazaProfit()
        {
            
            long profitCalculat = valoareIncasari - costuri;

            return profitCalculat;
        }

        static long CalculeazaPierderi()

        {
            long pierderi = costuri - valoareIncasari;
            
            return pierderi;
        }

        static void SalveazaDataNasterii(DateTime dataNastere)
        {
            dataNasterii = dataNastere;
        }

        static void Incaseaza(long sumaIncasata)
        {
            long sumaIncasata = Incaseaza(sumaIncasata);
            Console.WriteLine($"Suma incasata este {sumaIncasata}");
        }

        static long Plateste(long valoareFactura)
        {
            long datorii = 557;
            long datoriiRamase = datorii - valoareFactura;
            
            return datoriiRamase;
        }










    }
}
