using Faculty.BLL.DTO;
using Faculty.DAL.Entities;
using System.Collections.Generic;

namespace Faculty.BLL.Interface
{
    public interface ICoursesServices
    {
        public IEnumerable<CourseDTO> GetAll();
        public CourseDTO GetById(int courseId);
    }
}