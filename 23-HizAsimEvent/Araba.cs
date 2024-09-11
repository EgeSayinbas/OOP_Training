using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_HizAsimEvent
{
    public class Araba
    {
        public delegate void HizAsimHandler();//her hangi bir parametre almayan metodlari temsil eden delegate
        public event HizAsimHandler HizAsim; // bir olay tanimlar olayin cagiracagi metod tipi HizAsimHandler tipindendir.

        private int _hiz;
        public int Hiz
        {
            get { return _hiz; }
            set
            {
                if (value > 120)
                {
                    HizAsim();
                }
            }
        }

        public string Marka { get; set; } 
        public Araba(string marka,int hiz)
        {
            this.Marka = marka;
            this.Hiz = hiz;
        }

    }
}
