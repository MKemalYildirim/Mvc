using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MultiKart.Core.DataAccess
{
        public interface IDataAccess<T>
        {
            List<T> List();          
               
            int Delete(T obj);
            int Save();

            int Insert(T obj);
    }
    }


