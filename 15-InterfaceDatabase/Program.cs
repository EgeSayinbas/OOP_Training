using System.Data;
using System.Data.SqlClient;
using _15_InterfaceDatabase.Concrete;
using _15_InterfaceDatabase.Dtos;
using Dapper;
using MySql.Data.MySqlClient;
using Npgsql;
namespace _15_InterfaceDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sqlconstr = "server=.;Database=Northwind;Trusted_connection=True;TrustServerCertificate=true";
            SqlConnection connection = new(sqlconstr);
            //var result= connection.Query("Select * from Shippers");

            IDbConnection sqlCon = new SqlConnection(sqlconstr);
            IDbConnection pgCon = new NpgsqlConnection();
            //IDbConnection myCon = new MySqlConnection();

            //IDbCommand sqlCom = sqlCon.CreateCommand();
            //IDbCommand pgCom = pgCon.CreateCommand();
            //IDbCommand myCom = myCon.CreateCommand();

            //MyDatabase myDatabase = new MyDatabase(connection);
            //List<string> list = new();
            //IEnumerable<CustomerSelectDto> result =  connection.Query<CustomerSelectDto>("Select * from Customers");


            // foreach (var item in result)
            // {
            //     Console.WriteLine(item.CustomerId);
            //     Console.WriteLine(item.CompanyName);
            //     Console.WriteLine(item.ContactName);
            // }

            #region ShipperMAnager
            // ShipperManager manager = new ShipperManager(sqlCon);
            //var sonuc =  manager.GetAll();
            // foreach (var item in sonuc)
            // {
            //     Console.WriteLine(item.ShipperId);
            //     Console.WriteLine(item.CompanyName);
            //     Console.WriteLine(item.Phone);
            // } 
            #endregion

            #region ProductManager
            ProductManager manager = new ProductManager(sqlCon);
           var urun1= manager.GetById(1);
            Product p = new Product { ProductName = "Elma", UnitsInStock = 10, UnitPrice = 100 , Discontinued =true};
            int id = manager.Insert(p);
            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
