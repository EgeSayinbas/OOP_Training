using _13_InterfaceUretim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceUretim.Concrete
{
    internal class Utu(List<IUtulenebilir> utulenebilir) : IMakina
    {
        public void Calis()
        {
            throw new NotImplementedException();
        }
    }
}
