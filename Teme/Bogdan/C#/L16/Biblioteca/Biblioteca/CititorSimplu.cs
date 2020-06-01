using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class CititorSimplu
    {
        protected internal string Nume { get; set; }
        protected internal string Prenume { get; set; }
        protected internal ushort Membership { get; internal set; }
        protected internal ushort CartiImprumutate { get; internal set; }
        protected internal bool EsteInBiblioteca { get; set; }
        protected internal bool CitesteInBiblioteca { get; set; }
        protected internal bool CitesteAcasa { get; internal set; }

        protected internal bool IntraInBiblioteca()
        {
            Console.WriteLine($"{Nume} {Prenume} a intrat in biblioteca.");
            EsteInBiblioteca = true;
            return EsteInBiblioteca;
        }

        protected internal bool InBibliotecaCiteste(CititorSimplu cititor)
        {
            Console.WriteLine($"{Nume} {Prenume} citeste cartea in biblioteca.");
            CitesteInBiblioteca = true;
            return CitesteInBiblioteca;
        }

        protected internal bool AcasaCiteste(CititorSimplu cititor)
        {
            Console.WriteLine($"{Nume} {Prenume} citeste cartea acasa.");
            CitesteAcasa = true;
            return CitesteAcasa;
        }
        public CititorSimplu(string _nume, string _prenume, ushort _membership, ushort _cartiImprumutate)
        {
            Nume = _nume;
            Prenume = _prenume;
            Membership = _membership;
            CartiImprumutate = _cartiImprumutate;
        }

        protected internal ushort PoateImprumutaCartea()
        {
            if(Membership == 0)
            {
                if (CartiImprumutate == 3)
                {
                    Console.WriteLine($"Ati atins limita de {CartiImprumutate} carti, nu mai puteti imprumuta alte titluri" +
                        $"pana nu returnati cel putin una dintre ele sau achizitionati abonamentul de membru VIP.");
                    Console.WriteLine("Doriti sa deveniti membru VIP?  1.Da    2.Nu");
                    ConsoleKeyInfo tastaApasata = Console.ReadKey();
                    if(tastaApasata.Key == ConsoleKey.D1)
                    {
                        Membership = 1;
                        Console.WriteLine("Felicitari! Sunteti membru VIP!");
                        PoateImprumutaCartea();
                        return Membership;
                    }
                    else
                    {
                        Console.WriteLine("Returnati din carti pentru a putea imprumuta altele.");
                    }
                    return CartiImprumutate;
                }
                else
                {
                    CartiImprumutate++;
                    Console.WriteLine($"In momentul de fata ati imprumutat {CartiImprumutate} carti, limita fiind de 3. " +
                        $"In cazul in care doriti sa aveti acces nelimitat va recomandam achizitionarea abonamentului de VIP.");
                    return CartiImprumutate;
                }
            }
            else if (Membership == 2)
            {
                Console.WriteLine("Puteti folosi biblioteca doar in calitate de membru.");  //ar fi trebuit metoda aici
                Console.WriteLine("Doriti sa deveniti membru? 1.Da  2.Nu");
                ConsoleKeyInfo tastaApasata = Console.ReadKey();
                if (tastaApasata.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Felicitari ! Ati devenit membru.");
                    Membership = 0;
                    PoateImprumutaCartea();
                    return CartiImprumutate;
                }
                else if (tastaApasata.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Nu puteti imprumuta sau folosi cartile noastre decat in calitate de membru.");
                    Console.WriteLine("In cazul in care va razganditi suntem aici pentru a va ajuta.");
                    PoateImprumutaCartea();
                    return CartiImprumutate;
                }
                else
                {
                    Console.WriteLine("Nu ati ales din variantele prezentate. Va rugam reveniti.");
                    PoateImprumutaCartea();
                    return CartiImprumutate;
                }
            }
            else
            {
                Console.WriteLine("Sunteti membru VIP, aveti acces nelimitat la numarul de carti imprumutate cat si optiunea de a alege orice titlu din biblioteca noasta.");
                return CartiImprumutate;
            }
        }
        protected internal ushort ReturneazaCartea()
        {
        if(CartiImprumutate == 0)
            {
                Console.WriteLine("Nu aveti carti de returnat.");
                return CartiImprumutate;
            }
            else
            {
                Console.WriteLine("Va multumim ca ati returnat cartea si dati posibilitatea si altora s-o citeasca.");
                if ((Membership == 0) || (Membership == 1))
                {
                    if (CartiImprumutate > 2)
                    {
                        CartiImprumutate--;
                        Console.WriteLine($"In momentul de fata mai aveti de returnat {CartiImprumutate} carti.");
                        return CartiImprumutate;
                    }
                    else if (CartiImprumutate == 2)
                    {
                        CartiImprumutate--;
                        Console.WriteLine("In momentul de fata mai aveti de retunat o carte.");
                        return CartiImprumutate;
                    }
                    else
                    {
                        CartiImprumutate--;
                        Console.WriteLine("Ati returnat toate cartile, va multumim!");
                        return CartiImprumutate;
                    }
                }
                else
                {
                    Console.WriteLine("Puteti folosi biblioteca doar in calitate de membru.");  //ar fi trebuit metoda aici
                    Console.WriteLine("Doriti sa deveniti membru? 1.Da  2.Nu");
                    ConsoleKeyInfo tastaApasata = Console.ReadKey();
                    if(tastaApasata.Key == ConsoleKey.D1 )
                    {
                        Console.WriteLine("Felicitari ! Ati devenit membru.");
                        Membership = 0;
                        return CartiImprumutate;
                    }
                    else if(tastaApasata.Key == ConsoleKey.D2)
                    {
                        Console.WriteLine("In cazul in care va razganditi suntem aici pentru a va ajuta.");
                        Membership = 2;
                        return CartiImprumutate;
                    }
                    else
                    {
                        Console.WriteLine("Nu ati ales din variantele prezentate. Va rugam reveniti.");
                        return CartiImprumutate;
                    }
                }
            }
        }
        protected internal void CitesteCarteaInBiblioteca()
        {
            Console.WriteLine("Aveti acces la toate titlurile disponibile in biblioteca.");
        }
    }
}
