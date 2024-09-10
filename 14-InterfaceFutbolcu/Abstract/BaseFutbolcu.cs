using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InterfaceFutbolcu.Abstract
{

    public enum Mevki : byte
    {
        Kaleci=1,
        Defans,
        OrtaSaha,
        Forvet
    }

    public abstract  class BaseFutbolcu:IFutbolcu
    {
        public Mevki Mevki { get; set; }
        public string AdiSoyadi { get; set; }
        public DateTime DogumTarigi { get; set; }
        public bool Milllimi { get; set; }
        public byte SutGucu { get; set; }
        public byte Agresiflik { get; set; }
        public byte Dayaniklilik { get; set; }
        public byte Hiz { get; set; }
        public override string ToString()
        {
            return $"{AdiSoyadi}";

            // return $"{AdiSoyadi}\nYaş{DateTime.Now.Year-DogumTarigi.Year}\nMevki{Mevki}\nŞut Gucu{SutGucu}\nHiz:{Hiz}\nMillimi:{Milllimi}";
        }
        public string Kos()
        {
            return $"{AdiSoyadi} Kostu";
        }

        public string PasAt()
        {
            return $"{AdiSoyadi} Pas Atti";
        }

        public string PresYap()
        {
            return $"{AdiSoyadi} Pres Yapti";
        }

        public string SutCek()
        {
            return $"{AdiSoyadi} Sut Cekti";
        }
    }
}
