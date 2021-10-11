using Faculty.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Models
{
    public class CoursesListViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
