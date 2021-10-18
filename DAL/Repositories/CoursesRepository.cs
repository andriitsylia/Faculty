using Faculty.DAL.Entities;
using Faculty.DAL.Interfaces;
using Faculty.DAL.EF;
using System.Collections.Generic;
using System.Linq;

namespace Faculty.DAL.Repositories
{
    public class CoursesRepository : ICoursesRepository
    {
        private readonly AppContext _appContext;

        public CoursesRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<Course> GetAll()
        {
            return _appContext.Courses;
        }

        public Course GetById(int id)
        {
            return _appContext.Courses.Single(c => c.CourseId == id);
        }

        public void Save(Course entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Course entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
