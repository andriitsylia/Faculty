using Faculty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Repositories
{
    public class CoursesRepository
    {
        private readonly AppContext _appContext;

        public CoursesRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IQueryable<Course> GetCourses()
        {
            return _appContext.Courses;
        }

        public Course GetCourseById(int courseId)
        {
            return _appContext.Courses.Single(c => c.CourseId == courseId);
        }
    }
}
