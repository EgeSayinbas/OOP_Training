using _31_GenericInterfaceAndClass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_GenericInterfaceAndClass.Abstract
{
    public interface ICustomerManager
    {
        public int Insert(Customer shipper);

        public int Update(Customer shipper);
        public int Delete(Customer shipper);
        public Customer GetById(int id);
        public List<Customer> GetAll();
    }
}
