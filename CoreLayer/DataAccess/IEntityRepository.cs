using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CoreLayer.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new() /*generic constrints IEntity new lenebilir*/
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null); /*Listeleme*/
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
