using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InterfaceDatabase.Abstract
{
    public interface IDatabase
    {

        public int ExecuteNonQuery(string sql);
        public IDataReader ExecuteQuery(string sql);
    }
}
