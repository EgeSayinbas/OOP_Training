using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InterfaceDatabase.Abstract
{
    // Generic yapilar daki T Type kelimesinin Baş harfidir
    //Generic yapilar bu sayaede hangi tiple calisacagini bilir.
    // Yani gelen tipe gore tavir takinir.
    internal interface IManager<T> where T : class
    {
        public T GetById(int id);
        public IEnumerable<T> GetAll();
    }
}
