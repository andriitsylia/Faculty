using Faculty.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty.DAL.Interfaces
{
    public interface ICoursesRepository
    {
        public IEnumerable<Course> GetAll();
        public Course GetById(int id);
        public void Save(Course entity);
        public bool Delete(Course entity);

    }
}
