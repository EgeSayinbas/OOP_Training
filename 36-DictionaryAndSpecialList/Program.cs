using System.Text.Json;
using System.Text.Json.Nodes;

namespace _36_DictionaryAndSpecialList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary
            ////Key value degerleri tutan ozel listedir.
            ////bildigimiz sozluk gibi calisir.
            //object obj = new object();
            //Dictionary<string,string> dictionary = new Dictionary<string,string>();
            //dictionary.Add("apple", "elma");
            //dictionary.Add("window", "pencere");

            //Dictionary<string, List<string>> dictionaryList = new Dictionary<string, List<string>>();
            //Dictionary<object,object> dictionary3 = new Dictionary<object,object>();
            //dictionary3.Add("txt", "notepad.exe");
            //dictionary3.Add("jpeg", "paint.exe");
            //dictionary3.Add("csv", "Excel.exe");
            //dictionary3.TryGetValue("csv",out obj);
            //Console.WriteLine((string)obj.ToString());

            //string json = """{name:"ali",gsm:533 444 22 11"}""";
            //var sonuc=JsonSerializer.Serialize(json);  
            //Console.WriteLine(sonuc); 
            #endregion

            #region Stack Last in First out => LIFO

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);
            //stack.Push(7);

            //stack.Pop(); //7 cikti
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Queue Kuyruk FIFO first in first out
            ////kuyruga ekleme
            //Queue<int> sayilar = new();
            //sayilar.Enqueue(1);
            //sayilar.Enqueue(2); 
            //sayilar.Enqueue(3);
            //sayilar.Enqueue(4);
            //sayilar.Enqueue(5);
            //sayilar.Enqueue(6);
            //sayilar.Enqueue(7);
            //sayilar.Enqueue(8);

            ////kuyruktan cikarma dequeue

            //sayilar.Dequeue(); //1 cikti
            //sayilar.Dequeue(); //2 cikti

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region SortedList
            //SortedList<int,string> numberNames = new SortedList<int,string>();

            ////karisik ekleme yapilsa da kendi key e gore siralar
            //numberNames.Add(3, "Three");
            //numberNames.Add(1, "One");
            //numberNames.Add(2, "Two");
            //numberNames.Add(4, "Four");
            //foreach (var item in numberNames)
            //{

            //    Console.WriteLine($"Key: {item.Key} Value : {item.Value}");
            //}
            #endregion

            #region HashSet 

            //HashSet<Kisi> kisis = new HashSet<Kisi>();
            //Kisi ali=new Kisi { Id = 1,AdSoyad="Ali" };
            //Console.WriteLine("Ali HashCode:" + ali.GetHashCode());
            //Kisi ayse = new Kisi { Id = 2, AdSoyad = "ayse" };
            //Console.WriteLine("Ayse HashCode:" + ayse.GetHashCode());
            //Kisi fatma = new Kisi { Id = 3, AdSoyad = "fatma" };
            //Console.WriteLine("Fatma HashCode:" + fatma.GetHashCode());

            //Kisi berk = new Kisi { Id = 3, AdSoyad = "QWEQWEE" }; // ayni id ve farkli adsoyad a sahip atarsak ikisinide ayri ayri tutar bir sorun olmaz


            ////aynisini bir co kkere eklesekte 1 tane olarak gosterir
            //kisis.Add(ali);
            //kisis.Add(ayse);
            //kisis.Add(fatma);
            //kisis.Add(ali);
            //kisis.Add(ali);
            //kisis.Add(ali);
            //kisis.Add(ayse);
            //kisis.Add(fatma);
            //kisis.Add(fatma);
            //kisis.Add(berk);
            //foreach (var item in kisis)
            //{
            //    Console.WriteLine(item.Id + " "+ item.AdSoyad + " " + item.GetHashCode());
            //}


            #endregion

            #region Tuple Tanimlama

            //tuple birden fazla veri tipini barindiran ayri bir veri türüdur.
            Tuple<int, string, string> person = new Tuple<int, string, string>(1, "ali", "can");

            var person2 = TestTuple(2, "ayse", "kaya");

            #endregion
            Console.WriteLine(person.Item2);
        }
        public static Tuple<int, string, string> TestTuple(int x,string y,string z)
        {
            return Tuple.Create(x,y,z);
        }
            

    }
    public class Kisi
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
    }
}
