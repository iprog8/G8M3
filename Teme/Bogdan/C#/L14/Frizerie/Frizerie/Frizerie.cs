using System;

namespace Frizerie
{
    public class Frizerie
    {
        public string Nume { get; set; }
        public static int timp;

        public bool ProgramFrizerie()
        {
            Console.WriteLine("Va rugam sa setati ora cunoscand urmatoarele aspecte...");
            Console.WriteLine("Ora va fi exprimata in minute, ex 360 minute = ora 06:00");
            Console.WriteLine("Frizeria se deschide la ora 09:00 si se inchide la ora 20:00");
            Console.WriteLine("Toate programarile in intervalul in care frizeria este deschisa vor fi onorate.");
            string timpString = Console.ReadLine();
            timp = int.Parse(timpString);
            int ore = timp / 60;
            int secunde = timp % 60;
            if (timp < 540)
            {
                Console.WriteLine($"Frizeria {Nume} nu s-a deschis inca, va rugam sa mai asteptati.");
                return false;
            }
            else if (timp == 540)
            {
                Console.WriteLine($"La ora {ore}:{secunde}, frizeria este deschisa!");
                return true;
            }
            if (timp < 1200)
            {
                Console.WriteLine($"Este ora {ore} : {secunde}, frizeria este deschisa.");
                return true;
            }
            else
            {
                Console.WriteLine($"Frizeria {Nume} s-a inchis, reveniti si maine.");
                return false;
            }
        }

        public int ListaPreturi { get; set; }

    }
}
