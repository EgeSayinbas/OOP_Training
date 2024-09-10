using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract.AlanHesaplari
{
    public abstract class Sekil
    {
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }

        public abstract double AlanHesapla();


        public abstract  double CevreHesapla();
       
    }
}
