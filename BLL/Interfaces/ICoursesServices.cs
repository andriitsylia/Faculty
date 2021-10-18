using Faculty.DAL.Entities;
using System.Collections.Generic;

namespace Faculty.BLL.Interface
{
    public interface ICoursesServices
    {
        public IEnumerable<Course> GetAll();
        public Course GetById(int courseId);
    }
}