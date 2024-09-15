using _31_GenericInterfaceAndClass.Abstract;
using _31_GenericInterfaceAndClass.Entities;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_GenericInterfaceAndClass.Concrete
{
    public class ShipperManager : IShipperManager
    {
        private readonly IDbConnection connection;
        #region IDbConnection Kullanmadan yapilirsa olusacak constructer problemi
        //private readonly SqlConnection connection;

        //public ShipperManager(SqlConnection connection)
        //{
        //    this.connection = connection;
        //}
        //public ShipperManager(NpgsqlConnection connection)
        //{
        //    this.connection = connection;
        //} 
        #endregion

        public ShipperManager(IDbConnection connection)
        {
            this.connection = connection;
        }
        public Shipper GetById(int id)
        {
            return connection.Get<Shipper>(id);
        }

        public List<Shipper> GetAll()
        {
            return connection.GetAll<Shipper>().ToList();
        }



        public long Insert(Shipper shipper)
        {
            return connection.Insert<Shipper>(shipper);
        }

        public bool Update(Shipper shipper)
        {
            return connection.Update<Shipper>(shipper);
        }
        public bool Delete(Shipper shipper)
        {
            return connection.Delete<Shipper>(shipper);
        }
    }
}
