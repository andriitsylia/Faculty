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
using AutoMapper;

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
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentDTO>());
            var mapper = new Mapper(config);
            var studentsDTO = mapper.Map<List<StudentDTO>>(_studentsRepository.GetAll());
            return studentsDTO;

            //List<StudentDTO> students = new();
            //foreach (var student in _studentsRepository.GetAll())
            //{
            //    StudentDTO item = new();
            //    item.StudentId = student.StudentId;
            //    item.FirstName = student.FirstName;
            //    item.LastName = student.LastName;
            //    item.GroupId = student.GroupId;
            //    students.Add(item);
            //}
            //return students;
        }

        public StudentDTO GetById(int studentId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentDTO>());
            var mapper = new Mapper(config);
            var studentDTO = mapper.Map<StudentDTO>(_studentsRepository.GetById(studentId));
            return studentDTO;

            //StudentDTO item = new();
            //Student student = _studentsRepository.GetById(studentId);
            //item.StudentId = student.StudentId;
            //item.FirstName = student.FirstName;
            //item.LastName = student.LastName;
            //item.GroupId = student.GroupId;
            //return item;
        }

        public IEnumerable<StudentDTO> GetByGroupId(int groupId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentDTO>());
            var mapper = new Mapper(config);
            var studentsDTO = mapper.Map<List<StudentDTO>>(_studentsRepository.GetByGroupId(groupId));
            return studentsDTO;
            
            //List<StudentDTO> students = new();
            //foreach (var student in _studentsRepository.GetByGroupId(groupId))
            //{
            //    StudentDTO item = new();
            //    item.StudentId = student.StudentId;
            //    item.FirstName = student.FirstName;
            //    item.LastName = student.LastName;
            //    item.GroupId = student.GroupId;
            //    students.Add(item);
            //}
            //return students;
        }

        public void Save(StudentDTO entity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StudentDTO, Student>());
            var mapper = new Mapper(config);
            var student = mapper.Map<Student>(entity);
            _studentsRepository.Save(student);

            //Student student = new();
            //student.StudentId = entity.StudentId;
            //student.FirstName = entity.FirstName;
            //student.LastName = entity.LastName;
            //student.GroupId = entity.GroupId;
            //_studentsRepository.Save(student);
        }

        public bool Delete(StudentDTO entity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StudentDTO, Student>());
            var mapper = new Mapper(config);
            var student = mapper.Map<Student>(entity);
            return _studentsRepository.Delete(student);

            //Student student = new();
            //student.StudentId = entity.StudentId;
            //student.FirstName = entity.FirstName;
            //student.LastName = entity.LastName;
            //student.GroupId = entity.GroupId;
            //return _studentsRepository.Delete(student);
        }
    }
}
