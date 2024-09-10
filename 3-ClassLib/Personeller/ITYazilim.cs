using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Personeller
{
    public class ITYazilim:Personel
    {
        public ITYazilim(string ad, string soyad) : base(ad, soyad)
        {
            Maas = base.Maas * 2.5;
        }

        public void KodYaz()
        {

        }
        public void DebugYap()
        {

        }

        public void TestEt()
        {

        }
    }
}
