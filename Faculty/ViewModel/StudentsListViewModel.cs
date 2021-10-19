using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faculty.BLL.DTO;
using Faculty.DAL.Entities;

namespace Faculty.WEB.ViewModel
{
    public class StudentsListViewModel
    {
        public IEnumerable<StudentDTO> Students { get; set; }
    }
}
