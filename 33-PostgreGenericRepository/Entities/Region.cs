using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_PostgreGenericRepository.Entities
{
    [Table("Regions")]
    public class Region
    {
        [Key]
        public int region_id { get; set; }
        public string? region_description { get; set; }
    }
}
