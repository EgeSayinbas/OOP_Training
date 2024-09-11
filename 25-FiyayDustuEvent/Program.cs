namespace _25_FiyatDustuEvent
{
    internal class Program
    {
        /* Hisse senedi satildiginda
         * Sana ait olan hisseler karsi tarafa gecer.
         * Hesabina satis bedeli kadar para yatar.
         * Karsi tarafin heabinda para duser
         * 
         * 
         * 
         */
        static void Main(string[] args)
        {

            Urun iphone = new Urun();
            iphone.UrunAdi = "IPhone 50";
            Kisi veli = new Kisi("veli", 9000);
            Kisi ali = new Kisi("ali", 9000);
            Kisi ayse = new Kisi("ayse", 8500);
            Kisi hasan = new Kisi("hasan", 8000);
            Kisi fatma = new Kisi("fatma", 7700);
            iphone.FiyatDustuEvent += veli.HaberAl;
            iphone.FiyatDustuEvent += ali.HaberAl;
            iphone.FiyatDustuEvent += ayse.HaberAl;
            iphone.FiyatDustuEvent += hasan.HaberAl;
            iphone.FiyatDustuEvent += fatma.HaberAl;
            for (int i = 10000; i >= 7000; i = i - 500)
            {
                iphone.Fiyat = i;
            }



        }
    }
}
