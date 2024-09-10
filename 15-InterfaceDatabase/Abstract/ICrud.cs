using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InterfaceDatabase.Abstract
{
    public interface ICrud
    {
     

        public int Insert(string sql);
        public int Update(string sql);
        public int Delete(string sql);
       
       
    }
}
