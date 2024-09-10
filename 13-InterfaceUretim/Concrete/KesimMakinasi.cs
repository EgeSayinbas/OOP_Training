using _13_InterfaceUretim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceUretim.Concrete
{
    internal class KesimMakinasi(List<IKesilebilir> kesilebilirs,string Marka,string Model):BaseMakina(Marka, Model),IMakina
    {
        public void Calis()
        {
            foreach (var item in kesilebilirs)
            {
                item.Kes();
            }
        }
    }
}
