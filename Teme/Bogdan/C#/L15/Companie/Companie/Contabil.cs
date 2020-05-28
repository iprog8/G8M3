using System;

namespace Companie
{
    class Contabil : Muncitor
    {
        protected internal ushort FacturiEmise { get; set; }
        protected internal ushort FacturiIntroduse { get; set; }
        protected internal ushort EmiteFacturi(Contabil contabil)
        {
            Console.WriteLine($"Contabilul {contabil.Nume} {contabil.Prenume} a emis o factura.");
            ushort facturiEmise = contabil.FacturiEmise++;
            return facturiEmise;
        }
        protected internal ushort IntroduceFacturi(Contabil contabil)
        {
            Console.WriteLine($"Contabilul {contabil.Nume} {contabil.Prenume} a introdus o factura in sistem.");
            contabil.FacturiIntroduse++;
            ushort facturiIntroduse = contabil.FacturiIntroduse++;
            return facturiIntroduse;
        }
    }
}
