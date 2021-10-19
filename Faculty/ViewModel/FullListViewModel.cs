using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faculty.BLL.DTO;
using Faculty.DAL.Entities;

namespace Faculty.WEB.ViewModel
{
    public class FullListViewModel
    {
        public IEnumerable<CourseDTO> Courses { get; set; }
        public IEnumerable<GroupDTO> Groups { get; set; }
        public IEnumerable<StudentDTO> Students { get; set; }

    }
}
