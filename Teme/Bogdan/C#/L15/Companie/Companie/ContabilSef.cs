using System;

namespace Companie
{
    class ContabilSef : Contabil
    {
        protected internal ushort Declaratii { get; private set; }
        protected internal ushort FaceDeClaratii(ContabilSef contabilSef)
        {
            Console.WriteLine($"Contabilul sef {contabilSef.Nume} {contabilSef.Prenume} a emis o declaratie.");
            ushort declaratiiEmise = contabilSef.Declaratii++;
            return declaratiiEmise;
        }
        protected internal bool DepunelaANAF(ContabilSef contabilSef)
        {
            if (Declaratii > 0)
            {
                Console.WriteLine($"Contabilul sef {contabilSef.Nume} {contabilSef.Prenume} a depus la ANAF declaratiile.");
                return true;
            }
            else
            {
                Console.WriteLine($"Nu exista declaratii de depus la ANAF");
                return false;
            }
        }
    }
}
