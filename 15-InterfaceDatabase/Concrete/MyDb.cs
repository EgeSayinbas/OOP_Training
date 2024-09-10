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
    public class MyDb(IDbConnection dbConnection) : ICrud
    {

        
        public int Delete(string sql)
        {
           return  dbConnection.Execute(sql);
        }

        public int DeleteAll()
        {
            return 1;
        }

        public int Insert(string sql)
        {
            return dbConnection.Execute(sql);
        }

        public int Update(string sql)
        {
            return dbConnection.Execute(sql);
        }
    }
}
