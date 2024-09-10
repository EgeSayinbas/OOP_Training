using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.LokantaOrnegi
{
    internal class Tavuk:IPisirilebilir
    {
        public void Pisir()
        {
            Console.WriteLine(this.GetType().Name + " Pisti");
        }
    }
}
