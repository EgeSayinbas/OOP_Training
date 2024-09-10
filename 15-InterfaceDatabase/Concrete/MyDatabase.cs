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
    public class MyDatabase(IDbConnection connection) : IDatabase
    {
        public int ExecuteNonQuery(string sql)
        {
            return connection.Execute(sql);

        }

        public IDataReader ExecuteQuery(string sql)
        {
           return connection.ExecuteReader(sql);
        }
    }
}
