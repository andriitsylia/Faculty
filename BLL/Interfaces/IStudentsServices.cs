using Faculty.DAL.Entities;
using System.Collections.Generic;

namespace Faculty.BLL.Interface
{
    public interface IStudentsServices
    {
        IEnumerable<Student> GetAll();
        Student GetById(int studentId);
        IEnumerable<Student> GetByGroupId(int groupId);
        void Save(Student entity);
        bool Delete(Student entity);
    }
}