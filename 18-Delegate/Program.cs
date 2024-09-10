namespace _18_Delegate
{
    internal class Program
    {
        //        Delegate
        //Delegeler, metodların adreslerini dolayısıyla metodların kendilerini tutabilen, işaret edebilen yapılardır.
        //NOT : Metodlar da bellekte oluşan ve bellek adresleri olan yapılardır.
        //Delegeler referans tipli yapılardır.Yani nesne oluşturulabilirler.

        //Delegeler interface gibi tek başına bir anlamlı konu değildir.
        //Kafanızda bu konuyu nerede kullanacağım gibisinden sorular olabilir.
        //Ama Event konusuyla bağdaştırınca konuyu daha iyi irdeleyip anlamaya başlayacaksınız.

        //Temsilci olarak adlandirilabilecek bu yapi, projeyi asil ayakta tutan nesneleri yormak yerine,
        //onlarin islerini uzerine alarak gerceklestirmekten sorumlu olan tiptir.
        //Bu sayede uygulamamizin her bir kolu, uzerine dusen gorevi eksiksiz yerine getirerek
        //daha uzun sureli ve performansli uygulamalar ortaya koyma sansina sahip olabiliriz.

        //Unutulmamasi gereken nokta ise, delegeler de aslinda birer class'tır.
        //Delege tanimlamak icin;
        //1) Oncelikle delege tanımlamasi gerceklestirilir (geri donus tipi unutulmamalidir!)
        //2) Delege'nin calismasi konusunda sorumlu olabilecegi metotlar yazilir...
        //3) Delege'de instance alindigi asamada ilgili metot delegeye baglanir ve metot yerine delege'nin Invoke() metodu cagrilir...
        public delegate void MyDelegate();//Geri donus tipi olmayan ve parametre almayan metodlari temsil edebilir
        public delegate double DortIslem(int x, int y); // integer tipinden 2 adet parametre alan geriye double donen metodlari temsile edebilir.
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Test);
            myDelegate.Invoke();

            var islem = DelegateGeriDonenMetod();
            Testdelegate(islem, "+");
            Console.WriteLine(islem.Invoke(5, 3));
            Console.WriteLine("Hello, World!");
        }

        #region Metodlara parametre olarak baska bir metod gecilemez. Bu ancak delegeler vasitasiyla olur
        //public static void Test2(Topla(3,5))
        //{

        //} 
        #endregion
        public static DortIslem DelegateGeriDonenMetod()
        {
            DortIslem islem = new DortIslem(Topla);
            islem += Carp;
            islem += Cikar;
            islem += Bol;
            return islem;
        }
        public static void Testdelegate(DortIslem islemDelegate, string islem)
        {
            foreach (var item in islemDelegate.GetInvocationList())
            {
                if (islem == "+")
                    Console.WriteLine($"{item.GetType().Name} Sonucu:{item.DynamicInvoke(5, 3)}");
            }
        }
        public static void Test()
        {
            Console.WriteLine("Test");
        }

        public static double Topla(int a, int b)
        {
            return a + b;
        }
        public static double Carp(int a, int b)
        {
            return a * b;
        }
        public static double Cikar(int a, int b)
        {
            return a - b;
        }
        public static double Bol(int a, int b)
        {
            return a / (double)b;
        }
    }
}