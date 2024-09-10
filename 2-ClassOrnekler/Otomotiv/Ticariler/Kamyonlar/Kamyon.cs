using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassOrnekler.Otomotiv.Ticariler.Kamyonlar
{
    public class Kamyon
    {
        

        public string Marka { get; set; }
        public string Model { get; set; }
        public YakitTipi Yakit { get; set; }
        public UstYapi UstYapi { get; set; }
    }
}
