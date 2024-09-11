namespace _24_EventKumanda
{
    internal class Program
    {
        #region Kumandaya basilinca arabanin kapilari acilsin

        #endregion
        static void Main(string[] args)
        {
            Kumanda k1 = new Kumanda("qwe");
            Kumanda k2 = new Kumanda("123");
            Kumanda k3 = new Kumanda("asd");
            Kumanda k4 = new Kumanda("xyz");

            Araba araba1 = new Araba("BMW", "asd");
            //Araba araba2 = new Araba("Aston", "qwe");
            //Araba araba3 = new Araba("Tofas", "123");
            //Araba araba4 = new Araba("Bentley", "xyz");


            k1.KumandayaBas += araba1.SinyalAl;
            k2.KumandayaBas += araba1.SinyalAl;
            k3.KumandayaBas += araba1.SinyalAl;
            k4.KumandayaBas += araba1.SinyalAl;

            k1.TusaBas();
            k2.TusaBas();
            k3.TusaBas();
            k4.TusaBas();

        }
    }
}
