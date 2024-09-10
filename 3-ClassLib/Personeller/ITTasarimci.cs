using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Personeller
{
    public class ITTasarimci:Personel
    {
        public ITTasarimci(string ad, string soyad) : base(ad, soyad)
        {
            Maas=base.Maas*2;
        }

        public void LogoTasarla()
        {

        }

        public void WebSitesiTasarla()
        {

        }
    }
}
