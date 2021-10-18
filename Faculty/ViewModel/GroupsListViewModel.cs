using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faculty.DAL.Entities;

namespace Faculty.WEB.ViewModel
{
    public class GroupsListViewModel
    {
        public IEnumerable<Student> Groups { get; set; }
    }
}
