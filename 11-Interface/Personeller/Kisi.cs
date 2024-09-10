using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interface.Personeller
{
    public class Kisi
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
        public string Gsm { get; set; }
        public bool Cinsiyet { get; set; }
        public string Email { get; set; }

        public Kisi(string ad,string soyad)
        {
            
            Adi = ad;
            Soyadi = soyad;
        }

        #region Kod Tekrarli Olan Constructer
        //public Kisi(string ad, string soyad,string tcno)
        //{
        //    Adi = ad;
        //    Soyadi = soyad;
        //    TcNo = tcno;
        //}
        //public Kisi(string ad, string soyad, string tcno,string gsm)
        //{
        //    Adi = ad;
        //    Soyadi = soyad;
        //    TcNo = tcno;
        //    Gsm = gsm;
        //}
        //public Kisi(string ad, string soyad, string tcno, string gsm,string email)
        //{
        //    Adi = ad;
        //    Soyadi = soyad;
        //    TcNo = tcno;
        //    Gsm = gsm;
        //    Email = email;
        //} 
        #endregion

        public Kisi(string ad, string soyad,string tcno):this(ad,soyad)
        {
           
           TcNo = tcno;
        }
        public Kisi(string ad, string soyad, string tcno,string gsm) : this(ad, soyad,tcno)
        {
            Gsm = gsm;
        }
        public Kisi(string ad, string soyad, string tcno, string gsm,string email) : this(ad, soyad, tcno)
        {
            Email = email;
        }

        public void Kisibilgileri()
        {
            Console.WriteLine(Adi + " " + Soyadi + " " + TcNo==null?"":TcNo);
        }
    }
}
