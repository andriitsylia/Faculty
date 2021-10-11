using Faculty.Data;
using Faculty.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Services.Repositories
{
    public class CoursesRepository
    {
        private readonly Data.AppContext _appContext;

        public CoursesRepository(Data.AppContext appContext)
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
