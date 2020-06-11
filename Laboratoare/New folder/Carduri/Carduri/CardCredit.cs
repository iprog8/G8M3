using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carduri
{
    public class CardCredit: Card
    {
        public CardCredit(string nume, int salariu): base(nume)
        {
            OverDraft = 3 * salariu;
        }

        public decimal OverDraft { get; set; }


        public override decimal InterogareSold()
        {
            return Sold + OverDraft;
        }
        public override bool Plateste(int sumaDePlata, string pin)
        {
            if(PIN != pin)
            {
                return false;
            }
            if (sumaDePlata > Sold + OverDraft)
            {
                return false;
            }
            if (sumaDePlata < 1)
            {
                return false;
            }
            Sold = Sold - sumaDePlata;
            return true;
        }

        //overload

    }
}
