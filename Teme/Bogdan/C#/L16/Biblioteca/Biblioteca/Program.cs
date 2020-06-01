using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)         // N-am stiut cum sa transform lista de carti disponibile intr-o lista tip int ca sa fac referire la cartile din biblioteca
        {
            List<Carte> CartiDisponibile = new List<Carte>();
            Carte ManifestderKommunistischenPartei = new Carte("Manifestul Partidului Comunist", "Karl Marx si Friedrich Engels", 304, 2002, 5, /*5,*/ "Document", "Politica", "Penguin Books", false);
            CartiDisponibile.Add(ManifestderKommunistischenPartei);
            Carte ZarathustraEinBuchfürAlleundKeinen = new Carte("Asa grait-a Zarathustra", "Friedrich Nietzsche", 392, 2019, 3, /*2,*/ "Nuvela filosofica", "Filosofie", "Humanitas", false);
            CartiDisponibile.Add(ZarathustraEinBuchfürAlleundKeinen);
            Carte VorlesungenzurEinführungindiePsychoanalyseUndNeueFolge = new Carte("Introducere in psihanaliza", "Sigmund Freud", 664, 2010, 1, /*0,*/ "Psihanaliza", "Psihologie", "Trei", true);
            CartiDisponibile.Add(VorlesungenzurEinführungindiePsychoanalyseUndNeueFolge);
            Carte 生き甲斐 = new Carte("Ikigai", "Garcia Hector si Francesc Miralles", 176, 2017, 5, /*3,*/ "Self Help", "Dezvoltare personala", "Humanitas", true);
            CartiDisponibile.Add(生き甲斐);
            Carte StaringAtTheSun = new Carte("Privind soarele in fata", "Irvin Yalom", 240, 2011, 2, /*2,*/ "Ezoterism", "Dezvoltare personala", "Vellant", true);
            CartiDisponibile.Add(StaringAtTheSun);
            Carte TheSixPillarsofSelfEsteem = new Carte("Cei sase stalpi ai increderii in sine", "Nathaniel Branden", 352, 2008, 4, /*1,*/ "Self Help", "Psihologie", "Amsta", false);
            CartiDisponibile.Add(TheSixPillarsofSelfEsteem);

            CititorSimplu Cristian = new CititorSimplu("Avram", "Cristian", 0, 3);
            CititorSimplu Rudi = new CititorSimplu("Rudi", "Ovidiu", 2, 0);
            CititorSimplu Gabi = new CititorSimplu("Hanu", "Gabriel", 1, 5);
            CititorSimplu Mioara = new CititorSimplu("Manuela", "Mioara", 1, 3);
            CititorSimplu Letitia = new CititorSimplu("Provian", "Letitia", 0, 2);
            CititorSimplu Vlad = new CititorSimplu("Octavian", "Vlad", 0, 1);

            Bibliotecar Bogdan = new Bibliotecar("Geagu Bogdan", "Pasteluri bacoviene", false);

            bool DeschidemBiblioteca(Bibliotecar bibliotecar)
            {
                Console.WriteLine("Doriti sa deschideti biblioteca?");
                Console.WriteLine("1.Da    2.Nu");
                ConsoleKeyInfo tastaApasata = Console.ReadKey();
                if(tastaApasata.Key == ConsoleKey.D1)
                {
                    Bogdan.IntraInBiblioteca();
                    Console.ReadKey();
                    return true;
                }
                else if(tastaApasata.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Ati selectat ca biblioteca sa ramana inchisa.");
                    Console.WriteLine();
                    Console.WriteLine("V-ati razgandit? Apasati orice tasta pentru a vi se afisa meniul.");
                    Console.ReadKey();
                    DeschidemBiblioteca(bibliotecar);
                    return false;
                }
                else
                {
                    Console.WriteLine("Nu ati selectat dintre optiunile afisate, va rugam reveniti.");
                    Console.WriteLine();
                    Console.WriteLine("V-ati razgandit? Apasati orice tasta pentru a vi se afisa meniul.");
                    Console.ReadKey();
                    DeschidemBiblioteca(bibliotecar);
                    return false;
                }
            }
            DeschidemBiblioteca(Bogdan);
            Vlad.IntraInBiblioteca();
            Bogdan.DoritiOCarte(Vlad);
            Bogdan.AreMembership(Vlad);
            Vlad.PoateImprumutaCartea();
            if((Vlad.Membership == 0) && (Vlad.CartiImprumutate == 3))
            {
                Console.WriteLine($"Ati atins limita de {Vlad.CartiImprumutate} carti, nu mai puteti imprumuta alte titluri" +
                        $"pana nu returnati cel putin una dintre ele sau achizitionati abonamentul de membru VIP.");
                Console.WriteLine("Doriti sa deveniti membru VIP?  1.Da    2.Nu");
                ConsoleKeyInfo tastaApasata = Console.ReadKey();
                if (tastaApasata.Key == ConsoleKey.D1)
                {
                    Vlad.Membership = 1;
                    Console.WriteLine("Felicitari! Sunteti membru VIP!");
                    Vlad.PoateImprumutaCartea();
                }
                else
                {
                    Console.WriteLine("Returnati din carti pentru a putea imprumuta altele.");
                }
            }
            else
            {
                Vlad.CartiImprumutate = Bibliotecar.ImprumutaCartea(生き甲斐);
            }
        }
    }
}