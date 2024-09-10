using _12_InterfaceLab.InsanKaynaklari.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.InsanKaynaklari.Concrete
{
    public class FinansBasvuru : BaseBasvuru, IFinans
    {

        public bool isExcel { get; set; }
        public bool isMicro { get; set; }

        public void HakedisCikar()
        {
            throw new NotImplementedException();
        }

        public void KdvHazirla()
        {
            throw new NotImplementedException();
        }

        public void VergiHesapla()
        {
            throw new NotImplementedException();
        }
       
    }
}
