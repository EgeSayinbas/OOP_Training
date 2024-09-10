using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PolimorfizmWindow.Hayvanlar
{
    internal class Kopek:Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Hav hav");
        }
        public override void HareketEt()
        {
            Console.WriteLine("Kopek Kostu");
        }
    }
}
