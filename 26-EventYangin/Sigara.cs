using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EventYangin
{
    public class Sigara
    {
        public event EventHandler Yandim;

        private readonly string _Marka;

        public Sigara(string marka)
        {
            _Marka = marka;
        }
        public void SigaraIc()
        {
            
            Console.WriteLine($"{_Marka} sigara yandi");
            Yandim(this);
        }
    }
}
