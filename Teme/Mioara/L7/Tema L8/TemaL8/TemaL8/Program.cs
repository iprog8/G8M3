﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calcule;

namespace TemaL8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neata, C#!");
            Avion();
            Adunare aduna = new Adunare();
            int suma = aduna.Calculeaza(5, 7);

            Console.ReadKey();




        }
        static void Avion()
        {

        Console.WriteLine("Neata din avion!" );
        }
    }   
        

}

