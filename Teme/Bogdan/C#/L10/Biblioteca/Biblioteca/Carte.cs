using System;

namespace Biblioteca
{
    public class Carte
    {
        public string nume;
        public string autor;
        public uint an;
        public ushort numarPagini;
        public bool seUzeaza(Carte carte)
        {
            Console.WriteLine("In timp cartea se va uza, dar placerea cititului va ramane nemuritoare!");
            return true;
        }
    }
}
