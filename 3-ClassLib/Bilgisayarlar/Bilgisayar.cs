using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{
    public class Bilgisayar
    {
        public AnaKart Anakart { get; set; }

        public Cpu Cpu { get; set; }
        public List<Ram> Ramlar { get; set; }
        public List<EkranKarti> EkranKartlari { get; set; }
        public List<HardDisk> Diskler { get; set; }


        // Kurucu metod yada Yapici metod da denir. 
        // Terminolojide constructor olarak gecer.
        // Eger property'lere ilk deger atamasi yapilmiş ise
        // Once property'ler e deger atanir sonra constructor calistirilir.
        // Constructer'lar Class ismi ile ayni olmak zorundadir.
        // Constructer 'lar geri donus tipi yoktur.

        public Bilgisayar()
        {
            Cpu = new Cpu("Amd");
            Ramlar = new List<Ram>() { new Ram { Fiyat = 5 } , new Ram { Fiyat = 5 } };
            EkranKartlari = new List<EkranKarti>() { new EkranKarti { Fiyat=10} };
            Diskler = new List<HardDisk>() { new HardDisk { Fiyat=10} };
            Anakart = new AnaKart();
        }
        public double FiyatHesapla()
        {
            double toplamtutar = 0;
            foreach (var item in Ramlar)
            {
                toplamtutar +=  item.Fiyat;
            }
            foreach (var item in Diskler)
            {
                toplamtutar +=  item.Fiyat;
            }
            foreach (var item in EkranKartlari)
            {
                toplamtutar +=  item.Fiyat;
            }
            toplamtutar += Anakart.Fiyat;
            toplamtutar += Cpu.Fiyat;

            return toplamtutar;

        }
    }
}
