using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ClassLib.Menuler
{
    public class Menu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int OrderNo { get; set; }
        public string Url { get; set; }

        public int UStMenuID { get; set; }
        public Menu UstMenu { get; set; }
    }
}
