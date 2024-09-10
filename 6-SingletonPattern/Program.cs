using System.Data.SqlClient;

namespace _6_SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection con1=  SqlBaglanti.GetConnection();
            SqlConnection con2 = SqlBaglanti.GetConnection();
            SqlConnection con3 = SqlBaglanti.GetConnection();
            Console.WriteLine(con1.GetHashCode());
            Console.WriteLine(con2.GetHashCode());
            Console.WriteLine(con3.GetHashCode());

            Console.WriteLine("Hello, World!");
        }
    }
}
