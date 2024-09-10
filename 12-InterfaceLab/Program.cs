using _12_InterfaceLab.FirinOrnegi;
using _12_InterfaceLab.InsanKaynaklari.Concrete;
using _12_InterfaceLab.LokantaOrnegi;

namespace _12_InterfaceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Firin Ornegi
            //#region Concrete instance Alma
            //Usta usta = new Usta() { AdSoyad = "HAsan Usta" };
            //Makina makina = new Makina() { MakinaAdi = "Yogurma makinasi " }; 
            //makina.Start();
            //usta.MolaVer();
            //#endregion
            //// interfacelerden instance alinmaz
            //#region Interface uzerinden instance alma
            //IYogurma usta1= new Usta() { AdSoyad = "HAsan Usta" };
            //IYogurma makina1 = new Makina() { MakinaAdi = "Yogurma makinasi " };
            //usta1.HamurYogur();
            //makina1.HamurYogur();
            //#endregion

            //KaraFirin karaFirin = new KaraFirin();
            //karaFirin.EkmekPisir(usta);
            //karaFirin.EkmekPisir(makina); 
            #endregion

            #region LokantaOrnegi

            #region Concrete instance alma
            //Pilav pilav = new Pilav();
            //Kofte kofte = new Kofte();
            //KuruFasulye kuru = new KuruFasulye();
            //Sutlac sutlac = new Sutlac(); 
            Salata salata = new();
            #endregion

            #region Interface uzerinden instance alma
            IPisirilebilir pilav = new Pilav();
            IPisirilebilir kofte = new Kofte();
            IPisirilebilir kuru = new KuruFasulye();
            IPisirilebilir sutlac = new Sutlac();
            // IPisirilebilir qwe = new Salata();
            #endregion
            //List<IPisirilebilir> pisirilebilirs = new List<IPisirilebilir>();
            //pisirilebilirs.Add(pilav);
            //pisirilebilirs.Add(kofte);
            //pisirilebilirs.Add(kuru);
            //pisirilebilirs.Add(sutlac);
            ////pisirilebilirs.Add(salata);

            //BorsaLokantasi borsaLokantasi = new BorsaLokantasi();
            //borsaLokantasi.YemekPisir(pisirilebilirs);
            #endregion

            /*
             
             It Elemani arayan bir firmanin insan kaynakalarindaki basvuru surecini modelleyin
             
             
             */

            ItBasvuru basvuru = new ItBasvuru()
            {
                EhliyetVarmi = true,
                Departman = InsanKaynaklari.Abstract.Departman.IT,
                isAjax = true,
                isCSS3 = true,
                isEDP = true,
                isJavaScript = true,
                isJQUERY = true,
                isOOP = true,
                isWCF = true,
                
                Basvuran = new Kisi { Ad="Ali",Soyad="Yilmaz",Cinsiyet=true,Askerlik=true},
                isRazor=true
            };
            
            ItBasvuru basvuru2 = new ItBasvuru()
            {
                EhliyetVarmi = true,
                Departman = InsanKaynaklari.Abstract.Departman.IT,
                isAjax = true,
                isCSS3 = true,
                isEDP = true,
                isJavaScript = true,
                isJQUERY = true,
                isRazor = true,
                isJson = true,
                isOOP = true,
                isWCF = true,
                SeyahatEngelVarmi = true,
                UniversiteMezunumu=true,                
                Basvuran = new Kisi { Ad="Ayse",Cinsiyet=false,Soyad="Kaya"}
            };

            FinansBasvuru basvuru3 = new FinansBasvuru()
            {
                EhliyetVarmi = true,
                Departman = InsanKaynaklari.Abstract.Departman.Finans,
                isExcel = true,
                isMicro =false,
                SeyahatEngelVarmi = true,
                UniversiteMezunumu = true,
                Basvuran = new Kisi { Ad = "Fatma", Cinsiyet = false, Soyad = "Er" }
            };
            FinansBasvuru basvuru4 = new FinansBasvuru()
            {
                EhliyetVarmi = true,
                Departman = InsanKaynaklari.Abstract.Departman.Finans,
                isExcel = true,
                isMicro = false,
                SeyahatEngelVarmi = true,
                UniversiteMezunumu = true,
                Basvuran = new Kisi { Ad = "Hasan", Cinsiyet = false, Soyad = "Can" }
            };

            IK ik = new IK();
            ik.FinansBasvurusuAl(basvuru4);
            ik.FinansBasvurusuAl(basvuru3);

            ik.ITBasvurusuAl(basvuru);
            ik.ITBasvurusuAl(basvuru2);

            ik.GenelBasvuruAl(basvuru);
            ik.GenelBasvuruAl(basvuru2);
            ik.GenelBasvuruAl(basvuru3);
            ik.GenelBasvuruAl(basvuru4);


            //ik.GenelBasvuruListele();
           var sonuc =  ik.ITBasvurusulariniVer().Where(p=>p.isOOP==true&&p.isWCF==true  && p.Basvuran.Cinsiyet==false).ToList();
            sonuc.ForEach(p => Console.WriteLine(p));
        }
    }
}
