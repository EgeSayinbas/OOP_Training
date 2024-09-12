namespace _27_EventTrafikKontrol
{
    #region Konu Anlatimi
    /*
     * Delegeler, metodların adreslerini dolayısıyla metodların kendilerini tutabilen, işaret edebilen yapılardır.
        NOT : Metodlar da bellekte oluşan ve bellek adresleri olan yapılardır.
        Delegeler referans tipli yapılardır.Yani nesne oluşturulabilirler.
        Şimdi bir delege yapısı nasıl olur bakalım.
        [Erişim Belirleyicisi] delege [geri dönüş tipi] [delege ismi] (eğer varsa parametre)
     * 
     * 
     * 
     * 
     */
    #endregion
    public delegate void DortIslem(int a, int b);
    public delegate void IslemEventHAndler(object source, EventArgs e);

    public delegate void TrafikHandler(int hiz, object sender);//Geri donus tipi olamayan icerisine int ve object alan butun metodlari temsil edebilirim

    internal class Program
    {

        /*
         * Trafik polisi hiz kontrolu yapsin.
         * Otomobiller icin hiz siniri 120
         * Kamyonlar icin 80 
         * Pikap ve Ticariler icin de 90 olacak sekilde kontrol yapsin
         * 
         * Ticariler icin 1000 Tl , Kamyonlar icin 1500 Tl cezayi Firmaya  kessin
         * Otomobiller icin de 800 Tl traik cezasi kessin. 
         * 
         * Ekrana gelecek yazi Plaka no 'lu arabani şöförüne x hiziyla gittiginden dolayi 1000 TL ceva kesilmistir.
         * Cezayi kesen polisin adi ve soyadi 
         * 
         * 
         * Olay Sofor gaza basinca kontrol gerçeklessin.
         * 
         */
        static void Main(string[] args)
        {
            #region Delegate ornegi
            //DortIslem dortIslem = new DortIslem(Topla);
            //dortIslem += Carp;
            //dortIslem += Cikar;
            //dortIslem += Topla;
            ////IslemTipi(Topla(3, 5), IslemTipi.Topla);
            //Islem(dortIslem); 
            #endregion

            #region Trafik Kontrolu
            Araba toyota = new Araba("34 ABC 123", 200);
            Polis polis = new Polis() { AdSoyad = "Hasan Can" };
            Sofor sofor = new Sofor() { AdSoyad = "Ali Kaya" };
            toyota.Sofor = sofor;
            toyota.HareketEdiyorum += polis.HizKontrolEt;

            sofor.GazaBastim += toyota.Calis;
            sofor.GazaBas();



            #endregion


            Console.WriteLine("Hello, World!");

        }
        public enum IslemTipi
        {
            Topla,
            Carp,
            Cikar,
            Bol
        }
        public static void Bol(int a, int b)
        {

        }
        public static void Islem(DortIslem islem)
        {
            islem.Invoke(3, 5);
        }
        public static void Topla(int a, int b)
        {
            Console.WriteLine("Toplam :" + (a + b));
        }
        public static void Carp(int a, int b)
        {
            Console.WriteLine("Carpim :" + (a * b));
        }
        public static void Cikar(int a, int b)
        {
            Console.WriteLine("Fark :" + (a - b));
        }
    }

}
