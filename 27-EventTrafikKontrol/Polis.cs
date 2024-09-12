using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_EventTrafikKontrol
{
    internal class Polis
    {
        public string AdSoyad { get; set; }

        public void HizKontrolEt(int hiz, object tetikleyen)
        {
            if (tetikleyen is Araba)
            {
                if (hiz > 120)
                {
                    Araba araba = (Araba)tetikleyen;
                    araba.ArabaCalisiyormu = false;
                    Console.WriteLine($"{araba.Plaka} plakali aracin {araba.Sofor.AdSoyad} isimli şöförüne {hiz} \n");
                    Console.WriteLine($" hizla gitiginden dolayi {this.AdSoyad} isimli polis tarafindan ceza kesilmistir.");
                }
            }
            else if (tetikleyen is Kamyon)
            {

            }

        }
    }
}
