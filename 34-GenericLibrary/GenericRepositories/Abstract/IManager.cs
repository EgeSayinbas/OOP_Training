using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_GenericLibrary.GenericRepositories.Abstract
{
    public interface IManager<T> where T : class
    {
        public long Insert(T input);
        public bool Update(T input);
        public bool Delete(T input);
        public T GetById(int id);
        public List<T> GetAll();
    }
}
