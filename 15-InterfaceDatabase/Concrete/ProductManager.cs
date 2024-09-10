using _15_InterfaceDatabase.Abstract;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InterfaceDatabase.Concrete
{
    internal class ProductManager(IDbConnection db) : IManager<Product>
    {
        private string SelectSql = "select * from products ";
        private string SelectWhereSql = "select * from products where ";
        private string InsertSql = "insert into products (ProductName,UnitsInStock,UnitPrice,Discontinued) ";
        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }
        public int Insert(Product product)
        {
            string sql = InsertSql + " OUTPUT inserted.ProductId Values(@ProductName,@UnitsInStock,@UnitPrice,@Discontinued) ";
        return    db.Execute(sql, new { ProductName = product.ProductName, UnitsInStock = product.UnitsInStock, UnitPrice = product.UnitPrice, Discontinued=true });
             
        }
        public Product? GetById(int id)
        {

            string sql = SelectWhereSql + " productid=@id";
            return db.Query<Product>(sql, new { id = 1 }).FirstOrDefault();
        }
    }
}
