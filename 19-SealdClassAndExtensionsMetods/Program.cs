using System.Data.SqlClient;

namespace _19_SealdClassAndExtensionsMetods
{
    internal class Program
    {
        /*
         * Seald class'lar kalitim vermez . Ancak instance alinabilir.
         * Bu yapisi ile abstract class'in tam tersidir.
         * 
         * Muhurlu classlardir 
         * 
         * 
         */
        static void Main(string[] args)
        {
            string kelime = "çığşöü";
            
            Console.WriteLine(kelime.TurkceKarakterleriTemizle());
            SqlConnection connection = new();
            connection.MyExtensionConnection();
        }
    }
}
