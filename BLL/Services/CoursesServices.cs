using Faculty.DAL.Entities;
using Faculty.DAL.Interfaces;
using System;
using System.Collections.Generic;
using Faculty.BLL.DTO;
using AutoMapper;
using Faculty.BLL.Interfaces;

namespace Faculty.BLL.Services
{
    public class CoursesServices : IFacultyServices<CourseDTO>
    {
        private readonly IFacultyRepository<Course> _coursesRepository;

        public CoursesServices(IFacultyRepository<Course> coursesRepository)
        {
            _coursesRepository = coursesRepository;
        }

        public IEnumerable<CourseDTO> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Course, CourseDTO>());
            var mapper = new Mapper(config);
            var coursesDTO = mapper.Map<List<CourseDTO>>(_coursesRepository.Get());
            return coursesDTO;
        }

        public CourseDTO GetById(int courseId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Course, CourseDTO>());
            var mapper = new Mapper(config);
            var courseDTO = mapper.Map<CourseDTO>(_coursesRepository.GetById(courseId));
            return courseDTO;
        }

        public void Save(CourseDTO entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<CourseDTO> IFacultyServices<CourseDTO>.GetByKeyId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(CourseDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
