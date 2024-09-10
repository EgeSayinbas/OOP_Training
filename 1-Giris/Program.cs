using System.Security.Principal;

namespace _1_Giris
{
    public struct Kisi
    {
        public string Ad;
        public string Soyad;
        string _TcNo;
        public string Gsm;
        //Kontrollu veri girisi. Tc numarai illa 11 karakter olacak 
        public void SetTcNo(string value)
        {
            if (!string.IsNullOrEmpty(value) && value.Length == 11)
            {
                _TcNo = value;
            }
        }
        // TcNo'nun son 4 hanesini gostermek
        public string GetTcNo()
        {
            if (!string.IsNullOrEmpty(_TcNo))
            {
                return _TcNo.Substring(7);
            }
            else
            {
                return "";
            }
        }

    }
    public class Personel
    {
        string _Tcno;
        string _Ad;
        // Boş Property
        public string Ad { 
            get 
            { 
                return _Ad; 
            } 
            set
            { 
                if(!string.IsNullOrEmpty(_Ad)) _Ad = value;
            } 
        }
        public string Soyad { get; set; }

        // TcNo Kapsullenmis . Get ve set metodlari kosula bagli veri girisi , çıkışı sayliyor
        public string TcNo {
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length == 11)
                {
                    _Tcno = value;
                }
            }
            get {
                if (!string.IsNullOrEmpty(_Tcno))
                    return _Tcno.Substring(7);
                else return "";
            }
           
        }
        public string Gsm { get; set; } = string.Empty;
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Struct ile Calismak
            Kisi kisi = new Kisi();
            kisi.Ad = "Ali";
            kisi.Soyad = "Yilmaz";
            kisi.SetTcNo("123123123");
            Console.WriteLine(kisi.GetTcNo());
           
            #endregion
            #region Class ile calismak 
            Personel personel = new();
            personel.Ad = "Veli";
            
            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}
