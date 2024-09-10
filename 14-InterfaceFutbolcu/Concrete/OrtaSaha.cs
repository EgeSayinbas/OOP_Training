using _14_InterfaceFutbolcu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InterfaceFutbolcu.Concrete
{
    public class OrtaSaha : BaseFutbolcu, IOrtaSaha
    {
        public string OyunKur()
        {
            return $"{AdiSoyadi} Oyun Kurdu";

        }

        public string PasTrafigiYap()
        {
            return $"{AdiSoyadi} Pas atti";

        }
    }
}
