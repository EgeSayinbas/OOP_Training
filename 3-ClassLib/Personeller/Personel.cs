using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Personeller
{
    public class Personel : Kisi
    {
        public double Maas { get; set; } = 17002;
        public string Departman { get; set; }

        public Personel(string ad ,string soyad):base(ad,soyad)
        {
            
        }
        public void IseGecKalma()
        {

        }
    }
}
