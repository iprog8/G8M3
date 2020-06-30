using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat
{
    class Razboinic: Luptator
    {
        public uint Atac = 15;
        public uint Viata = 100;
        public uint Stamina = 50;
        public bool PareazaAtac()
        {
            
        }
        public uint AtacInitiat()
        {
         if (this.Stamina <= 10)
            {
                Atac = 7;
                Console.WriteLine($"Atacul initiat de razboinicul {Nume} a produs un atac de 7");
                return Atac;
            }
         else
            {
                this.Atac = 15;
                Stamina = Stamina - 10;
                Console.WriteLine($"Atacul initiat de razboinicul {Nume} a produs un atac de 15, iar stamina ramasa este : {Stamina}");
                return Atac;
            }
        }
    }
}
