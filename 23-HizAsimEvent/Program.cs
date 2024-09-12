namespace _23_HizAsimEvent
{
    public class Program
    {
        #region Senaryo
        /*
         * Bir araba class imiz olacak. Hiz bilgisi tutulacak.
         * 120yi gecince hiz sinrini astiniz uyarisi verecek.
         * 
         */
        #endregion
        static void Main(string[] args)
        {
            Araba araba = new Araba("BMW", 90);
            
            araba.HizAsim += HizAsildi;
            for(int i =100;i<150;i=i+10)
            {
                araba.Hiz = i;
            }
        }
        public static void HizAsildi()
        {
            Console.WriteLine("araba hiz limitini asti");
        }
    }
}
