using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_EventTrafikKontrol
{
    public class Araba
    {
        public string Plaka { get; set; }
        private int _maxhiz, _hiz;
        public string SoforAdi { get; set; }
        public bool ArabaCalisiyormu { get; set; }
        public Sofor Sofor { get; set; }
        public event TrafikHandler HareketEdiyorum;
        public Araba(string plaka, int maxhiz)
        {
            this.Plaka = plaka;
            this._hiz = maxhiz;
        }

        public void Calis(int hiz, object gazaBasan)
        {
            Sofor sofor = (gazaBasan as Sofor);
            ArabaCalisiyormu = true;
            while (ArabaCalisiyormu)
            {
                _hiz += hiz * 2;
                Console.WriteLine($"{Plaka} {_hiz} km hizla gidiyor");
                HareketEdiyorum(_hiz, this);
            }
        }

    }
}
