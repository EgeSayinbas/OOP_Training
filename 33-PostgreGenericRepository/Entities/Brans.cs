using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_PostgreGenericRepository.Entities
{
    [Table("brans")]
    public class Brans
    {
        [Key]
        public int Id { get; set; }
        public string BransAdi { get; set; }
    }
}
