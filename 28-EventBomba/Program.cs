namespace _28_EventBomba
{
    internal class Program
    {
        public delegate void EventHandler(string x, object sender);
        static void Main(string[] args)
        {
            /*
             * Bomba bomba=new Bomba();
             * Telefon telefon= new Telefon();
             * telefon.KelimeKullanildi +=bomba.Patla
             * 
             * telefon.Gorusme();
             */

            Bomba bomba = new Bomba();
            Telefon telefon = new Telefon();
            telefon.KelimeKullanildiEvent += bomba.Patla;

            telefon.Gorusme();


        }
    }
}
