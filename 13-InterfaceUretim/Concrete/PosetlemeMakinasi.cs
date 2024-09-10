using _13_InterfaceUretim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceUretim.Concrete
{
    // Default Constructer
    internal class PosetlemeMakinasi(List<IPosetlenebilir> posetlenebilirs,string Marka,string Model):BaseMakina(Marka,Model),IMakina
    {
        public void Calis()
        {
            foreach (var item in posetlenebilirs)
            {
                item.Posetle();
            }
        }

       
        //private readonly List<IPosetlenebilir> posetlenebilirs;

        //public PosetlemeMakinasi(List<IPosetlenebilir> posetlenebilirs)
        //{
        //    this.posetlenebilirs = posetlenebilirs;
        //}
    }
}
