using BazaDate;
using log4net;
using log4net.Config;
using LogicaBanca;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
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

        static void TestCard()
        {
            ContBancar cb = new ContBancar();
            cb.Nume = "ana";
            cb.DepunereNumerar(100);
            CardDebit cardDebit = new CardDebit(cb);
            decimal sold = cardDebit.Sold;
            sold = cardDebit.ContBancar.Sold;
            string nume = cardDebit.Nume;
            nume = cardDebit.ContBancar.Nume;
        }

        static void Main(string[] args)
        {
            //TestCard();
            Date db = Date.LoadData<Date>(nameof(Date));
            AlegeOperatiune(db);

            log.Info($"Main: App Banca stopped {Environment.UserDomainName}.{Environment.UserName}");
        }

        private static void AlegeOperatiune(Date db)
        {
            Console.WriteLine("Ce doriti?");
            Console.WriteLine("1. Creare cont bancar");
            Console.WriteLine("2. Sterge cont bancar");
            Console.WriteLine("3. Transfer bancar");
            Console.WriteLine("4. Schimba parola");
            Console.WriteLine("5. Depunere numerar");
            Console.WriteLine("6. Retragere numerar");
            Console.WriteLine("7. Verifica sold");
            Console.WriteLine("8. Transfera interbancar");
            Console.WriteLine("9.Transfer local");
            Console.WriteLine("Tastati cifra din fata operatiunii pt a alege");
            ConsoleKeyInfo tastaApasata = Console.ReadKey();
            switch (tastaApasata.Key)
            {
                case ConsoleKey.D1:
                    log.Info("A. Utilizatorul a ales optinea creare cont.");
                    CreareContBancar(db);
                    break;
                case ConsoleKey.D2:
                    log.Info("A. Utilizatorul a ales optinea sterge cont.");
                    StergeCont(db);
                    break;
                case ConsoleKey.D3:
                    log.Info("A. Utilizatorul a ales optinea transfer bancar.");
                    break;
                case ConsoleKey.D4:
                    log.Info("A. Utilizatorul a ales optinea schimba parola.");
                    SchimbaParola(db);
                    break;
                case ConsoleKey.D5:
                    log.Info("A. Utilizatorul a ales optiunea depunere numerar.");
                    DepunereNumerar(db);
                    break;
                case ConsoleKey.D6:
                    log.Info("A. Utilizatorul a ales optiunea retragere numerar.");
                    RetragereNumerar(db);
                    break;
                case ConsoleKey.D7:
                    log.Info("A. Utilizatorul a ales optiunea de a-si verifica soldul curent.");
                    VerificaSold(db);
                    break;
                case ConsoleKey.D8:
                    log.Info("A. Utilizatorul a ales optiunea de a face un transfer interbancar");
                    TransferInterbancar(db);
                    break;
                case ConsoleKey.D9:
                    log.Info("A. Utilizatorul a ales optiunea de a face un transfer local");
                    TransferLocal(db);
                    break;
                default:
                    log.Info("A. Utilizatorul Nu a selectat nici optiune valida.");
                    Console.WriteLine("Nu ati selectat nici optiune valida");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Doriti o noua operatiune? Y/N");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Y)
            {
                AlegeOperatiune(db);
            }
        }

        private static void VerificaSold(Date db)
        {
            Console.WriteLine("Care este numele dvs?");
            string numeUtilizator = Console.ReadLine();
            Console.WriteLine("Care este parola dvs?");
            string parolaUtilizator = Console.ReadLine();
            ContBancar contDeVerificat = null;
            foreach (var cont in db.ConturiBancare)
            {
                if (cont.Nume == numeUtilizator && cont.Parola == parolaUtilizator)
                {
                     contDeVerificat = cont;
                    break;
                }
            }
            if (contDeVerificat == null)
            {
                Console.WriteLine("Contul nu a fost gasit");
                log.Warn("Contul nu a fost gasit");
            }
            else
            {
                Console.WriteLine($"Soldul este {contDeVerificat.Sold}");
                log.Info($"Soldul este {contDeVerificat.Sold}");
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
                if(cont.Nume == numeUtilizator)
                {
                    contCautat = cont;
                    break;
                }
            }
            if(contCautat == null)
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

        public static void StergeCont( Date db)
        {
            Console.WriteLine("Care este numele dvs?");
            string numeUtilizator = Console.ReadLine();
            Console.WriteLine("Care este parola contului dvs?");
            string parola = Console.ReadLine();
            ContBancar contDeSters = null;
            foreach (var cont in db.ConturiBancare)
            {
                if (cont.Nume == numeUtilizator && parola == cont.Parola)
                {
                    contDeSters = cont;
                    break;
                }
            }

            if(contDeSters == null)
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

        public static void DepunereNumerar(Date db)
        {
            Console.WriteLine("Care este numele dvs?");
            string numeUtilizator = Console.ReadLine();
            Console.WriteLine("Care este parola contului dvs ?");
            string parola = Console.ReadLine();
            ContBancar contDeAlimentat = null;
            foreach (var cont in db.ConturiBancare)
            { 
                if (cont.Nume == numeUtilizator && parola == cont.Parola)
                {
                    contDeAlimentat = cont;
                    break;
                }

            }
            if(contDeAlimentat != null) //am gasit contul...
            {
                Console.WriteLine("Ce suma vreti sa depuneti?");
                string sumaString  = Console.ReadLine();
                int suma = 0;
                if(int.TryParse(sumaString, out suma))
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
            Console.WriteLine($"Nume utilizator: ");
            string utilizator = Console.ReadLine();
            Console.WriteLine($"Parola: ");
            string parola = Console.ReadLine();
            Console.WriteLine($"Ce suma doriti sa retrageti?");
            string sumaString = Console.ReadLine();
            int sumaDeRetras = 0;
            if(!int.TryParse(sumaString, out sumaDeRetras))
            {
                Console.WriteLine("Suma introdusa de tine este invalida");
                log.Warn($"Suma {sumaString} introdusa este invalida");
                return;
            }

            ContBancar contBancar = null;
            foreach (var cont in db.ConturiBancare)
            {
                if (cont.Nume == utilizator && cont.Parola == parola)
                {
                    contBancar = cont;
                    break;
                }
            }

            //ContBancar contBancar = db.ConturiBancare.FirstOrDefault(cont => cont.Nume == utilizator && cont.Parola == parola);

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
        private static void TransferLocal(Date db)
        {
            string message = string.Empty;
            Console.WriteLine("Introaduceti numele utilizatorului.");
            string numeUtilizator = Console.ReadLine();
            Console.WriteLine("Introduceti parola");
            string parola = Console.ReadLine();
            ContBancar contInitializator = null;
            foreach(var contCautat in db.ConturiBancare)
            {
                if((numeUtilizator == contCautat.Nume) && (parola == contCautat.Parola)) 
                {
                    contInitializator = contCautat;
                    break;
                }
            }
            //aici anunt utilizatorul ca nu am gasit contul conform cu datele trimise de el
            if (contInitializator == null)
            {
                Console.WriteLine("Contul nu a fost gasit.");
                log.Warn("Nu exista contul in baza de date.");
                return;
            }
            //aici cer utilizatorului sa imi zica iban-ul in care vrea sa transfere bani
            Console.WriteLine("Introduceti codul IBAN aferent contului in care doriti sa transferati bani.");
            string contIban = Console.ReadLine();
            ContBancar contReceptor = null;
            //aici vreau sa caut contul in care vreau sa trimit bani
            foreach(var contCautat in db.ConturiBancare)
            {
                if(contIban == contCautat.CodBancar)
                {
                    contReceptor = contCautat;
                    break;
                }
            }
            if(contReceptor == null)
            {
                Console.WriteLine("Contul nu a fost gasit.");
                log.Warn("Contul nu a fost gasit.");
                return;
            }
            Console.WriteLine("Ce suma doriti sa transferati?");
            string sumaDeTransferatString = Console.ReadLine();
            bool sumaTransferata = int.TryParse(sumaDeTransferatString, out int sumaDeTransferat);
            if(sumaTransferata == true)
            {
                RaspunsComplex raspuns = contInitializator.TransferaLocal(sumaDeTransferat, contReceptor);
                if (raspuns.Succes)
                {
                    db.SaveData();
                    Console.WriteLine(raspuns.Mesaj);
                    log.Info(raspuns.Mesaj);
                }
                else
                {
                    Console.WriteLine(raspuns.Mesaj);
                    log.Warn(raspuns.Mesaj);
                }
            }
            else
            {
                message = $"Suma introdusa nu este valida.";
                Console.WriteLine(message);
                log.Warn(message);
            }
        }
        private static void TransferInterbancar(Date db)
        {
            string message = string.Empty;
            Console.WriteLine("Care este numele dvs?");
            string numeUtilizator = Console.ReadLine();
            Console.WriteLine("Care este parola dvs?");
            string parola = Console.ReadLine();
            ContBancar contInitializator = null;
            foreach (var cont in db.ConturiBancare)
            {
                if( numeUtilizator == cont.Nume &&parola ==cont.Parola)
                {
                    contInitializator = cont;
                    break;
                }
            }
            if (contInitializator == null)
            {
                message = $"Contul cautat nu a fost gasit.";
                Console.WriteLine(message);
                log.Warn(message);
                return;
            }
            Console.WriteLine("Introduceti contul Iban");
            string iban = Console.ReadLine();
            Console.WriteLine("Introduceti suma pe care vreti sa o transferati.");
            string sumaDeTransferatstring = Console.ReadLine();
            bool sumaTransferata = int.TryParse(sumaDeTransferatstring, out int sumaDeTransferat);
            if (sumaTransferata == true)
            {
                Tranzactie tranzactie = contInitializator.TransferaInterbancar(sumaDeTransferat, iban);
                if (tranzactie != null)
                {
                    db.Tranzactii.Add(tranzactie);
                    db.SaveData();
                    message = "Tranzactia fost trimisa catre procesare.";
                    Console.WriteLine(message);
                    log.Info(message);
                }
                else
                {
                    message = "Tranzactie esuata";
                    Console.WriteLine(message);
                    log.Warn(message);
                }
            }

        }
    }
}
