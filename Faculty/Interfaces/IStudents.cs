using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faculty.DAL.Entities;

namespace Faculty.WEB.Interfaces
{
    public interface IStudents
    {
        public IEnumerable<Student> Students { get; }
    }
}
