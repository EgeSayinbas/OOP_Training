using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceUretim.Abstract
{
    internal class BaseMakina
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public BaseMakina(string marka,string model)
        {
            this.Marka = marka;
            this.Model = model;
        }
    }
}
