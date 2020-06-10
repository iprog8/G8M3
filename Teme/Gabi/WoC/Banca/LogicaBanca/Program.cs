using BazaDate;
using log4net;
using log4net.Config;
using LogicaBanca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    static class Program
    {
        static ILog log;
        static Program()
        {
            XmlConfigurator.Configure();
            log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            log.Info($"App Banca started {Environment.UserDomainName}.{Environment.UserName}");
        }
        static List<string> Mesaje = new List<string>()
        {
            "A. Utilizatorul a ales optinea",
            "Creare cont bancar",
            "Sterge cont bancar",
            "Transfer bancar",
            "Schimba parola",
            "Depunere numerar",
            "Retragere numerar",
            "Verifica sold",
            "Creeaza Card Debit",
            "Acceseaza card debit"
        };
        static void Main(string[] args)
        {
            Date db = Date.LoadData<Date>(nameof(Date));
            AlegeOperatiune(db);
            log.Info($"Main: App Banca stopped {Environment.UserDomainName}.{Environment.UserName}");
            Console.ReadKey();
        }
        private static void AlegeOperatiune(Date db)
        {
            Console.WriteLine("Ce doriti?");
            Console.WriteLine($" 1. {Mesaje[1]} \n 2. {Mesaje[2]} \n 3. {Mesaje[3]} \n 4. {Mesaje[4]} \n 5. {Mesaje[5]}");
            Console.WriteLine($" 6. {Mesaje[6]} \n 7. {Mesaje[7]} \n 8. {Mesaje[8]} \n 9. {Mesaje[9]}");
            Console.WriteLine("Tastati cifra din fata operatiunii pt a alege");
            ConsoleKeyInfo tastaApasata = Console.ReadKey();
            switch (tastaApasata.Key)
            {
                case ConsoleKey.D1:
                    log.Info($"{Mesaje[0]} {Mesaje[1]}");
                    CreareContBancar(db);
                    break;
                case ConsoleKey.D2:
                    log.Info($"{Mesaje[0]} {Mesaje[2]}");
                    StergeCont(db);
                    break;
                case ConsoleKey.D3:
                    log.Info($"{Mesaje[0]} {Mesaje[3]}");
                    TransferaBaniIntreConturi(db);
                    break;
                case ConsoleKey.D4:
                    log.Info($"{Mesaje[0]} {Mesaje[4]}");
                    SchimbaParola(db);
                    break;
                case ConsoleKey.D5:
                    log.Info($"{Mesaje[0]} {Mesaje[5]}");
                    DepunereNumerar(db);
                    break;
                case ConsoleKey.D6:
                    log.Info($"{Mesaje[0]} {Mesaje[6]}");
                    RetragereNumerar(db);
                    break;
                case ConsoleKey.D7:
                    log.Info($"{Mesaje[0]} {Mesaje[7]}");
                    VerificaSold(db);
                    break;
                case ConsoleKey.D8:
                    log.Info($"{Mesaje[0]} {Mesaje[8]}");
                    CreeazaCardDebit(db);
                    break;
                case ConsoleKey.D9:
                    log.Info($"{Mesaje[0]} {Mesaje[9]}");
                    IntraInCardDebit(db);
                    break;
                default:
                    log.Info($"{Mesaje[0]} {Mesaje[8]}");
                    Console.WriteLine("Nu ati selectat nici optiune valida");
                    AlegeOperatiune(db);
                    break;
            }
        }
        private static void IntraInCardDebit(Date db)
        {
            CardDebit card = AcceseazaCardDebit(db);
            if(card != null)
            {
                Console.WriteLine("Care este operatiunea pe care vreti sa o faceti pe card?");
                Console.WriteLine("1. Sterge card \n 2. Verifica sold card \n 3. Depune numerar pe card \n 4. Retrage numerar dupa card \n 5. Schimba pin card");
                ConsoleKeyInfo tastaApasata = Console.ReadKey();
                switch (tastaApasata.Key)
                {
                    case ConsoleKey.D1:
                        StergeCardDebit(db,card);
                        break;
                    case ConsoleKey.D2:
                        VerificaSoldCard(card);
                        break;
                    case ConsoleKey.D3:
                        ModificareNumerarCardDebit(db,TipModificareNumerar.Depunere,card);
                        break;
                    case ConsoleKey.D4:
                        ModificareNumerarCardDebit(db,TipModificareNumerar.Retragere,card);
                        break;
                    case ConsoleKey.D5:
                        SchimbaPinCardDebit(db,card);
                        break;
                    default:
                        Console.WriteLine("Nu ati selectat nici o optiune valida");
                        break;
                }
            }
            else
            {
                string msg = "Cardul nu a fost gasit in baza de date";
                Console.WriteLine(msg);
                log.Warn(msg);
            }
        }
        private static void SchimbaPinCardDebit(Date db, CardDebit card)
        {
            string msg1 = "Pin ul a fost schimbat cu succes";
            string msg2 = "Pin ul nu a putut fi schimbat";
            Console.WriteLine("Introdu pin-ul vechi:");
            string pinVechi = Console.ReadLine();
            Console.WriteLine("Introdu pin-ul now");
            string pinNou = Console.ReadLine();
            if (card.SchimbaPin(pinVechi, pinNou))
            {
                Console.WriteLine(msg1);
                log.Info(msg1);
                db.SaveData();
            }
            else
            {
                Console.WriteLine(msg2);
                log.Warn(msg2);
                return;
            }
        }
        private static void ModificareNumerarCardDebit(Date db, TipModificareNumerar tipMod, CardDebit card)
        {
            string msg = "Suma introdusa de tine nu este valida";
            if (tipMod == TipModificareNumerar.Depunere)
            {
                string sumaDepusa = Console.ReadLine();
                int suma = 0;
                if(int.TryParse(sumaDepusa, out suma))
                {
                    if (card.DepunereNumerar(suma))
                    {
                        string msg1 = "Suma a fost depusa cu succes";
                        Console.WriteLine(msg1);
                        log.Info(msg1);
                        db.SaveData();
                        return;
                    }
                    else
                    {
                        string msg2 = "Suma nu a fost depusa";
                        Console.WriteLine(msg2);
                        log.Warn(msg2);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine(msg);
                    log.Warn(msg);
                    return;
                }
            }
            else if(tipMod == TipModificareNumerar.Retragere)
            {
                string sumaRetrasa = Console.ReadLine();
                int sumaR = 0;
                if(int.TryParse(sumaRetrasa, out sumaR))
                {
                    if (card.RetragereNumerar(sumaR))
                    {
                        string msg4 = "Suma a fost retrasa cu succes!";
                        Console.WriteLine(msg4);
                        log.Info(msg4);
                        db.SaveData();
                    }
                    else
                    {
                        string msg3 = "Suma nu a fost retrasa";
                        Console.WriteLine(msg3);
                        log.Warn(msg3);
                        return;
                    }
                }
                else
                {
                    Console.WriteLine(msg);
                    log.Warn(msg);
                    return;
                }
            }
            return;
        }
        private static void VerificaSoldCard(CardDebit card)
        {
            Console.WriteLine($"Sold ul cardului {card.NumarCard} este {card.Sold}");
        }
        private static void StergeCardDebit(Date db, CardDebit cardDeSters)
        {
            cardDeSters.ContBancar.CarduriDebit.Remove(cardDeSters);
            db.SaveData();
            log.Info($"Cardul {cardDeSters.NumarCard} a fost sters.");
            Console.WriteLine($"Cardul {cardDeSters.NumarCard} a fost sters.");
        }
        private static CardDebit AcceseazaCardDebit(Date db)
        {
            CardDebit cardDebit = null;
            Console.WriteLine("Intrudu numarul de card:");
            string numarCard = Console.ReadLine();
            Console.WriteLine("Introdu pin ul de la card");
            string pinCard = Console.ReadLine();
            foreach(var cont in db.ConturiBancare)
            {
                if (cont == null) continue;
               foreach(var card in cont.CarduriDebit)
                {
                    if(card.NumarCard == numarCard && card.PIN == pinCard)
                    {
                        cardDebit = card;
                        return cardDebit;
                    }
                }
            }
            return null;
        }
        private static void CreeazaCardDebit(Date db)
        {
            ContBancar cont = LogheazaUtilizator(db);
            if(cont != null)
            {
                CardDebit cardDebit = new CardDebit(cont);
                cont.CarduriDebit.Add(cardDebit);
                Console.WriteLine($"Aproape a fost creat card ul de debit pentru clientul {cont.Nume}");
                Console.WriteLine("Din motive de securitate trebuie sa iti setezi un pin si un cod de card:");
                Console.WriteLine("Introdu un pin nou si apasa enter");
                string pin = Console.ReadLine();
                if(cardDebit.SchimbaPin("0000", pin))
                {
                    Console.WriteLine("Introdu un cod de card nou si apaasa enter");
                    string codCard = Console.ReadLine();
                    cardDebit.CodCard = codCard;
                    string msg1 = "Card ul de debit a fost creat!";
                    Console.WriteLine(msg1);
                    log.Info(msg1);
                    db.SaveData();
                }
                else
                {
                    string msg = "Pin ul nu a putut fi schimbat";
                    Console.WriteLine(msg);
                    log.Warn(msg);
                    return;
                }
            }
            log.Warn($"Cont ul nu a fost gasit in baza de date");
            Console.WriteLine("Cont ul nu a fost gasit in baza de date");
        }
        private static void TransferaBaniIntreConturi(Date db)
        {
            Console.WriteLine("Intrudu datele primului cont:");
            ContBancar contPrincipal = LogheazaUtilizator(db);
            Console.WriteLine("Intrudu codul bancar celui de al doilea cont:");
            string codBancar = Console.ReadLine();
            ContBancar contDestinatar = null;
            if((contPrincipal != null) && (codBancar.Length == 10))
            {
                foreach(var cod in db.ConturiBancare)
                {
                    if(contPrincipal.CodBancar == codBancar)
                    {
                        Console.WriteLine("Datele introduse sunt aceleasi");
                        log.Warn("Datele introduse sunt aceleasi");
                        return;
                    }
                    else if (cod.CodBancar == codBancar)
                    {
                        contDestinatar = cod;
                        break;
                    }
                }
                if (contDestinatar != null)
                {
                    VerificaMoneda(contPrincipal,contDestinatar, db);
                }
                else
                {
                    Console.WriteLine("contul nu a fost gasit in baza de date");
                    log.Warn("contul nu a fost gasit in baza de date");
                }
            }
            else
            {
                log.Warn("Cont ul nu este valid sau codul bancar nu este valid!");
                Console.WriteLine("Cont ul nu este valid sau codul bancar nu este valid!");
            }

        }
        private static int Valuta(Moneda moneda1, Moneda moneda2)
        {
            if(moneda1 == Moneda.Euro && moneda2 == Moneda.Leu)
            {
                return 5;
            }
            else if(moneda1 == Moneda.Usd && moneda2 == Moneda.Leu)
            {
                return 4;
            }
            return 1;
        }
        private static void VerificaMoneda(ContBancar contPrincipal, ContBancar contDestinatar, Date db)
        {
            int valuta = Valuta(contPrincipal.Moneda, contDestinatar.Moneda);
            if (contPrincipal.Moneda == contDestinatar.Moneda)
            {
                TransferaBani(contPrincipal, contDestinatar, db, 1);
            }
            else
            {
                Console.WriteLine($"Valutele conturilor nu se potrivesc! Vrei sa faci transferul din {contPrincipal.Moneda} {contDestinatar.Moneda} cu valuta noastra: {valuta} ?");
                Console.WriteLine("1.Da \n2.Nu");
                ConsoleKeyInfo optiune = Console.ReadKey();
                if (optiune.Key == ConsoleKey.D1)
                {
                    TransferaBani(contPrincipal, contDestinatar, db, valuta);
                }
                else if (optiune.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Nu ai vrut valuta noastra, deci nu putem sa iti facem transferul");
                    return;
                }
                else return;
            }
        }
        private static void TransferaBani(ContBancar contPrincipal, ContBancar contDestinatar, Date db, int valuta)
        {
            Console.WriteLine($"Ce suma vrei sa transferi?");
            string sumaString = Console.ReadLine();
            int sumaInt = 0;
            if (!int.TryParse(sumaString, out sumaInt))
            {
                Console.WriteLine($"Suma {sumaString} este invalida");
                log.Warn($"Suma {sumaString} introdusa este invalida");
                return;
            }
            else
            {
                if (contPrincipal.Transfera(contDestinatar, sumaInt, valuta))
                {
                    Console.WriteLine($"Transferul a avut succes");
                    db.SaveData();
                }
                else
                {
                    Console.WriteLine($"Transferul nu a avut succes");
                    log.Info("Transferul nu a avut succes");
                }
            }
        }
        private static void VerificaSold(Date db)
        {
            ContBancar cont = LogheazaUtilizator(db);
            if(cont != null)
            {
                Console.WriteLine($"Sold ul clientului {cont.Nume} este {cont.InterogareSold()}");
            }
            else
            {
                log.Warn($"Cont ul nu a fost gasit in baza de date");
                Console.WriteLine("Cont ul nu a fost gasit in baza de date");
            }
        }
        private static void SchimbaParola(Date db)
        {
            Console.WriteLine("Care este numele dumneavoastra?");
            string numeUtilizator = Console.ReadLine();
            Console.WriteLine("Care este parola curenta?");
            string parolaVeche = Console.ReadLine();
            Console.WriteLine("Care este parola dorita?");
            string parolaNoua = Console.ReadLine();

            ContBancar contCautat = null;
            foreach (var cont in db.ConturiBancare)
            {
                if (cont.Nume == numeUtilizator)
                {
                    contCautat = cont;
                    break;
                }
            }
            if (contCautat == null)
            {
                Console.WriteLine($"Contul cu utilizatorul {numeUtilizator} nu a fost gasit.");
                return;
            }
            var rezultatSchimbaParola = contCautat.SchimbaParola(parolaVeche, parolaNoua);
            if (rezultatSchimbaParola == true)
            {
                Console.WriteLine($"Contul cu utilizatorul {numeUtilizator}  si-a schimbat parola.");
            }
            else
            {
                Console.WriteLine($"Contul cu utilizatorul {numeUtilizator}  nu a putut sa schimbe parola.");
            }

            db.SaveData();
        }
        private static void CreareContBancar(Date db)
        {
            Console.WriteLine("Care este numele dumneavoastra?");
            string numeUtilizator = Console.ReadLine();
            Console.WriteLine("Care este moneda in care doriti sa creati contul?");
            Console.WriteLine("1. EUR, 2. USD, orice alta tasta pentru Leu.");
            ConsoleKeyInfo tastaApasata = Console.ReadKey();
            Moneda moneda;
            switch (tastaApasata.Key)
            {
                case ConsoleKey.D1:
                    moneda = Moneda.Euro;
                    break;
                case ConsoleKey.D2:
                    moneda = Moneda.Usd;
                    break;
                default:
                    moneda = Moneda.Leu;
                    break;
            }
            ContBancar contBancar = new ContBancar(numeUtilizator, moneda);
            //string parolaVeche = "0000";
            Console.WriteLine("Contul tau este aproape creat. Seteaza-ti parola .");
            string parolaNoua = Console.ReadLine();
            contBancar.SchimbaParola("0000", parolaNoua);
            log.Info($"B. Cont nou {contBancar.Nume} - {contBancar.Moneda} = {contBancar.CodBancar}");
            Console.WriteLine($"Cont nou {contBancar.Nume} - {contBancar.Moneda} = {contBancar.CodBancar}");
            //salvare
            db.ConturiBancare.Add(contBancar);
            db.SaveData();
        }
        public static void StergeCont(Date db)
        {
            ContBancar contDeSters = LogheazaUtilizator(db);
            if (contDeSters == null)
            {
                Console.WriteLine($"Contul pe care vreti sa il stergeti nu EXISTA.");
                log.Info($"Contul pe care vreti sa il stergeti nu EXISTA.");
                return;
            }

            db.ConturiBancare.Remove(contDeSters);
            db.SaveData();

            log.Info($"Contul {contDeSters.Nume} - {contDeSters.Moneda} - {contDeSters.CodBancar} a fost sters.");
            Console.WriteLine($"Contul {contDeSters.Nume} - {contDeSters.Moneda} - {contDeSters.CodBancar} a fost sters.");

        }
        public static ContBancar LogheazaUtilizator(Date db)
        {
            Console.WriteLine($"Nume utilizator: ");
            string utilizator = Console.ReadLine();
            Console.WriteLine($"Parola: ");
            string parola = Console.ReadLine();
            ContBancar contDeVerificat = db.ConturiBancare.FirstOrDefault(cont => cont.Nume == utilizator && cont.Parola == parola);
            return contDeVerificat;
        }
        public static void DepunereNumerar(Date db)
        {
            ContBancar contDeAlimentat = LogheazaUtilizator(db);
            if (contDeAlimentat != null) //am gasit contul...
            {
                Console.WriteLine("Ce suma vreti sa depuneti?");
                string sumaString = Console.ReadLine();
                int suma = 0;
                if (int.TryParse(sumaString, out suma))
                {
                    if (suma <= 0)
                    {
                        Console.WriteLine("Suma introdusa este mai mica decat 0");
                        log.Info("Suma introdusa este mai mica decat 0");
                        return;
                    }
                    else
                    {
                        contDeAlimentat.DepunereNumerar(suma);
                        db.SaveData();
                        Console.WriteLine($"A fost depusa suma {suma} in contul {contDeAlimentat.CodBancar}");
                        log.Info($"Contul {contDeAlimentat.CodBancar} a fost alimentat cu suma {suma}.");
                    }
                }
                else
                {
                    Console.WriteLine($"Nu ati introdus o suma corecta");
                    log.Info($"Nu ati introdus o suma corecta");
                }

            }
            else // nu l-am gasit
            {

            }
        }
        public static void RetragereNumerar(Date db)
        {
            ContBancar contBancar = LogheazaUtilizator(db);
            Console.WriteLine($"Ce suma doriti sa retrageti?");
            string sumaString = Console.ReadLine();
            int sumaDeRetras = 0;
            if (!int.TryParse(sumaString, out sumaDeRetras))
            {
                Console.WriteLine("Suma introdusa de tine este invalida");
                log.Warn($"Suma {sumaString} introdusa este invalida");
                return;
            }

            if (contBancar == null)
            {
                Console.WriteLine($"Contul bancar nu a fost gasit.");
                log.Warn($"Contul bancar nu a fost gasit.");
                return;
            }

            bool rezultatRetragere = contBancar.RegtragereNumerar(sumaDeRetras);

            if (rezultatRetragere)
            {
                Console.WriteLine($"Suma {sumaDeRetras} a fost retrasa cu success");
                log.Info($"Suma {sumaDeRetras} a fost retrasa cu success");
                db.SaveData();
            }
            else
            {
                Console.WriteLine($"Suma nu a fost retrasa");
                log.Warn($"Suma nu a fost retrasa");
            }
        }
    }
    public enum TipModificareNumerar
    {
        Depunere,
        Retragere
    }
}
