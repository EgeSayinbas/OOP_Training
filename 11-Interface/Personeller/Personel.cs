using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface.Personeller
{
    public class Personel : Kisi,IPersonel
    {
        public double Maas { get; set; } = 17002;
        public string Departman { get; set; }
       
        public Personel(string ad ,string soyad):base(ad,soyad)
        {
            
        }
        public void test()
        {

        }
        public void IseGecKalma()
        {
            throw new NotImplementedException();
        }

        public void TelefonaBak()
        {
            throw new NotImplementedException();
        }
    }
}
