using Faculty.DAL.EF;
using Faculty.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AppContext = Faculty.DAL.EF.AppContext;

namespace Faculty.DAL.Repositories
{
    public class FacultyRepository<T> : IDisposable, IFacultyRepository<T> where T : class
    {
        internal readonly AppContext _appContext;
        internal readonly DbSet<T> dbSet;

        public FacultyRepository(AppContext appContext)
        {
            _appContext = appContext;
            dbSet = _appContext.Set<T>();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
                                  Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                  string includeProperties = "")
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' },
                                                                     StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Insert(T entity)
        {
            dbSet.Add(entity);
            Save();
        }

        public void Delete(int id)
        {
            T entity = dbSet.Find(id);
            Delete(entity);
        }

        public void Delete(T entity)
        {
            if (_appContext.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            Save();
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            _appContext.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            _appContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _appContext.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
