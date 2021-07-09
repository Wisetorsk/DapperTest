using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public System.Linq.IQueryable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public System.Linq.IQueryable<T> FindByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
