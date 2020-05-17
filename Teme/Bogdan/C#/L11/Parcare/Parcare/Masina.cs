using System;

namespace Parcare
{
    public class Masina
    {
        public string Marca { get; set; }
        public string Culoare { get; set; }
        public TipMasina Tip { get; set; }
        public string Numar { get; set; }

        public void IntraInParcare()
        {
            Console.WriteLine($"Masina cu nr de inmatriculare {Numar} intra in parcare.");
        }
        public bool OcupaLoc(LocParcare loculDeParcare)
        {
            if (loculDeParcare.OcupatDeMasina == null)
            {
                if (Tip == loculDeParcare.TipLoc)
                {
                    Console.WriteLine("Puteti parca !");
                }
                else
                {
                    Console.WriteLine($"Masina {Marca} cu nr de inmatriculare {Numar} este de tip {Tip}" +
                        $" si nu poate fi parcata deoarece locul de parcare este de tip {loculDeParcare.TipLoc}.");
                    return false;
                }
                Console.WriteLine($"Locul de parcare {loculDeParcare.LiteraRand} {loculDeParcare.Pozitie} este liber.");
                loculDeParcare.OcupatDeMasina = this;
                Console.WriteLine($"Masina marca {Marca} cu nr de inmatriculare {Numar} a ocupat locul de parcare {loculDeParcare.LiteraRand} {loculDeParcare.Pozitie} ! ");
                return true;
            }
            else
            {
                Console.WriteLine($"Locul de parcare {loculDeParcare.LiteraRand} {loculDeParcare.Pozitie} este ocupat, cautati alt loc de parcare !");
                return false;
            }
        }

        public bool ElibereazaLoc(LocParcare loculDeParcare)
        {
            if (loculDeParcare.OcupatDeMasina != null)
            {
                Console.WriteLine($"S-a eliberat locul de parcare {loculDeParcare.LiteraRand} {loculDeParcare.Pozitie}.");
                loculDeParcare.OcupatDeMasina = null;
                return true;
            }
            else
            {
                Console.WriteLine($"{loculDeParcare.LiteraRand} {loculDeParcare.Pozitie} este liber si se poate parca pe el !");
                return false;
            }
        }
        public void IesireDinParcare()
        {
            Console.WriteLine($"Masina marca {Marca} cu nr de inmatriculare {Numar} a iesit din parcare");
        }
    }
}

