using _7_Abstract.AlanHesaplari;

namespace _7_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Muzik Ornegi
            //Gitar gitar = new Gitar() { Marka="Fender" ,Model="xyz"};
            // Flut flut = new Flut() { Marka="Yamaha" ,Model="abc"};

            // Piyano piyano = new Piyano() { Marka = "Roland", Model = "qwe" };
            // Console.WriteLine(gitar);
            // Console.WriteLine(flut);
            // Console.WriteLine(piyano);
            // Console.WriteLine(gitar.Cal());
            // Console.WriteLine(flut.Cal());
            //flut.AkordYap();
            // gitar.AkordYap();

            // List<MuzikAleti> muzikAletis = new List<MuzikAleti>();
            // muzikAletis.Add(gitar);
            // muzikAletis.Add(flut);
            // muzikAletis.Add(piyano);
            // Muzisyen ismailYk = new Muzisyen(muzikAletis);
            //  Console.WriteLine(ismailYk);
            #endregion

            #region Sekil Ornegi

            DikUcgen dikUcgen = new DikUcgen() { KisaKenar = 3, UzunKenar = 4 };
            Kare kare = new Kare() { UzunKenar = 5, KisaKenar = 5 };
            List<Sekil> sekils = new List<Sekil>() { kare, dikUcgen };

            AlanHesaplayici hesaplayici = new AlanHesaplayici(sekils);
           

            //Console.WriteLine(hesaplayici.AlanHesapla());

            //Console.WriteLine(hesaplayici.CevreHesapla());

            Console.WriteLine(hesaplayici);

            #endregion
        }
    }
}
