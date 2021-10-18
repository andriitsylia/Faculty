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
    public class CoursesServices : ICoursesServices
    {
        private readonly ICoursesRepository _coursesRepository;

        public CoursesServices(ICoursesRepository coursesRepository)
        {
            _coursesRepository = coursesRepository;
        }

        public IEnumerable<Course> GetAll()
        {
            return _coursesRepository.GetAll();
        }

        public Course GetById(int courseId)
        {
            return _coursesRepository.GetById(courseId);
        }
    }
}
