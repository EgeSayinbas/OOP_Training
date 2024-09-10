using _14_InterfaceFutbolcu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InterfaceFutbolcu.Concrete
{
    public class Kaleci : BaseFutbolcu, IKaleci
    {
        public string DegajYap()
        {
            return $"{AdiSoyadi} Degaj Yapti";
        }

        public string PenaltiKurtar()
        {
            return $"{AdiSoyadi} Penalti Kurtardi";

        }

        public string TopuElleYakala()
        {
            return $"{AdiSoyadi} Topu Elle Yakaladi";

        }
    }
}
