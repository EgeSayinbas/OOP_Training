namespace _26_EventYangin
{
    internal class Program
    {
        #region Konu
        /*
         * Bir mahallede Insanlar olsun.
         * Bazilari sigara icsin.
         * Sigara icilmesinden ya da kisa devreden dolayi yangin ciksin
         * Yangin cikinca alarm calsin. Itfaiyeye haber versin
         * Alarm calinca komsular rahatsiz olsun ya da kacsin
         * 
         */
        #endregion
        static void Main(string[] args)
        {
            Kablo kablo = new Kablo();
            Sigara sigara = new Sigara("MarlBoro");
            Alarm alarm = new Alarm();  
            Itfaiye itfaiye = new Itfaiye();
            Insan ali = new Insan("Ali");
            Insan veli = new Insan("Veli");
            Insan ayse = new Insan("Ayse");
            Insan fatma = new Insan("Fatma");
            Insan hasan = new Insan("Hasan");

            kablo.Yandim += alarm.AlarmCal;
            alarm.AlarmCaldi += itfaiye.MudahaleEt;
            alarm.AlarmCaldi += ali.RahatsizOl;
            alarm.AlarmCaldi += ayse.Kac;
            alarm.AlarmCaldi += fatma.RahatsizOl;
            alarm.AlarmCaldi += fatma.Kac;
            alarm.AlarmCaldi += hasan.RahatsizOl;

            sigara.Yandim += alarm.AlarmCal;
            sigara.Yandim += itfaiye.MudahaleEt;

            sigara.Yandim += ali.RahatsizOl;
            sigara.Yandim += ayse.RahatsizOl;

            sigara.SigaraIc();//tetikleyici metod
            kablo.AkimGecir();//tetikleyici metod

        }
    }
}
