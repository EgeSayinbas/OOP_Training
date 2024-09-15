using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_PostgreGenericRepository.Entities
{
    public class Shipper
    {
        [Key]
        public int shipper_id { get; set; }
        public string company_name { get; set; }
        public string? phone { get; set; }
    }
}
