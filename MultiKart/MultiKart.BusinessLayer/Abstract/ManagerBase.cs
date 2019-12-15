using MultiKart.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using MultiKart.DataAccessLayer.EntityFramework;

namespace MultiKart.BusinessLayer.Abstract
{
    public abstract class ManagerBase<T> : IDataAccess<T> where T : class
    {
        private Repository<T> repo = new Repository<T>();

        public virtual int Delete(T obj)
        {
            return repo.Delete(obj);
        }

      

        public virtual List<T> List()
        {
            return repo.List();
        }


        public virtual int Save()
        {
            return repo.Save();
        }
        public virtual int Insert(T obj)
        {
            return repo.Insert(obj);
        }
       

    }
}
