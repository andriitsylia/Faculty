using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Faculty.DAL.Interfaces
{
    public interface IFacultyRepository<T> where T : class
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
                   Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                   string includeProperties = "");
        T GetById(int id);
        void Insert(T entity);
        void Save();
        void Update(T entity);
        void Delete(int id);
        void Delete(T entity);
        void Dispose();
    }
}