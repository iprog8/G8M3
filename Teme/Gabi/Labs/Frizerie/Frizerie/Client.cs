using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frizerie
{
    public class Client
    {
        public Client(string nume)
        {
            Nume = nume;
        }
        public string Nume { get; set; }
        public Programare Programare { get; set; }
        public Programare FaceProgramare(Frizer frizer,DateTime data)
        {
            Programare programare = new Programare(this, data, frizer);

            return programare;
        }
        public Programare AnuleazaProgramarea()
        {
            return null;
        }
        public void IntraInFrizerie(Frizerie frizerie)
        {
            if (frizerie.Clienti == null) frizerie.Clienti = new List<Client>();
            frizerie.Clienti.Add(this);
            Console.WriteLine($"Clientul cu numele {this.Nume} a intrat in frizeria {frizerie.Nume}");
        }
        public void IeseDinFrizerie()
        {
            Console.WriteLine($"Clientul {this.Nume} a iesit din frizerie");
        }

    }
}
