using Faculty.DAL.Entities;
using Faculty.DAL.EF;
using Faculty.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.DAL.Repositories
{
    public class StudentsRepository :IStudentsRepository
    {
        private readonly AppContext _appContext;

        public StudentsRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<Student> GetAll()
        {
            return _appContext.Students;
        }

        public Student GetById(int id)
        {
            return _appContext.Students.Single(s => s.StudentId == id);
        }

        public IEnumerable<Student> GetByGroupId(int id)
        {
            return _appContext.Students.Where(s => s.GroupId == id);
        }

        public void Save(Student entity)
        {
            _appContext.Entry(entity).State = EntityState.Modified;
            _appContext.SaveChanges();
        }

        public bool Delete(Student entity)
        {
            _appContext.Students.Remove(entity);
            _appContext.SaveChanges();
            return true;
        }
    }
}
