using WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.ViewModel
{
    public class StudentsListViewModel
    {
        public IEnumerable<Student> Students { get; set; }
    }
}
