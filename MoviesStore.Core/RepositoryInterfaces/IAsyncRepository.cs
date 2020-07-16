using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MoviesStore.Core.RepositoryInterfaces
{
    //by default Interface is public, and cannot use access modifer
    interface IAsyncRepository<T> where T:class
    {
        //base interface with all our CRUD operations
        T GetById(int id);
        IEnumerable<T> ListAll();
        IEnumerable<T> ListWhere(Expression<Func<T, bool>> filter);
        int GetCount(Expression<Func<T, bool>> filter = null);
        bool GetExists(Expression<Func<T, bool>> filter = null);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
