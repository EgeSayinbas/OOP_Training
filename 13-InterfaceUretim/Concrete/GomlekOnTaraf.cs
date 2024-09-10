using _13_InterfaceUretim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceUretim.Concrete
{
    internal class GomlekOnTaraf:IDikilebilir
    {
        public void Dik()
        {
            Console.WriteLine($"{this.GetType().Name} Dikildi");
        }
    }
}
