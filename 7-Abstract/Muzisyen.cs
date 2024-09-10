using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract
{
    public class Muzisyen
    {
        //public Gitar Gitar { get; set; }
        //public Flut Flut { get; set; }
        //public Piyano Piyano { get; set; }

        public string AdSoyad { get; set; }
        /*
         * Caldigi aletleri tek tek prop olarak ifade etmek  
         * ilerleyen durumda yeni bir muzik aleti caldiginda kodda
         * degisiklige neden olacaktir. Bu istenilen bir durum degildir.
         * 
         * Bu nedenle Butun muzik aletlerinin base class'i olan MuzikAleti
         * sinifini tutan bir liste de ifade etmek dogru olan yoldur.
         * 
         * 
         * 
         */
        
        public List<MuzikAleti> CaldigiAletler { get; set; }
        public Muzisyen(List<MuzikAleti> muzikAletis)
        {
            CaldigiAletler = muzikAletis;  
        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in CaldigiAletler)
            {
                str += $"{item.Marka} {item.Model} \n";

            }
            return str+ "  Calisyor";
        }
    }
}
