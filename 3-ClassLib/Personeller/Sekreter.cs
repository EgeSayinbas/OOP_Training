using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Personeller
{
    public class Sekreter:Personel
    {
        public Sekreter(string ad, string soyad) : base(ad, soyad)
        {
            Maas = base.Maas+7000;
        }
        public void TelefonlaraBak()
        {

        }
        public void RandevulariAyarla()
        {

        }

    }
}
