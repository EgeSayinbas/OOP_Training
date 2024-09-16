using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace _35_OOPGENELTEKRAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Abstraction , Interface ,
             * Delegate , Event
             * 
             * 
             * 
             * 
             */

            #region Abstract Class'lar
            // Abstract Class lar Sadece base class olarak davranir.
            // Yani kalitim veririr
            // ancak Instance alinamaz.

            // abstract keyword'u class disinda metodlara ve property'lere de verilebilir.


            // Bir metod abstract olarak isaretlendiyse mutlaka overide edilmesi gerekir.
            // Abstract metodlarda govde olmaz. Yani icerigi kalitim alan sinflarda yazilmak zorundadir.


            /*    Abstract Metodlarda Dikkat edilmesi gerekenler

             1- Abstract metodlar private olarak tanimlanamazlar
             2- Abstract metodlar sadece abstract classlar icerisinde tanimlanabilir.
             3- Abstract metodlar virtual olarak tanimlanamazlar
             4- Abstract metodlar static olarak da isaretlenemezler. 
             5- Abstract metodlar in govdesi olmaz. Miras olarak alan sinif tarafindan yazilmak zorundadir 
             */

            // Abstract class'larda constructer olurmu ? Olur . 

            // virtual keyword'u metodlari yada property'leri kalitim verilen yerlerde override edebilmek icin kullanilir.
            // yani bir metodun yeniden yazilmasini istiyorsak virtaul olarak isaretlenmesi gerekir. 
            // diger metodlar ise concret  yapidadir.

            // Genel Kullanimda property'leri ve onemli metodlari govdeleri ile breraber  tutan bir yapida kullanilabilir.
            // Geri kalan metodlar ise bir interface icerisinde tanimlanmasi uygundur.
            TestA a = new TestA();
            #endregion

            #region Interface
            /* interface'ler metod imzalarini bulundurur. 
             *  Metod govdeleri kalitim alinan yerde tanimlanmak zorundadir.
             *  
             *  Class'lara yetenek kazandir. Yani metodlar vasitasi ile ne yapabileceklerini 
             *  yada ne yapmalari gerektigini belirler . Class'lar icin klavuzluk yapar.
             *  
             *  icerisinde property tanimlamalari da olabilir . Ihtiyaca istinaden eklenebilir
             * 
             *  Dikkat edilmesi gereken durum eger kalitim verecek olan yerde interface icerisinde uygulayamayacagi bir metod varsa
             *  bu metodu ayri bir interface icerisine almakta fayda vardir. Class yetenegi olmayan bir metodu implimente edemez.
             * 
             * Interface'ler veri tipi olarak kullanilabilir. Bu durumda olusacak nesnenin yetekeleriyle ilgileniyoruz demektir.
             * 
             */

            #endregion
            //TestA testA = new TestA(); // TestA  class'inin butun ozelikleri ve yetenekleri gelir.
            //ITest itest = new TestA(); // Sadece ITest yeteneklerini istiyorum. Class'in gere kalan ozellikleri ve yetenekleri beni ilgilendirmiyor
            //absC absC = new TestA(); // absC classindaki ozellikler ve yeteneklerle ilgileniyorum
            //abstractClass abstractClass = new TestA(); // sadece abstractClass icerisndeki ozelikler ve yeteneklerle igilileniyorum demek.

            #region Delegate'ler 
            /*
             * delegat'lere kisaca metod pointer olarak kullanili. 
             * Ozunde yazdigimiz butun metodlar hafiza da heap alanin da tutulur.
             * delegate de bu alanalarin adresini tutan yapilardir.
             * Metod imzasini bilmek zorundadir ki Invoke metodu calisabilsin
             * 
             * Gunluk hayatta daha cok event 'lerde kullanilir. 
             * 
             * .NET Core icerisinde Microsoft tarafindan yazilmis 4 adet ozel delegate tipi vardir. 
             * 1- EventHandler => void MetodAdi(object? sender,EventArg e) seklindeki butun metod imzalarini temsil
             *    eden ozel delegate'lerdir.
             * 2- Action => Buda geri donus tipi olmayan ve parametre almayan metodlari temsil eder .
             *    Action<> Generic actin icerisinde ise grei donus tipi olmayan fakat parametre olarak generic ifade gecilebilien metodlari temsil eder.
             * 3- Predicate<> => Buda geri donus tipi bool olan ve 16 adet parametre alabilen metodlari temsil eder
             * 4- Func<> => bu gecerik ifadede aldigi en son parametre geri donus tipini temsil edecek sekilde , geri kalan generic ifadelr ise 
             *     Metoda gelecek parametreleri temsil eder. 
             *     
             * Bu ozel deleget'lerden son 3 adedi LINQ sorgularinda yogunluklu kullanilir.
             * 
             * Aslinda Predicate delegate yerine Func delegate te kullanilabilir. Sonucta geri donus tipi belirlenebilen bir delege yapimiz var
             * Func<Product,bool> => proedicate delegate anlimina gelir.
             * 
             */

            string sqlconstr = "server=.;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=true";
            SqlConnection db = new SqlConnection(sqlconstr);

            var urunler = db.GetAll<Product>().ToList();

            //foreach (var item in urunler)
            //{
            //    Console.WriteLine(item.ProductId + " " + item.ProductName);
            //}

            //Action Delegate alan ForEach metosdunun kullanimi

            urunler.ForEach(urun => MyForEach(urun));
            urunler.ForEach(urun => Console.WriteLine(urun.ProductId + " " + urun.ProductName));
            //fiyati 10 dan kucuk olanlarin listesi.


            var fiyatidusukolanlar2 = urunler.Where(urun => { return urun.UnitPrice < 10; }).ToList();
            var fiyatidusukolanlar1 = urunler.Where(urun => UrunFiyat(urun)).ToList();
            var fiyatidusukolanlar = urunler.Where(urun => urun.UnitPrice < 10).ToList();
            #endregion

            #region kritik stok seviyesi listesi
            //Console.WriteLine("****************kritik stok ****************");
            ////stok sayisi 10 ve asagisi olan urunler
            //var kritikStok = urunler.Where(p => p.UnitsInStock < 10).ToList();
            //foreach (var item in urunler)
            //{
            //    Console.WriteLine(item.ProductId + " " + item.ProductName);
            //}
            //urunler.Where(p => p.UnitsInStock < 10).ToList().ForEach(urun => Console.WriteLine(urun.ProductId + " " + urun.ProductName+" " + urun.UnitsInStock)); 
            #endregion

            #region 20 adetten fazla siparis verilen urunler hangileridir
            //urunler.Where(urun => urun.UnitsOnOrder > 20).ToList().ForEach(urun => Console.WriteLine(urun.ProductId + " " + urun.ProductName + " " + urun.UnitsOnOrder));
            #endregion
            #region artik satis yapilmayan urunler
            //Console.WriteLine("*********aktif olmayan urunler**********");
            //urunler.Where(urun => urun.Discontinued==true).ToList().ForEach(urun => Console.WriteLine(urun.ProductId + " " + urun.ProductName + " " + urun.Discontinued));


            #endregion
            #region skip
            //Console.WriteLine("*******skip**********");
            //urunler.Skip<Product>(70).ToList().ForEach(urun => Console.WriteLine(urun.ProductId + " " + urun.ProductName));
            #endregion
            #region Extra Komutlar
            Console.WriteLine("*******skip70**********");
            urunler.Skip<Product>(70).ToList().ForEach(urun => Console.WriteLine(urun.ProductId + " " + urun.ProductName));


            Console.WriteLine("*******skip 70 and take 3 **********");
            urunler.Skip<Product>(70).Take(3).ToList().ForEach(urun => Console.WriteLine(urun.ProductId + " " + urun.ProductName));

            #endregion
            Console.WriteLine("Hello, World!");
        }
        public static bool UrunFiyat(Product urun)
        {
            return urun.UnitPrice < 10;
        }
        public static void MyForEach(Product urun)
        {
            Console.WriteLine(urun.ProductId + " " + urun.ProductName);
        }

    }

    public class implementInterface : TestA, ITest
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void TestA()
        {
            throw new NotImplementedException();
        }

        public void TestB()
        {
            throw new NotImplementedException();
        }
    }

    public interface ITest
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public void ITest_A();
        public void ITest_B();

    }

    public class TestC : ITest
    {
        public TestC()
        {

        }

        public int ID { get; set; }
        public string Name { get; set; }
        public void ITest_A()
        {

        }

        public void ITest_B()
        {

        }
    }

    public abstract class absC : TestC
    {
        protected absC()
        {

        }

        public void absCMetod1()
        {

        }
    }

    public abstract class abstractClass : absC
    {

        public abstract int Id { get; set; }

        public abstract void Test();
        protected abstractClass()
        {

        }

        public virtual void abstractClassVirtual()
        {
            Console.WriteLine("Test B");
        }
    }
    public class TestA : abstractClass
    {
        public override int Id { get; set; }

        public override void Test()
        {
            Console.WriteLine("adfads");
        }
        public TestA()
        {

        }

    }
}