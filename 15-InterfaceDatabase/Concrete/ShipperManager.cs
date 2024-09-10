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
    public class ShipperManager(IDbConnection db)
    {

        public Shipper GetById(int shipperId)
        {
           return  db.Query<Shipper>("Select * from Shippers where ShipperID=" + shipperId).FirstOrDefault();
        }

        public IEnumerable<Shipper> GetAll()
        {
            return db.Query<Shipper>("Select * from Shippers");

        }
      
    }
}
