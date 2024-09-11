using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_FiyatDustuEvent
{
    public class Kisi
    {
        public string AdSoyad { get; set; }
        private int _almakistedigiFiyat;
        public Kisi(string adsoyad, int fiyat)
        {
            AdSoyad = adsoyad;
            _almakistedigiFiyat = fiyat;
        }
        public void HaberAl(int fiyat)
        {
            if (fiyat < _almakistedigiFiyat)
            {
                Console.WriteLine($"Şu anki fiyat:{fiyat} Haber Alan  :{AdSoyad}  => {_almakistedigiFiyat} ");

            }
        }

    }
}
