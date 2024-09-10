using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.InsanKaynaklari.Concrete
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        private bool? _AskerlikDurumu;

        public bool? Askerlik
        {
            get { 
               
                return _AskerlikDurumu?? false; 
               
            }
            set { 
                if(Cinsiyet==true)
                    _AskerlikDurumu = value; 
            }
        }

        public Kisi()
        {
            
        }
       
    }
}
