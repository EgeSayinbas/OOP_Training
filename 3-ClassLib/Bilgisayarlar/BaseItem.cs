using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{

    /*
     * Anbstract class lar instance alinamaz. Ancak kalitim verebilir.
     * Varlik sebebide kalitim vermektir. Yani Base Class olarak calisirlar
     */
    public abstract class BaseItem
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; } 
        public BaseItem()
        {
            Fiyat = 1;
        }
    }
}
