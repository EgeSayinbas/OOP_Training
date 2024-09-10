using _12_InterfaceLab.InsanKaynaklari.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.InsanKaynaklari.Abstract
{
    public abstract class BaseBasvuru
    {
        public Kisi Basvuran { get; set; } = new Kisi();
        public Departman Departman { get; set; }
        public bool UniversiteMezunumu { get; set; }
        public bool EhliyetVarmi { get; set; }
        public bool SeyahatEngelVarmi { get; set; }
        protected BaseBasvuru()
        {
            
        }
        public override string ToString()
        {
            return Basvuran.Ad+" " +Basvuran.Soyad +" " + (Basvuran.Cinsiyet==true?"Erkek":"Kadin")+ " Departman:"+ Enum.GetName(Departman) + (Basvuran.Cinsiyet==true?" Askerlik Durumu:Yapildi" :"") ;
        }
    }
}
