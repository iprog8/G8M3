using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenimentele
{
    class Program
    {
        static void Main(string[] args)
        {
            //some code here...
            //Console.OnCancelKeyPress = "asdf()";
            Console.CancelKeyPress += CantaBeep;
            Console.CancelKeyPress += AfiseazaMesajDeAtentionare;
            Console.ReadKey();
        }

        private static void AfiseazaMesajDeAtentionare(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("Atetine cconsola se va inchide la prima apasare de tasta");
        }

        static void CantaBeep(object sender, ConsoleCancelEventArgs eventInfo)
        {
            Console.Beep();
        }
    }
}
