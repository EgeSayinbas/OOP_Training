using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.InsanKaynaklari.Concrete
{
    public class IK
    {
        //public List<ItBasvuru> ItBasvurulari { get; set; }
        public HashSet<object> GenelBasvurular { get; set; } = new();
        public HashSet<ItBasvuru> ItBasvurulari { get; set; } = new(); // Bu listeye ayni objeden iki kayit atilamaz
        public HashSet<FinansBasvuru> FinansBasvurulari { get; set; } = new();
        public void ITBasvurusuAl(ItBasvuru basvuru)
        {
            ItBasvurulari.Add(basvuru);
        }
        public HashSet<ItBasvuru> ITBasvurusulariniVer()
        {
           return ItBasvurulari;
        }
        public void FinansBasvurusuAl(FinansBasvuru basvuru)
        {
            FinansBasvurulari.Add(basvuru);

        }

        public void GenelBasvuruAl(object basvuru)
        {
            GenelBasvurular.Add(basvuru);
        }

        public void GenelBasvuruListele()
        {
            foreach (var item in GenelBasvurular)
            {
                if (item is ItBasvuru)
                {
                    ItBasvuru basvuru1 = (ItBasvuru)item;
                    Console.WriteLine(basvuru1);
                }
                else if (item is FinansBasvuru)
                {
                    var basvuru = item as FinansBasvuru;
                    Console.WriteLine(basvuru);
                }
            }
        }
    }
}
