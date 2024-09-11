using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EventKumanda
{
    public class Araba
    {
        public delegate void HizAsimHandler();//her hangi bir parametre almayan metodlari temsil eden delegate
        public event HizAsimHandler HizAsim; // bir olay tanimlar olayin cagiracagi metod tipi HizAsimHandler tipindendir.

        private readonly string _kod;
        

        public string Marka { get; set; } 
        public Araba(string marka,string kod)
        {
            this.Marka = marka;
            this._kod = kod;
        }

        public void SinyalAl(string kod)
        {
            Console.WriteLine( $"{Marka} Sinyal Alindi {kod}");
            if (kod == _kod)
            {
                KapilariAc();
            }
        }

        private void KapilariAc()
        {
            Console.WriteLine($"{Marka} Kapilar Acildi kod: {_kod}");
        }
    }
}
