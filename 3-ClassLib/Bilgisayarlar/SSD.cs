using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Bilgisayarlar
{

    public enum DiskTipi
    {
        HDD=1,
        SSD
    }

    public class HardDisk : BaseItem
    {

        public int Kapasite { get; set; }
        public DiskTipi DiskTipi { get; set; }
    }
}
