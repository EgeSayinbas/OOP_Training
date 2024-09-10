using _14_InterfaceFutbolcu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InterfaceFutbolcu.Concrete
{
    public class Defans : BaseFutbolcu, IDefans
    {
        public string CoreCoreMucadele()
        {
            return $"{AdiSoyadi} Mucadele Etti";

        }

        public string DefansYap()
        {
            return $"{AdiSoyadi} Defans Yapti";

        }

        public string TopGecerAdamGezmez()
        {
            return $"{AdiSoyadi} Faul Yapti";

        }
    }
}
