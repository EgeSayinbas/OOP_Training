using _14_InterfaceFutbolcu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InterfaceFutbolcu.Concrete
{
    public class Takim(List<BaseFutbolcu> futbolcular)
    {
        public override string ToString()
        {
            string sonuc = string.Empty;
            foreach (var futbolcu in futbolcular)
            {
                sonuc += futbolcu.ToString();
            }
            return sonuc;
        }
    }
}
