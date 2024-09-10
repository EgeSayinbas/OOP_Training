using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{
    public enum EkranKartiTipi
    {
        NVIDIA,
        AMD
    }

    public class EkranKarti:BaseItem
    {
        public  short Hafiza { get; set; }
        public EkranKartiTipi KartTipi { get; set; }
    }
}
