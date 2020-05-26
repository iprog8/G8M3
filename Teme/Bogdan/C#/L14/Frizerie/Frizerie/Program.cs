using System;

namespace Frizerie
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            client1.Nume = "Vasile";
            client1.Prenume = "Dragos";

            Client client2 = new Client();
            client2.Nume = "Motomeanu";
            client2.Prenume = "Marius";

            Client client3 = new Client();
            client3.Nume = "Ghilicica";
            client3.Prenume = "Bogdan";

            Client client4 = new Client();
            client4.Nume = "Musat";
            client4.Prenume = "Ciprian";

            Client client5 = new Client();
            client5.Nume = "Visescu";
            client5.Prenume = "Adrian";

            Client client6 = new Client();
            client6.Nume = "Leonte";
            client6.Prenume = "Ionut";

            Frizer frizer1 = new Frizer();
            frizer1.Nume = "Fuerea";
            frizer1.Prenume = "Marin";
            frizer1.Schimb = "1";
            frizer1.Dexteritate = "Expert";

            Frizer frizer2 = new Frizer();
            frizer2.Nume = "Calciu";
            frizer2.Prenume = "Petrut";
            frizer2.Schimb = "1";
            frizer2.Dexteritate = "Incepator";

            Frizer frizer3 = new Frizer();
            frizer3.Nume = "Valcu";
            frizer3.Prenume = "Florin";
            frizer3.Schimb = "1";
            frizer3.Dexteritate = "Mediocru";

            Frizer frizer4 = new Frizer();
            frizer4.Nume = "Rusen";
            frizer4.Prenume = "George";
            frizer4.Schimb = "2";
            frizer4.Dexteritate = "Mediocru";

            Frizer frizer5 = new Frizer();
            frizer5.Nume = "Craciun";
            frizer5.Prenume = "Ion";
            frizer5.Schimb = "2";
            frizer5.Dexteritate = "Expert";

            ScaunFrizerie scaun1 = new ScaunFrizerie();
            scaun1.FrizerDisponibil = Schimb();

            Frizerie frizerie = new Frizerie();
            frizerie.Nume = "Barber Shop";

            bool Schimb(Frizer schimb)
            {
                if (Frizerie.timp < 540) &(Frizerie.timp > 1200)
                {
                    Console.WriteLine($"Frizeria {frizerie.Nume} este inchisa, va rugam sa consultati programul.");
                    return false;
                }
                else if (Frizerie.timp >= 540) &(Frizerie.timp <= 1200)
                {
                    if (Frizerie.timp < 1020)
                    {
                        Console.WriteLine("In frizerie se lucreaza schimbul 1");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("In frizerie se lucreaza schimbul 2");
                        return true;
                    }
                }
            }
        }
    }
}
