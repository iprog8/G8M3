namespace Teatru
{
    class Program
    {
        static void Main(string[] args)
        {
            Piesa LaTiganci = new Piesa();
            LaTiganci.Titlu = "La țigănci";
            LaTiganci.Regizor = "Andrei și Andreea Grosu";

            /*List<Piesa> ListaActori  = new List<Piesa>();
            Piesa RichardBovnoczki = new Piesa();
            ListaActori.Add(RichardBovnoczki);
            Piesa LiviuPintileasa = new Piesa();
            ListaActori.Add(LiviuPintileasa);
            Piesa MihaelaTrofimov = new Piesa();
            ListaActori.Add(MihaelaTrofimov);
            Piesa FlorentinaTilea = new Piesa();
            ListaActori.Add(FlorentinaTilea);
            Piesa FlorinaGleznea = new Piesa();
            ListaActori.Add(FlorinaGleznea);
            Piesa CristinaCasian = new Piesa();
            ListaActori.Add(CristinaCasian);
            Piesa BogdanCotlet = new Piesa();
            ListaActori.Add(BogdanCotlet);

            void actoriiDinPiesa(List<Piesa> actoriPiesa)
            {
                foreach (object Piesa in ListaActori)
                {
                    Console.WriteLine(ListaActori);
                }
            }

            actoriiDinPiesa(ListaActori);
            Console.ReadLine();*/

            LaTiganci.LocuriDisponibile = 20;
            LaTiganci.LocuriDisponibile = LaTiganci.Bilete;
            LaTiganci.TaxaDeAcces = 27.50;


            Bilet BiletIntrare = new Bilet();
            BiletIntrare.Piesa = "La țigănci";
            BiletIntrare.Loc = LaTiganci.Bilete;
            BiletIntrare.PretBilet = LaTiganci.TaxaDeAcces;
            BiletIntrare.Vandut = false;

        }
    }
}
