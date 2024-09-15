using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_PostgreGenericRepository.Entities
{
    public class Customer
    {
        [Key]
        public string customer_id { get; set; }
        public string company_name { get; set; }
        public string? contact_tittle { get; set; }
        public string? contact_name { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? region { get; set; }
        public string? postal_code { get; set; }
        public string? country { get; set; }
        public string? phone { get; set; }
        public string? fax { get; set; }
    }
}
