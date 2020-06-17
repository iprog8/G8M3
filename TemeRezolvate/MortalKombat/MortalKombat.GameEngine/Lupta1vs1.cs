using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat.GameEngine
{
    public class Lupta1vs1 : ILupta
    {
        public Lupta1vs1(ILuptator luptator1, ILuptator luptator2)
        {
            Luptatorul1 = luptator1;
            Luptatorul2 = luptator2;
        }
        public ILuptator Luptatorul1 { get; protected set; }
        public ILuptator Luptatorul2 { get; protected set; }
        public ILuptator Castigator { get; protected set; }
        public ILuptator Desfasurare()
        {
            Desfasurare(Luptatorul1, Luptatorul2);
            return Castigator;
        }
        private bool Desfasurare(ILuptator luptatorul1, ILuptator luptatorul2)
        {
            luptatorul1.Ataca(luptatorul2);
            if (luptatorul2.Viata < 1)
            {
                Castigator = luptatorul1;
                return true;
            }
            luptatorul2.Ataca(luptatorul1);
            if (luptatorul1.Viata < 1)
            {
                Castigator = luptatorul2;
                return true;
            }
            return Desfasurare(luptatorul2, luptatorul1);
        }
    }
}
