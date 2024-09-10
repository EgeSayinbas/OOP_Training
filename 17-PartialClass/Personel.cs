using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PartialClass
{
    /*
     * partial classlar birden fazla dosyada olan yapialrdir
     * eger class cok buyuk ise parcalara ayrilabilir
     * 
     * 
     */
    internal partial class Personel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
        public string Gsm { get; set; }
        public bool Cinsiyet { get; set; }
        public string Email { get; set; }
    }
}
