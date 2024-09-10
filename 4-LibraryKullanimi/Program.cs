using _3_ClassLib.Bilgisayarlar;
using _3_ClassLib.Personeller;

namespace _4_LibraryKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cpu cpu = new Cpu();
            cpu.Marka = "AMD";

            AnaKart anaKart = new();
            
            //Abstract class'lardan instance alinamaz.
            //BaseItem baseItem = new BaseItem();
            //baseItem.Marka = "xyz";
            //baseItem.Model = "abc";
            //baseItem.Fiyat = 12;

            Bilgisayar bilgisayar = new Bilgisayar();
            OyuncuBilgisayari oyuncu = new();
            

            //bilgisayar.Anakart = anaKart;
            //bilgisayar.Cpu = cpu;
            //bilgisayar.Ramlar = new List<Ram>();
            //bilgisayar.Ramlar.Add(new Ram() {Marka="Kingston" });
            //bilgisayar.Ramlar.Add(new Ram() { Marka = "Corsair" });
            //bilgisayar.Diskler = new List<HardDisk>();
            //bilgisayar.Diskler.Add(new HardDisk { DiskTipi = DiskTipi.SSD, Marka = "Seagate" });
            //bilgisayar.EkranKartlari = new List<EkranKarti>();
            //oyuncu = null;

            Console.WriteLine("Oyuncu bilgisayari Fiyati :"+oyuncu.FiyatHesapla());
            Console.WriteLine("bilgisayar Fiyati :" + bilgisayar.FiyatHesapla());
            Kisi kisi = new Kisi("ayse", "kaya");

            SatisMuduru satisMuduru = new SatisMuduru("Ali","Yilmaz");
            //SatisElemani satisElemani = new SatisElemani();
            //Console.WriteLine(satisElemani);
             
            //Kisi kisi = new Kisi();
           
            Console.WriteLine("Hello, World!");
        }
    }
}
