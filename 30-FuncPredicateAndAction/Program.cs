using System.Globalization;

namespace _30_FuncPredicateAndAction
{
    public class Kisi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
    }
    public delegate void BosDelegate(); // Geri Donus tipi Olmayan ve paramaetre almayan metod imzali temsilci

    internal class Program
    {
        public event BosDelegate MyEvent;
        EventHandler MyEventHandler;

        static void Main(string[] args)
        {
            List<string> sehirler = new List<string> { "Adana", "Mus", "Van", "Ankara", "Izmir" };

            #region Soru Cevap
            //Kisi kisi = new Kisi() { BirthDate = new DateOnly(2000,1,1),Id=1,Name="Ali",LastName="Yilmaz" };
            //Kisi kisi1 = new Kisi() { BirthDate = new DateOnly(2000, 2, 1), Id = 2, Name = "Ayse", LastName = "Kaya" };

            //Kisi kisi2 = new Kisi() { BirthDate = new DateOnly(2000, 3, 1), Id = 3, Name = "HAsan", LastName = "can" };

            //Kisi kisi3 = new Kisi() { BirthDate = new DateOnly(2000, 4, 1), Id = 4, Name = "Fatma", LastName = "Gezer" };


            //List<Kisi> kisis = new List<Kisi> { kisi, kisi1, kisi2, kisi3 };

            //kisis.Where(p => p.Id > 2);
            //kisis.Where(kisi => KisiBul(kisi));


            //kisis.Where(p=>p.BirthDate.Month > 1);
            //kisis.Where(p => KisiAyaGoreBul(p));
            //Console.WriteLine("Hello, World!"); 
            #endregion

            #region Parametresiz Delegate Ve Action

            //PArametre almayan Action 
            //Action action = new Action(Action1);
            //action();
            Action action = () => { Console.WriteLine("Action Delegate"); };
            action.Invoke();
            Action action1 = new Action(Action1);
            action1 += Action2;
            action1.Invoke();
            #endregion


            #region Parametreli Action 
            // Generic Action Delegatler geri donus degeri olmayan en fazla 16 adet parametre gecilebilen delegatlerdir
            Action<string> parametreliAction = new Action<string>(DisplayMsg);
            parametreliAction.Invoke("Helo Mars");
            Action<int, int> toplaAction = new Action<int, int>((x, y) => Console.WriteLine(x + y));
            #endregion

            #region Predicate Delegate => geriye bool donen ve en fazla 16 adet parametre alan delege turudur
            Predicate<int> predicate = new Predicate<int>(p => p % 2 == 0);
            Predicate<int> predicate1 = new Predicate<int>(p => TekCift(p));
            Predicate<int> predicate2 = TekCift;

            #endregion

            #region Func<> delegate
            /*Func(Önceden Tanımlanmış Delege Türü)
     Func<T> önceden tanımlanmış olan ve T tipinde değerler döndüren metodları temsil eden 
     bir delegedir.Func<T> tipi birden fazla parametre ile beslenebilecek şekilde 
     hazırlanmış bir tiptir. Yani bir veya birden fazla parametre alabilecek metodları 
     temsil eden önceden tanımlanmış bir delege türüdür.

     Func<T> kullandığımızda delege tanımlamamıza gerek kalmamaktadır.
         Func<T> Geri Donus tipi T Tpinden ve parametre almayan metodlari temsil eder
         Func<T, Tresult> T parametresi alan ve Tresult tipini donen metodlari temsil eder
         Func<T1, T2, Tresult>
         Func<T1, T2,…T3, Tresult>
     Her bir T metodun alacağı parametre tipini ve TResult ise temsil edilen 
     metodun dönüş tipipni temsil etmektedir.
     Func tipi, bir veya birden fazla(16 haneye kadar) parametre alabilen ve geriye T
     tipinde değer döndüren bir delege yapısıdır.Bu delege sayesinde, alacağı parametreler
     ve geriye döndüreceği değeri simgeleyen delegemizi tanımlayabilir ve o
     tanımladığımız yapıdaki herhangi bir metodu bu delegeye işaretletebiliriz.
     Eğer bir işlemde delegeye ihtiyacınız varsa, Func ile hızlı ve pratik bir
     şekilde ihtiyacınızı giderebilir ve delegeyle uğraşmanıza gerek kalmayabilir.*/

            Func<int> func = new Func<int>(Func1);

            Func<int, long> func1 = new Func<int, long>(KareAl);
            Func<int, string, DateTime, long> func2 = new Func<int, string, DateTime, long>(Func3);
            Func<int, string, DateTime, long> func3 = delegate (int sayi, string str, DateTime trh) { return sayi * sayi * sayi; };
            Func<int, string, DateTime, long> func4 = (int sayi, string str, DateTime trh) => { return sayi * sayi * sayi; };
            Func<int, string, DateTime, long> func5 = (int sayi, string str, DateTime trh) =>
            {

                if (str.Length == 0) return sayi * sayi;
                else return sayi * sayi * sayi;

            };
            Func<int, string, DateTime, long> func6 = (int sayi, string str, DateTime trh) => (str.Length == 0 ? sayi * sayi : sayi * sayi * sayi);
            func1(5);
            Console.WriteLine(func());
            //Func<LogMessage, string> func3 = new Func<LogMessage, string>(LogMetodFunc);
            //LogMessage logMessage = new LogMessage()
            //{
            //    MessageID = 1,
            //    Message = " Kendi Modelimiz Gectigimiz Func delegate. ",
            //    MessageTime = DateTime.Now

            //};

            sehirler.Where(p => p.ToLower().StartsWith("a"))
                       .ToList()
                       .ForEach(p => Console.WriteLine(p));

            #endregion

        }
        public static long Func3(int sayi, string str, DateTime tarih)
        {
            if (str.Length == 0) return sayi * sayi;
            else return sayi * sayi * sayi;

        }
        public static long KareAl(int sayi)
        {
            return sayi * sayi;
        }
        public static int Func1()
        {
            return 4;
        }
        public static bool TekCift(int sayi)
        {
            return sayi % 2 == 0;
        }
        public static void Topla(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void DisplayMsg(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void Action2()
        {
            Console.WriteLine("Action 2");
        }
        public static void Action1()
        {
            Console.WriteLine("Action 1");
        }
        public static bool KisiAyaGoreBul(Kisi kisi)
        {
            return kisi.BirthDate.Month > 1;
        }

        public static bool KisiBul(Kisi kisi)
        {
            return kisi.Id > 2;
        }
    }
}
