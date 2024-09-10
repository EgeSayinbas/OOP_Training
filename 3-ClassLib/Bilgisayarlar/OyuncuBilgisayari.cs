using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{
    public class OyuncuBilgisayari
    {
        public AnaKart Anakart { get; set; } = new AnaKart();

        public Cpu Cpu { get; set; } =new Cpu("Intel","I9",8,5000);
        public List<Ram> Ramlar { get; set; } = new List<Ram>();
        public List<EkranKarti> EkranKartlari { get; set; } = new List<EkranKarti>();

        public List<HardDisk> Diskler { get; set; } = new List<HardDisk>();
        public int Adet { get; set; }
        public string Aciklama { get; set; } = string.Empty;
        public OyuncuBilgisayari()
        {
            
            Anakart.Marka = "Gigabyte";
             Cpu.Marka = "AMD";
        }

        public bool RamEkle(Ram ram)
        {
            Ramlar.Add(ram);
            return true;
        }
        public bool DiskEkle(HardDisk disk)
        {
            Diskler.Add(disk);
            return true;
        }

        public double FiyatHesapla()
        {
            double toplamtutar = 0;
            foreach (var item in Ramlar)
            {
                toplamtutar += toplamtutar + item.Fiyat;
            }
            foreach (var item in Diskler)
            {
                toplamtutar += toplamtutar + item.Fiyat;
            }
            foreach (var item in EkranKartlari)
            {
                toplamtutar += toplamtutar + item.Fiyat;
            }
            toplamtutar += Anakart.Fiyat;
            toplamtutar += Cpu.Fiyat;

            return toplamtutar;

        }
    }
}
