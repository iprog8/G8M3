using System;

namespace Biblioteca
{
    public class Carte
    {
        public string nume;
        public string autor;
        public uint an;
        public ushort numarPagini;
        public bool seUzeaza(string codCLient)
        {
            Console.WriteLine($"Cumparatorul {codCLient} citeste {nume} scrisa de {autor}");
            return true;
        }
    }
}
