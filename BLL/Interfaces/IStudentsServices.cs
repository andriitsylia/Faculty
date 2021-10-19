using Faculty.BLL.DTO;
using Faculty.DAL.Entities;
using System.Collections.Generic;

namespace Faculty.BLL.Interface
{
    public interface IStudentsServices
    {
        public IEnumerable<StudentDTO> GetAll();
        public StudentDTO GetById(int studentId);
        public IEnumerable<StudentDTO> GetByGroupId(int groupId);
        public void Save(StudentDTO entity);
        public bool Delete(StudentDTO entity);
    }
}