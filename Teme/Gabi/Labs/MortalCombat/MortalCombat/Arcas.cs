using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    public class Arcas : Luptator, ICaracter
    {
        public Arcas(string nume)
        {
            IViata = 100;
            IBasicAtac = 14;
            Nume = nume;
        }
        private int ViataInPlus = 25;
        private int AtacInPlus = 9;
        private int viata;
        private int putereSpeciala;
        public override int IPutereSpeciala {
            get
            {
                return IBasicAtac + AtacInPlus;
            }
            set
            {
                putereSpeciala = value;
            }
        }
        public override int IViata {
            get
            {
                return viata;
            }
            set
            {
                if (value > 0 && value < 101)
                {
                    viata = value;     
                }
                else if (value <= 0)
                {
                    viata = 0;
                }
            } 
        }
        public override int IFolosestePutereSpeciala()
        {
            Console.WriteLine($"{Nume} si-a regenerat viata cu {ViataInPlus} si si-a marit puterea de atac cu {AtacInPlus}");
            IViata += 20;
            NumarAtacuriDate++;
            return IPutereSpeciala;
        }

    }
}
