using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faculty.DAL.Entities;

namespace Faculty.WEB.Interfaces
{
    public interface IGroups
    {
        public IEnumerable<Student> Groups { get; }
    }
}
