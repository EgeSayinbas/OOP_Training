using _31_GenericInterfaceAndClass.Abstract;
using _31_GenericInterfaceAndClass.Concrete;
using _31_GenericInterfaceAndClass.Entities;
using Dapper;
using Dapper.Contrib.Extensions;
using Npgsql;
using System.Data;
using System.Data.SqlClient;

namespace _31_GenericInterfaceAndClass
{
    internal class Program
    {
        /*
         * Dapper ve Dapper.Contrib paketi ile generic repository nasil olur 
         * 
         * 
         * 
         * 
         */
        public static string sqlconstr = "server=.;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=true";
        public static string postgreconstr = "Server=127.0.0.1;Port=5432;Database=Northwind;User Id=postgres;Password=qweasd;";
        static void Main(string[] args)
        {

            //List<int> list = new List<int>();
            //List<string> list2 = new List<string>();
            //List<BaseEntity<int>> list3 = new List<BaseEntity<int>>();   



            IDbConnection sqlcon = new SqlConnection(sqlconstr);
            IDbConnection pgcon = new NpgsqlConnection(postgreconstr);

            //Shipper shipper = new Shipper();
            //shipper.CompanyName= "Test";
            //shipper.Phone = "444 0999";

            #region Dapper ile Normal insert islemi
            //string sql = $"insert into shippers (CompanyName,Phone) values('{"XYZ Kargo"}', '{"444 0 888"}')";
            //int sonuc = sqlcon.Execute(sql);
            //Console.WriteLine("Sonuc :" +sonuc);
            #endregion

            #region Dapper Contrib ile Insert islemi

            //var id= sqlcon.Insert<Shipper>(shipper);
            // Console.WriteLine("Id:"+id);
            #endregion

            ShipperManager manager = new ShipperManager(sqlcon);
            ShipperManager shipperManager = new ShipperManager(pgcon);

            IManager<Product> productManager = new Manager<Product>(sqlcon);

            Product product = new Product()
            {
                CategoryId = 1,
                SupplierId = 1,
                ProductName = "Armut",
                UnitPrice = 50
            };

            var id = productManager.Insert(product);
            Console.WriteLine("Id" + id);
            //SqlConnection
            Console.WriteLine("Hello, World!");


        }
    }
}

