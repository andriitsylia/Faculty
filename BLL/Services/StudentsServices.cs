using Faculty.DAL.Entities;
using Faculty.DAL.Interfaces;
using Faculty.BLL.Interface;
using Faculty.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faculty.BLL.DTO;

namespace Faculty.BLL.Services
{
    public class StudentsServices : IStudentsServices
    {
        private readonly IStudentsRepository _studentsRepository;

        public StudentsServices(IStudentsRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }

        public IEnumerable<StudentDTO> GetAll()
        {
            List<StudentDTO> students = new();
            foreach (var student in _studentsRepository.GetAll())
            {
                StudentDTO item = new();
                item.StudentId = student.StudentId;
                item.FirstName = student.FirstName;
                item.LastName = student.LastName;
                item.GroupId = student.GroupId;
                students.Add(item);
            }
            return students;
        }

        public StudentDTO GetById(int studentId)
        {
            StudentDTO item = new();
            Student student = _studentsRepository.GetById(studentId);
            item.StudentId = student.StudentId;
            item.FirstName = student.FirstName;
            item.LastName = student.LastName;
            item.GroupId = student.GroupId;
            return item;
        }

        public IEnumerable<StudentDTO> GetByGroupId(int groupId)
        {
            List<StudentDTO> students = new();
            foreach (var student in _studentsRepository.GetByGroupId(groupId))
            {
                StudentDTO item = new();
                item.StudentId = student.StudentId;
                item.FirstName = student.FirstName;
                item.LastName = student.LastName;
                item.GroupId = student.GroupId;
                students.Add(item);
            }
            return students;
        }

        public void Save(StudentDTO entity)
        {
            Student student = new();
            student.StudentId = entity.StudentId;
            student.FirstName = entity.FirstName;
            student.LastName = entity.LastName;
            student.GroupId = entity.GroupId;
            _studentsRepository.Save(student);
        }

        public bool Delete(StudentDTO entity)
        {
            Student student = new();
            student.StudentId = entity.StudentId;
            student.FirstName = entity.FirstName;
            student.LastName = entity.LastName;
            student.GroupId = entity.GroupId;
            return _studentsRepository.Delete(student);
        }
    }
}
