using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_GenericInterfaceAndClass.Entities
{
    /*
     * Genelde <> arasina T yazilir.Sebebi type kelimesinin bas harfidir ancak istenilen bir isim verilebilir.
     * Burada Type ile belirtilen tipini kisitlamalari yapilabilir bu da where ifadesi ile olur
     * asagıdaki ornekte her hangi bir kisitlama yoktur
     * 
     * where sarti ile T struct ya da class olabilir
     */
    abstract class BaseEntity<T> // where T : class // class string-- struct int
    {
        public T Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }

        //Protected abstract classin Kalitim verdigi yerlerden cagirilabilir

        protected BaseEntity()
        {
            CreateDate = DateTime.Now;
        }
    }
}
