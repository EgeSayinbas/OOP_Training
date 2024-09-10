using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface.Personeller
{
    public class ITYazilim : Personel,IBilisimPersoneli,IYazilimci
    {
        public ITYazilim(string ad, string soyad) : base(ad, soyad)
        {
        }

        public void BilgisayarProblemiCoz()
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

        public void NetworkProblemiCoz()
        {
            throw new NotImplementedException();
        }

        public void TestEt()
        {
            throw new NotImplementedException();
        }
    }
}
