using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_EventTrafikKontrol
{
    public class Sofor
    {
        public string AdSoyad { get; set; }
        public event TrafikHandler GazaBastim;
        public void GazaBas()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(30, 100);
            GazaBastim(sayi, this);
        }
    }
}
