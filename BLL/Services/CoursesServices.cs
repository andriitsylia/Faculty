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
    public class CoursesServices : ICoursesServices
    {
        private readonly ICoursesRepository _coursesRepository;

        public CoursesServices(ICoursesRepository coursesRepository)
        {
            _coursesRepository = coursesRepository;
        }

        public IEnumerable<CourseDTO> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Course, CourseDTO>());
            var mapper = new Mapper(config);
            var coursesDTO = mapper.Map<List<CourseDTO>>(_coursesRepository.GetAll());
            return coursesDTO;

            //List<CourseDTO> courses = new();
            //foreach (var course in _coursesRepository.GetAll())
            //{
            //    CourseDTO item = new();
            //    item.CourseId = course.CourseId;
            //    item.Name = course.Name;
            //    item.Description = course.Description;
            //    courses.Add(item);
            //}
            //return courses;
        }

        public CourseDTO GetById(int courseId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Course, CourseDTO>());
            var mapper = new Mapper(config);
            var courseDTO = mapper.Map<CourseDTO>(_coursesRepository.GetById(courseId));
            return courseDTO;

            //CourseDTO item = new();
            //Course course = _coursesRepository.GetById(courseId);
            //item.CourseId = course.CourseId;
            //item.Name = course.Name;
            //item.Description = course.Description;
            //return item;
        }
    }
}
