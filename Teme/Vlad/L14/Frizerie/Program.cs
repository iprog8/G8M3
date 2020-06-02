using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Frizerie
{
    class Program
    {
        public static void Main(string[] args)
        {

            // string TuraAleasa;
            List<Frizer> ListaFrizeri = new List<Frizer>();
            ListaFrizeri.Add(new Frizer { Nume = "Ana" });
            ListaFrizeri.Add(new Frizer { Nume = "Nicolae" });
            ListaFrizeri.Add(new Frizer { Nume = "Larisa" });
            ListaFrizeri.Add(new Frizer { Nume = "Petru" });

            //Ture
            Tura TuraDeZi = new Tura(Tura.TipTura.zi);
            Tura TuraDeSeara = new Tura(Tura.TipTura.seara);

            //Clienti
            Client Marcel = new Client();
            Marcel.Nume = "Marcel";
            Client Ninel = new Client();
            Ninel.Nume = "Ninel";
            Client Petru = new Client();
            Petru.Nume = "Marcel";

            OrarulSaptamanii(ListaFrizeri, TuraDeZi, TuraDeSeara);
            Marcel.FaceProgramare();
            Marcel.AlegeTura();
            Ninel.FaceProgramare();
            Ninel.AlegeTura();
            Petru.FaceProgramare();
            Petru.AlegeTura();
           

            Console.ReadKey();
        }

        private static void OrarulSaptamanii(List<Frizer> ListaFrizeri, Tura TuraDeZi, Tura TuraDeSeara)
        {
            int NrSaptamana = GetWeekNumber();

            Console.WriteLine($"Suntem in saptamana cu nr. {NrSaptamana}");
            //AlegeTura(ListaFrizeri, TuraDeZi, TuraDeSeara, NrSaptamana);
            if ((NrSaptamana & 2) == 0) // Saptamana Para
            {
                ListaFrizeri[0].Tura = TuraDeZi;
                ListaFrizeri[1].Tura = TuraDeZi;
                ListaFrizeri[2].Tura = TuraDeSeara;
                ListaFrizeri[3].Tura = TuraDeSeara;
                Console.WriteLine($"In aceasta saptamana, pe tura {Tura.TipTura.zi} lucreaza frizerii: {ListaFrizeri[0].Nume} si {ListaFrizeri[1].Nume} iar pe cea de {Tura.TipTura.seara} {ListaFrizeri[2].Nume} si {ListaFrizeri[3].Nume}");
            }
            else // Saptamana impara
            {
                ListaFrizeri[0].Tura = TuraDeSeara;
                ListaFrizeri[1].Tura = TuraDeSeara;
                ListaFrizeri[2].Tura = TuraDeZi;
                ListaFrizeri[3].Tura = TuraDeZi;
                Console.WriteLine($"In aceasta saptamana, pe tura {Tura.TipTura.zi} lucreaza frizerii {ListaFrizeri[2].Nume} si {ListaFrizeri[3].Nume} iar pe cea de {Tura.TipTura.seara},frizerii {ListaFrizeri[1].Nume} si {ListaFrizeri[0].Nume}");
            }
        }
        public static int GetWeekNumber()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Saturday);
            return weekNum;
        }

        /* while(true)
                    {
                            Console.WriteLine($"Pentru tura aleasa, tastati 'A' pentru frizerul {ListaFrizeri[0].Nume}  sau 'B' pentru {ListaFrizeri[1].Nume}");
                        ConsoleKeyInfo FrizerAles = Console.ReadKey();
                        if ((FrizerAles.Key != ConsoleKey.D1) && (FrizerAles.Key != ConsoleKey.D2))
                        {
                            Console.WriteLine("Optiunea aleasa nu este valida.");
                        }
                        else if (FrizerAles.Key == ConsoleKey.D1)
                        {
                            ListaFrizeri[0].Tunde(client.Nume, TuraDeZi);
                            break;
                        }
                        else
                        {
                            ListaFrizeri[1].Tunde(Client client, TuraDeZi);
                            break;
                        }
                    }*/
        /*  Console.WriteLine($"Pentru tura aleasa, tastati 'A' pentru frizerul {ListaFrizeri[2].Nume}  sau 'B' pentru {ListaFrizeri[3].Nume}");
            ConsoleKeyInfo FrizerAles = Console.ReadKey();
            if (FrizerAles.Key == ConsoleKey.A)
            {
                ListaFrizeri[2].Tunde(Client, TuraDeZi);
                break;
            }
            else
            {
                ListaFrizeri[3].Tunde(Client, TuraDeZi);
                break;
            }*/
    }
}
