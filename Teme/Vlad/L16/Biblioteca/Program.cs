using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Cititor Anastasia = new Cititor("Anastasia");
            Bibliotecar AncaBibliotecara = new Bibliotecar("Anca");
            CarteImprumutabila MonteCristo = new CarteImprumutabila("Contele de Monte Cristo", "Alexandre Dumas", 5);
            CarteImprumutabila CrimaSiPedeapsa = new CarteImprumutabila("Crima si Pedeapsa", "F.M. Dostoievski", 3);
            CarteImprumutabila RazboiSiPace = new CarteImprumutabila("Razboi si Pace", "Lev Tolstoi", 4);
            CarteImprumutabila DavidCopperfield = new CarteImprumutabila("David Copperfield", "Charles Dickens", 3);
            CarteNeimprumutabila EnciclopediaBritanica = new CarteNeimprumutabila("Enciclopedia Britanica", "-", 1);
            CarteNeimprumutabila IstoriaRomaniei = new CarteNeimprumutabila("Istoria Romaniei", "Nicolae Iorga", 1);
            List<CarteImprumutabila> ListaCartiImprumutabile = new List<CarteImprumutabila>();
            List<CarteNeimprumutabila> ListaCartiNeimprumutabile = new List<CarteNeimprumutabila>();

            ListaCartiImprumutabile.Add(MonteCristo);
            ListaCartiImprumutabile.Add(CrimaSiPedeapsa);
            ListaCartiImprumutabile.Add(RazboiSiPace);
            ListaCartiImprumutabile.Add(DavidCopperfield);
            ListaCartiNeimprumutabile.Add(EnciclopediaBritanica);
            ListaCartiNeimprumutabile.Add(IstoriaRomaniei);

            InBiblioteca(Anastasia, AncaBibliotecara, ListaCartiImprumutabile, ListaCartiNeimprumutabile);
            Console.ReadKey();
        }
        private static void InBiblioteca(Cititor Cititor, Bibliotecar Bibliotecar, List<CarteImprumutabila> listaCartiImprumutabile,
            List<CarteNeimprumutabila> listaCartiNeimprumutabile)
        {

            Console.WriteLine($"Selectati operatiunea dorita:");
            Console.WriteLine($"1.Creeaza Abonament Simplu.");
            Console.WriteLine($"2.Creeaza Abonament VIP.");
            Console.WriteLine($"3.Schimba Abonament.");
            Console.WriteLine($"4.Inchide Abonament.");
            Console.WriteLine($"5.Imprumuta o carte.");
            Console.WriteLine($"6.Citeste in Biblioteca o Carte.");
            ConsoleKeyInfo tastaApasata = Console.ReadKey();
            switch (tastaApasata.Key)
            {
                case ConsoleKey.D1:
                    Bibliotecar.AbonamentSimplu(Cititor);
                    break;
                case ConsoleKey.D2:
                    Bibliotecar.AbonamentVIP(Cititor);
                    break;
                case ConsoleKey.D3:
                    Bibliotecar.SchimbaAbonament(Cititor);
                    break;
                case ConsoleKey.D4:
                    Bibliotecar.InchideAbonament(Cititor);
                    break;
                case ConsoleKey.D5:
                    CerereImprumut(Cititor, Bibliotecar, listaCartiImprumutabile, listaCartiNeimprumutabile);
                    break;
                case ConsoleKey.D6:
                    CerereCarteInBiblioteca(Cititor, Bibliotecar, listaCartiImprumutabile, listaCartiNeimprumutabile);
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Doriti o noua operatiune? Y/N");
            Console.WriteLine();

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                InBiblioteca(Cititor, Bibliotecar, listaCartiImprumutabile, listaCartiNeimprumutabile);
            }
            else
            {
                Console.WriteLine($"Sa aveti o zi buna!Va mai asteptam pe la noi.");
            }
        }

        private static void CerereCarteInBiblioteca(Cititor Cititor, Bibliotecar Bibliotecar, List<CarteImprumutabila> listaCartiImprumutabile, List<CarteNeimprumutabila> listaCartiNeimprumutabile)
        {

            if (Cititor.Abonament == null)
            {
                Console.WriteLine("Nu aveti niciun abonament pe numele dvs.");
                InBiblioteca(Cititor, Bibliotecar, listaCartiImprumutabile, listaCartiNeimprumutabile);

            }
            else if (Cititor.Abonament.TipAbonament == TipAbonament.AbonamentSimplu)
            {
                Console.WriteLine("Din pacate abonamentul dvs este unul simplu .Va sugeram sa vi-l schimbati intr-unul de tip VIP pentru a avea acces la toate cartile.");
                InBiblioteca(Cititor, Bibliotecar, listaCartiImprumutabile, listaCartiNeimprumutabile);
            }
            else
            {
                Console.WriteLine($"Aveti de ales intre urmatoarele carti.");
                for (int i = 0; i < listaCartiNeimprumutabile.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listaCartiNeimprumutabile[i].Titlu} - Mai avem disponibile {listaCartiNeimprumutabile[i].NrExemplare} exemplare.");
                }
                Console.WriteLine($"Tastati cifra corespunzatoare cartii dorite.");
                //ConsoleKeyInfo CarteAleasa = Console.ReadKey();
                string CarteAleasaStr = Console.ReadLine();
                int CarteAleasaInt;
                if (int.TryParse(CarteAleasaStr, out CarteAleasaInt))
                {
                    if ((CarteAleasaInt < 1) || (CarteAleasaInt > listaCartiNeimprumutabile.Count))
                    {
                        Console.WriteLine($"Cifra aleasa nu corespunde niciunei carti din lista.");
                        return;
                    }
                    else if(listaCartiNeimprumutabile[CarteAleasaInt - 1].NrExemplare == 0)
                    {
                        Console.WriteLine($"Din pacate, nu mai avem niciun exemplar disponibil.");
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        if (keyInfo.Key == ConsoleKey.Y)
                        {
                            Console.WriteLine();
                            InBiblioteca(Cititor, Bibliotecar, listaCartiImprumutabile, listaCartiNeimprumutabile);
                        }
                        else
                        {
                            Console.WriteLine($"Sa aveti o zi buna!Va mai asteptam pe la noi.");
                            return;
                        }
                    }
                    else 
                    {
                        Cititor.CitesteCarteSalaLectura(listaCartiNeimprumutabile[CarteAleasaInt - 1]);
                    }
                    
                }

            }
        }
        private static void CerereImprumut(Cititor Cititor, Bibliotecar Bibliotecar, List<CarteImprumutabila> listaCartiImprumutabile, List<CarteNeimprumutabila> listaCartiNeimprumutabile)
        {
            if (Cititor.Abonament == null)
            {
                Console.WriteLine("Nu aveti niciun abonament pe numele dvs.");
                InBiblioteca(Cititor, Bibliotecar, listaCartiImprumutabile, listaCartiNeimprumutabile);
            }
            else
            {
                Console.WriteLine($"Aveti de ales intre urmatoarele carti.");
                for (int i = 0; i < listaCartiImprumutabile.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listaCartiImprumutabile[i].Titlu} - Mai avem disponibile {listaCartiImprumutabile[i].NrExemplare} exemplare.");
                }
                Console.WriteLine($"Tastati cifra corespunzatoare cartii dorite.");
                //ConsoleKeyInfo CarteAleasa = Console.ReadKey();
                string CarteAleasaStr = Console.ReadLine();
                int CarteAleasaInt;
                if (int.TryParse(CarteAleasaStr, out CarteAleasaInt))
                {
                    if ((CarteAleasaInt < 1) || (CarteAleasaInt > listaCartiImprumutabile.Count))
                    {
                        Console.WriteLine($"Cifra aleasa nu corespunde niciunei carti din lista.");
                        return;
                    }
                    else if (listaCartiImprumutabile[CarteAleasaInt - 1].NrExemplare == 0)
                    {
                        Console.WriteLine($"Din pacate, nu mai avem niciun exemplar disponibil.");
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        if (keyInfo.Key == ConsoleKey.Y)
                        {
                            Console.WriteLine();
                            InBiblioteca(Cititor, Bibliotecar, listaCartiImprumutabile, listaCartiNeimprumutabile);
                        }
                        else
                        {
                            Console.WriteLine($"Sa aveti o zi buna!Va mai asteptam pe la noi.");
                            return;
                        }
                    }
                    else
                    {
                        Cititor.ImprumutCarte(listaCartiImprumutabile[CarteAleasaInt - 1]);
                    }
                }
            }
        }
    }
}
