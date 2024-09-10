using _14_InterfaceFutbolcu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InterfaceFutbolcu.Concrete
{
    public class Forvet : BaseFutbolcu, IForvet
    {
        public string GolAt()
        {
            return $"{AdiSoyadi} Gol Atti";

        }

        public string PenaltiKullan()
        {
            return $"{AdiSoyadi} Penalti Çekti";

        }
    }
}
