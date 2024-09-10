using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_SingletonPattern
{
    internal class SqlBaglanti
    {
        private static SqlConnection sqlConnection;
        
        private SqlBaglanti()
        {
            
        }
        public static SqlConnection GetConnection()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection();

            }

            return sqlConnection;
        }
    }
}
