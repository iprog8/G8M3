using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Om
    {
        DateTime dataNastere;
        public int Varsta { 
            get
            {
                return (DateTime.Today - dataNastere).Days / 365;
            }
        }
        //prenume
        public string Prenume { get; }


    }
}
