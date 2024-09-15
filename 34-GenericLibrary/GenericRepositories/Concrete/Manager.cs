using _34_GenericLibrary.GenericRepositories.Abstract;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_GenericLibrary.GenericRepositories.Concrete
{
    public class Manager<T>(IDbConnection db) : IManager<T> where T : class
    {


        public List<T> GetAll()
        {
            return db.GetAll<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Get<T>(id);

        }

        public long Insert(T input)
        {
            return db.Insert<T>(input);
        }

        public bool Update(T input)
        {
            return db.Update<T>(input);
        }
        public bool Delete(T input)
        {
            return db.Delete<T>(input);
        }
    }
}
