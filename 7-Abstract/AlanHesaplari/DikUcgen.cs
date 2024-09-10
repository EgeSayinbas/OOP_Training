using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Abstract.AlanHesaplari
{
    public class DikUcgen : Sekil
    {
        public override double AlanHesapla()
        {
            return KisaKenar * UzunKenar / 2;
        }

        public override double CevreHesapla()
        {
            return KisaKenar + UzunKenar + Math.Sqrt(Math.Pow(KisaKenar, 2) + Math.Pow(UzunKenar, 2));
        }
    }
}
