namespace _21_DelegateandEvent
{
    internal class Program
    {
        #region Konu anlatimi 
        /*
         * Event tanimlanabilmesi icin bir delegate e ihtiyac duyar.
         * Tanimlanan Eventin tipi mutlaka bir delegate olmak zorundadir. Class yada struct olamaz.
         * 
         * Delegate deki metod imzasina uygun metodu olay gerceklestiridiginde cagirir
         * Bir sinif icerisinde istediginiz kadar evet olabilir.
         * 
         * Onemli olan diger class'lardaki metodlara dogru bağlanmasidir.
         * Yani cagricayi yeri tanimlarken dikkat edilmesi yeterlidir.
         * 
         * 
         */
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hellos, World!");
        }
    }
}
