using WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.ViewModel
{
    public class CoursesListViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
