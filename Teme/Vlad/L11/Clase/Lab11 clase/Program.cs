using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_clase
{
    class Program
    {
        static void Main()
        {
            Cumparator primulClient = new Cumparator();
            primulClient.nume = "Batranul";
            primulClient.prenume = "Mircea";
            primulClient.codClient = 12345;
            /*primulClient.dataNasterii =*/
            primulClient.Cumpara(5);
            primulClient.Citeste(2);

            Cumparator alDoileaClient = new Cumparator();
            alDoileaClient.nume = "Maretul";
            alDoileaClient.prenume = "Stefan";
            alDoileaClient.codClient = 12345;
            alDoileaClient.Cumpara(10);
            alDoileaClient.Citeste(4);

            Carte primaCarte = new Carte();
            primaCarte.nume = "Contele de Monte Cristo";
            primaCarte.an = 1846;
            primaCarte.SeUzeaza();

            Carte aDouaCarte = new Carte();
            aDouaCarte.SeUzeaza();

            Console.WriteLine($"Clientul {primulClient.nume}  a cumparat {primaCarte.nume}, aparuta prima oara in {primaCarte.an}");
            Console.ReadKey();
        }
    }
}
