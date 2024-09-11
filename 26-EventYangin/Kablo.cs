using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EventYangin
{
    public class Kablo
    {
        public event EventHandler Yandim;

        public void AkimGecir()
        {
            Console.WriteLine("Kablo Yandi");
            Yandim(this);
        }
    }
}
