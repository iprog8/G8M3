using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Frizerie
{
    class Program
    {
        static void Main(string[] args)
        {
            //create obiecte
            Frizerie FrizeriaMea = new Frizerie();
            FrizeriaMea.Clienti = new List<Client>();
            FrizeriaMea.Frizeri = new List<Frizer>();
            Client client1 = new Client("Gigel");
            Client client2 = new Client("Ionut");
            Client client3 = new Client("Marius");
            Client client4 = new Client("Ion");
            Frizer frizer1 = new Frizer("Tara", Sex.Feminin, 2);
            FrizeriaMea.Frizeri.Add(frizer1);
            frizer1.IntraInTura();
            Frizer frizer2 = new Frizer("Matei" ,Sex.Masculin, 1);
            FrizeriaMea.Frizeri.Add(frizer2);
            frizer2.IntraInTura();
            Frizer frizer3 = new Frizer("Mirel",Sex.Masculin, 4);
            FrizeriaMea.Frizeri.Add(frizer3);
            frizer3.IntraInTura();
            Frizer frizer4 = new Frizer("Bari",Sex.Masculin,6);
            FrizeriaMea.Frizeri.Add(frizer4);
            frizer4.IntraInTura();
            //folosire obiecte
            Programare programare = client1.FaceProgramare(frizer1, DateTime.Now);
            client1.IntraInFrizerie(FrizeriaMea);
            if(frizer1.TundeClient(programare)) client1.IeseDinFrizerie();

            Programare programare1 = client2.FaceProgramare(frizer2, DateTime.Now);
            client2.IntraInFrizerie(FrizeriaMea);
            if (frizer2.TundeClient(programare1)) client2.IeseDinFrizerie();

            Programare programare2 = client3.FaceProgramare(frizer3, DateTime.Now);
            client3.IntraInFrizerie(FrizeriaMea);
            if (frizer3.TundeClient(programare2)) client3.IeseDinFrizerie();

            Programare programare3 = client4.FaceProgramare(frizer4, DateTime.Now);
            client4.IntraInFrizerie(FrizeriaMea);
            if (frizer4.TundeClient(programare3)) client4.IeseDinFrizerie();

            frizer1.IeseDinTura();
            frizer2.IeseDinTura();
            frizer3.IeseDinTura();
            frizer4.IeseDinTura();
            Console.ReadKey();
        }
    }
}
