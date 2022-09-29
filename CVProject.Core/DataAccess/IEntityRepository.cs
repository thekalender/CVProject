using CVProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CVProject.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        T Get(Expression<Func<T,bool>> filter);
        List<T> GetList(Expression<Func<T,bool>> filter = null);
        void Delete(T entity);
        void Update(T entity);
        void Add(T entity);
    }
}
