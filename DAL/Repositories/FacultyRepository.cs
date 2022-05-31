using Faculty.DAL.EF;
using Faculty.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//using FacultyContext = Faculty.DAL.EF.FacultyContext;


namespace Faculty.DAL.Repositories
{
    public class FacultyRepository<T> : IDisposable, IFacultyRepository<T> where T : class
    {
        internal readonly FacultyContext _facultyContext;
        internal readonly DbSet<T> dbSet;

        public FacultyRepository(FacultyContext facultyContext)
        {
            _facultyContext = facultyContext;
            dbSet = _facultyContext.Set<T>();
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
            if (_facultyContext.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            Save();
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            _facultyContext.Entry(entity).State = EntityState.Modified;
            Save();
        }

        public void Save()
        {
            _facultyContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _facultyContext.Dispose();
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
