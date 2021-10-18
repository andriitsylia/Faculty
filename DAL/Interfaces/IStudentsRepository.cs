using Faculty.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty.DAL.Interfaces
{
    public interface IStudentsRepository
    {
        public IEnumerable<Student> GetAll();
        public Student GetById(int id);
        public IEnumerable<Student> GetByGroupId(int id);
        public void Save(Student entity);
        public bool Delete(Student entity);
    }
}
