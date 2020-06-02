using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca("Biblioteca Nationala a Romaniei");
            biblioteca.Bibliotecari = new List<Bibliotecar>();
            biblioteca.Carti = new List<Carte>();
            Bibliotecar bibliotecar1 = new Bibliotecar("Ion");
            biblioteca.Bibliotecari.Add(bibliotecar1);
            CititorSimplu primulCititor = new CititorSimplu("Matei");
            primulCititor.CartiImprumutate = new List<Carte>();
            CititorVip alDoileaCititor = new CititorVip("Mirel");
            alDoileaCititor.CartiDeCititInSalaDeLectura = new List<CarteNeimprumutabila>();
            alDoileaCititor.CartiImprumutate = new List<Carte>();
            Carte carteNormala = new Carte("Sase Lectii Usoare", "Richar P. Feynman", 180, "Humanitas", DateTime.Today);
            biblioteca.Carti.Add(carteNormala);
            Carte carteNormala2 = new Carte("Defecti", "Cecilia Ahern", 413, "Grupul Editorial All", DateTime.Today);
            biblioteca.Carti.Add(carteNormala2);
            CarteImprumutabila carteImprumutabila = new CarteImprumutabila("Culegere Probleme Matematica Liceu","C. Nita",300,"Rotech Pro",DateTime.Today);
            biblioteca.Carti.Add(carteImprumutabila);
            CarteNeimprumutabila carteNeimprumutabila = new CarteNeimprumutabila("Linux Bible", "Christopher Negus", 860, "Wiley", DateTime.Today);
            biblioteca.Carti.Add(carteNeimprumutabila);
            biblioteca.StareBiblioteca =  bibliotecar1.InchideDeschideBiblioteca(biblioteca);
            bibliotecar1.IntraIeseDinBiblioteca(biblioteca);
            primulCititor.EsteInBiblioteca = primulCititor.IntraIeseDinBiblioteca(biblioteca);
            alDoileaCititor.EsteInBiblioteca = alDoileaCititor.IntraIeseDinBiblioteca(biblioteca);
            primulCititor.Abonament = bibliotecar1.CreazaAbonamentSimplu(primulCititor);
            alDoileaCititor.Abonament = bibliotecar1.CreeazaAbonamentVip(alDoileaCititor);
            primulCititor.CartiImprumutate.Add(primulCititor.ImprumutaCarte(carteImprumutabila, biblioteca));
            carteNormala2.Stare = primulCititor.Citeste(carteNormala2);
            alDoileaCititor.EsteInSalaLectura = alDoileaCititor.IntraIeseDinSalaDeLectura();
            carteNeimprumutabila.Stare = alDoileaCititor.CitesteCarteInSalaDeLectura(carteNeimprumutabila);
            alDoileaCititor.CartiDeCititInSalaDeLectura.Remove(alDoileaCititor.InapoiazaCarteaDinSalaDeLectura(carteNeimprumutabila));
            alDoileaCititor.EsteInSalaLectura = alDoileaCititor.IntraIeseDinSalaDeLectura();
            primulCititor.EsteInBiblioteca = primulCititor.IntraIeseDinBiblioteca(biblioteca);
            alDoileaCititor.EsteInBiblioteca = alDoileaCititor.IntraIeseDinBiblioteca(biblioteca);
            Console.ReadKey();
        }
    }
}
