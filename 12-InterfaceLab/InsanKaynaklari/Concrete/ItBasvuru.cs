using _12_InterfaceLab.InsanKaynaklari.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.InsanKaynaklari.Concrete
{
    public class ItBasvuru : BaseBasvuru, IYazilim
    {
        //Enterprise Design Patterns, WCF, Razor, HTML5, CSS3, Javascript, JQuery, Ajax, JSON, XML, OOP

        public bool isEDP { get; set; }
        public bool isWCF { get; set; }
        public bool isRazor { get; set; }
        public bool isCSS3 { get; set; }

        public bool isJavaScript { get; set; }

        public bool isJQUERY { get; set; }
        public bool isAjax { get; set; }
        public bool isJson { get; set; }

        public bool isOOP { get; set; }

        public ItBasvuru()
        {
            base.Basvuran = new Kisi();
        }
        public void AnalitikDusun()
        {
            throw new NotImplementedException();
        }

        public void AnalizEt()
        {
            throw new NotImplementedException();
        }

        public void DebugYap()
        {
            throw new NotImplementedException();
        }

        public void KodYaz()
        {
            throw new NotImplementedException();
        }
    }
}
