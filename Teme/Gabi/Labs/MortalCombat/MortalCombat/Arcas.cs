using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    public class Arcas : Luptator
    {
        public Arcas(string nume)
        {
            IViata = 100;
            IBasicAtac = 12;
            Nume = nume;
        }
        private int ViataInPlus = 20;
        private int AtacInPlus = 7;
        private int viata;
        public override int IBasicAtac { get; set; }
        //public override int IPutereSpeciala { get; set; }
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
        public override int IAtaca()
        {
            return IBasicAtac;
        }
        public override int IFolosestePutereSpeciala()//puterea speciala a arcasului este de a 
        {
            Console.WriteLine($"{Nume} si-a regenerat viata cu {ViataInPlus} si si-a marit puterea de atac cu {AtacInPlus}");
            IViata += 20;
            return IBasicAtac + 7;
        }
    }
}
