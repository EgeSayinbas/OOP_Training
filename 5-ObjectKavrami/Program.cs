using _3_ClassLib.Personeller;

namespace _5_ObjectKavrami
{
    internal class Program
    {
        #region Konu Anlatimi
        /*
         * c# dilinde herşey bir objedir.
         * Yani tanimlanan butun değişkenler aslinda arka planda object sinifindan miras alir.
         * 
         * Object sinifi ile gelen 4 adet metod vardir.
         * Equels , ToString,GetType ve GetHashCode metodlaridir.
         * 
         * 
         */
        #endregion
        static void Main(string[] args)
        {
            Temp temp = new Temp();
            temp.Adi = "Ali";
            temp.Soyadi = "Kaya";
            Temp temp1 = new Temp();
            Temp2 temp2 = new Temp2();
            object obj = new object();
            Kisi kisi = new Kisi("ayse", "can");
            #region ToString Metodu
            // Default davranisinda namesapace.<class adi> seklinde bir cikti verir
            //Console.WriteLine(temp.ToString());
            #endregion

            #region Equal metodu
            // iki nesneyi esit olup olmadigina yarar 
            //Console.WriteLine(temp.Equals(temp1)); // temp1 nesnesi temp2 nesnesine esitmi ?

            #endregion

            #region GetHashCode 
            // c# her nesne olusturuldugunda bir hash kod uretilir. uretilen code uzerinden  farkliliklar kontrol edilebilir
            //Console.WriteLine(temp.GetHashCode());
            //Console.WriteLine(temp1.GetHashCode());
            //Console.WriteLine(temp2.GetHashCode());
            #endregion

            #region GetType Metodu
            #region Bir objenin propertyleri
            //var result =temp2.GetType().GetProperties();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion
            #region Bir objenin Metodlari

            //Console.WriteLine("********* Metodlari **********");

            //var metodlar = temp2.GetType().GetMethods();
            //var baseclass = temp2.GetType().BaseType;
            //Console.WriteLine("Kalitim aldigi Sinif:"+baseclass);
            //foreach (var method in metodlar)
            //{
            //    Console.WriteLine(method.Name);
            //}
            #endregion

            #region Bir objenin constructor'lari 
            //var constructors = kisi.GetType().GetConstructors();
            //foreach (var constructor in constructors)
            //{
            //   var parameters= constructor.GetParameters();
            //    Console.WriteLine("**************");
            //    foreach (var item in parameters)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}
            #endregion

            #region  object 'lerde is ve as operatoru

            #region is operatoru =>  nesneyi tip karsilarstirir
            List<object> cuval = new List<object>();
            cuval.Add(5);
            cuval.Add(DateTime.Now);
            cuval.Add(temp);
            cuval.Add(obj);
            cuval.Add(kisi);
            int abc = new int();
            

            foreach (var item in cuval)
            {
                if (item is Temp)
                {
                    Console.WriteLine("Temp sinifi:" + (item as Temp).Adi);
                }
                else if (item is Int32)
                {
                    Console.WriteLine("integer deger:" + item.ToString());
                }
                else if (item is DateTime)
                {
                    Console.WriteLine("Tarih:" + item.ToString());
                }
                else if (item is Kisi)
                {
                    var qwe = (Kisi)item;
                    qwe = item as Kisi;
                    Console.WriteLine("Ad Soyad:" + qwe.Adi + " " + qwe.Soyadi);
                }
                else
                {
                    Console.WriteLine("Object :" + item.ToString());

                }
            }
            #endregion

            #region as operatoru
            /*
             * is operatörü kontrol ile bool bir değer döndürürken as operatörü ilgili tipin 
             * referansını döndürmektedir. Eğer yapılan cast işlemi hatalı ise null 
             * değerini döndürmektedir.
             * 
             */
            object kisi1 = temp ;
           
            Console.WriteLine((kisi1 as Temp).Adi);
            Console.WriteLine((kisi1 as Temp).Soyadi);
            Console.WriteLine(temp.Adi);
            Console.WriteLine(temp.Soyadi);

            #endregion
            #endregion




            //var assembly = System.Reflection.Assembly.GetExecutingAssembly;

            //Console.WriteLine(assembly);
            #endregion

            bosclass a = new bosclass();
            

           
        }
    }
    class bosclass
    {

    }
}
