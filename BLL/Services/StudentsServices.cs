using Faculty.DAL.Entities;
using Faculty.DAL.Interfaces;
using Faculty.BLL.Interfaces;
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
    public class StudentsServices : IFacultyServices<StudentDTO>
    {
        private readonly IFacultyRepository<Student> _studentsRepository;

        public StudentsServices(IFacultyRepository<Student> studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }

        public IEnumerable<StudentDTO> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentDTO>());
            var mapper = new Mapper(config);
            var studentsDTO = mapper.Map<List<StudentDTO>>(_studentsRepository.Get());
            return studentsDTO;
        }

        public StudentDTO GetById(int studentId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentDTO>());
            var mapper = new Mapper(config);
            var studentDTO = mapper.Map<StudentDTO>(_studentsRepository.GetById(studentId));
            return studentDTO;
        }

        public IEnumerable<StudentDTO> GetByKeyId(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentDTO>());
            var mapper = new Mapper(config);
            var studentsDTO = mapper.Map<List<StudentDTO>>(_studentsRepository.Get(g => g.GroupId == id));
            return studentsDTO;
        }

        public void Save(StudentDTO entity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StudentDTO, Student>());
            var mapper = new Mapper(config);
            var student = mapper.Map<Student>(entity);
            _studentsRepository.Update(student);
        }

        public bool Delete(StudentDTO entity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StudentDTO, Student>());
            var mapper = new Mapper(config);
            var student = mapper.Map<Student>(entity);
            _studentsRepository.Delete(student);
            return true;
        }
    }
}
