using Faculty.DAL.Entities;
using Faculty.DAL.Interfaces;
using Faculty.BLL.Interface;
using Faculty.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty.BLL.Services
{
    public class StudentsServices : IStudentsServices
    {
        private readonly IStudentsRepository _studentsRepository;

        public StudentsServices(IStudentsRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentsRepository.GetAll();
        }

        public Student GetById(int studentId)
        {
            return _studentsRepository.GetById(studentId);
        }

        public IEnumerable<Student> GetByGroupId(int groupId)
        {
            return _studentsRepository.GetByGroupId(groupId);
        }

        public void Save(Student entity)
        {
            _studentsRepository.Save(entity);
        }

        public bool Delete(Student entity)
        {
            return _studentsRepository.Delete(entity);
        }
    }
}
