using _31_GenericInterfaceAndClass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_GenericInterfaceAndClass.Abstract
{
    public interface IShipperManager
    {
        public long Insert(Shipper shipper);
        public bool Update(Shipper shipper);
        public bool Delete(Shipper shipper);
        public Shipper GetById(int id);
        public List<Shipper> GetAll();
    }
}
