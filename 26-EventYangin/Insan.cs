using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EventYangin
{
    public class Insan
    {
        public string AdSoyad { get; set; }

        public Insan(string adSoyad)
        {
            AdSoyad = adSoyad;
        }

        public void Kac(object sorun)
        {
            if(sorun is Alarm)
            {
                Console.WriteLine($"{AdSoyad} alarmdan dolayi kacti");
            }
            else if(sorun is Kablo)
            {
                Console.WriteLine($"{AdSoyad} kablodan yaninca merak edip bakti");
            }
        }

        public void RahatsizOl(object rahatsizEden)
        {
            if (rahatsizEden is Alarm)
            {
                Console.WriteLine($"{AdSoyad} alarmdan dolayi rahatsiz oldu");
            }
            else if (rahatsizEden is Kablo)
            {
                Console.WriteLine($"{AdSoyad} kablodan yaninca sondurmeye calisti");
            }
            else if (rahatsizEden is Sigara)
            {
                Console.WriteLine($"{AdSoyad} oksurmeye basladi");
            }
        }

    }
}
