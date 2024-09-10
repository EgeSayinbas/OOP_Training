using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PolimorfizmWindow.Hayvanlar
{
    internal class Hayvan
    {
        public virtual void SesCikar()
        {
            Console.WriteLine("Hirrr");
        }
        public virtual void HareketEt()
        {
            Console.WriteLine("Hayvan hareket etti");
        }
    }
}
