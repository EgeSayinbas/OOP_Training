using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PolimorfizmWindow.Hayvanlar
{
    internal class Kedi:Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Miyavv...");
        }
        public override void HareketEt()
        {
            Console.WriteLine("Kedi Kostu");
        }
    }
}
