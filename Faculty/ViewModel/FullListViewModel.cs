using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faculty.DAL.Entities;

namespace Faculty.WEB.ViewModel
{
    public class FullListViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<Student> Students { get; set; }

    }
}
