using System.Collections.Generic;

namespace Faculty.BLL.Interfaces
{
    public interface IFacultyServices<T> where T : class
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public IEnumerable<T> GetByKeyId(int id);
        public void Save(T entity);
        public bool Delete(T entity);
    }
}
