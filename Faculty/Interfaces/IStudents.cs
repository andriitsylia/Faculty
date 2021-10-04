using Faculty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Interfaces
{
    public interface IStudents
    {
        public IEnumerable<Student> Students { get; }
    }
}
