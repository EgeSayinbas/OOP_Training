using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface.Personeller
{
    public class InsanKaynaklari : Personel,IPersonel
    {
        public InsanKaynaklari(string ad,string soyad):base(ad, soyad) 
        {
            Maas = base.Maas * 2;
        }

        public void IseAlimGorusmesiYap()
        {

        }

        public void BordroHazirla()
        {

        }

        public void OryantasyonuSagla()
        {

        }

        public void IStenCikart()
        {

        }
    }
}
