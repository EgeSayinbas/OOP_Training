using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface.Personeller
{
    public class ITTasarimci:Personel,IBilisimPersoneli,ITasarimci
    {
        public ITTasarimci(string ad, string soyad) : base(ad, soyad)
        {
            Maas=base.Maas*2;
        }

        public void BilgisayarProblemiCoz()
        {
            throw new NotImplementedException();
        }

        public void LogoTasarla()
        {
            throw new NotImplementedException();
        }

        public void NetworkProblemiCoz()
        {
            throw new NotImplementedException();
        }

        public void TestEt()
        {
            throw new NotImplementedException();
        }

        public void WebSitesiTasarla()
        {
            throw new NotImplementedException();
        }
    }
}
