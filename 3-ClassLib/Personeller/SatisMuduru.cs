using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Personeller
{
    public class SatisMuduru:SatisElemani 
    {
        // ODev : Prim property'si instance alindiginda gorunmeyecek.
      
        public SatisMuduru(string ad, string soyad) : base(ad, soyad)
        {
           Maas = base.Maas + PrimHesapla();
            
        }
        public List<SatisElemani> BagliElemanlar { get; set; }
        
        public void SatisToplantisiYap()
        {

        }

        public void BayiToplantilariYap()
        {

        }
        private  double PrimHesapla()
        {
            double primtoplami = 0;
            foreach (var item in BagliElemanlar)
            {
               
                primtoplami += item.Prim*1.1;
            }

            return  primtoplami;
        }
    }
}
