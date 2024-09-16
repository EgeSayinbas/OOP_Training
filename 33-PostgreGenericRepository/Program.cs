using _33_PostgreGenericRepository.Entities;
using _33_PostgreGenericRepository.GenericRepositories.Abstract;
using _33_PostgreGenericRepository.GenericRepositories.Concrete;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Npgsql;
using System.Data;
using System.Data.SqlClient;

namespace _33_PostgreGenericRepository
{
    internal class Program
    {
        
        public static string sqlconstr = "server=.;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=true";
        public static string postgreconstr =
            "Server=127.0.0.1;Port=5432;Database=OkulDb;User Id=postgres;Password=z68!t$Fxm9;";
        static void Main(string[] args)
        {
            IDbConnection pgcon = new NpgsqlConnection(postgreconstr);
            #region Contrib paketi string olan Primay Key ile calişmiyor.
            //Customer customer = new Customer()
            //{
            //    customer_id = "ABC LTD",
            //    company_name = "ABc Ltd Sti",
            //    city = "istanbul",
            //    country = "tr"
            //};
            //IManager<Customer> customerManager= new Manager<Customer>(pgcon);
            //customerManager.Insert(customer);
            #endregion

            Region region = new Region()
            {
                region_id = 10,
                region_description = "Kuzey"
            };

            //IManager<Region> manager = new Manager<Region>(pgcon);
            //var id = manager.Insert(region);
            Brans brans = new Brans() { BransAdi = "Kuantum" };

            IManager<Brans> manager = new Manager<Brans>(pgcon);
            var id = manager.Insert(brans);
            Console.WriteLine("Hello, World!");
        }
    }
}
