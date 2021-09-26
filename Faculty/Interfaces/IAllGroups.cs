using Faculty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Interfaces
{
    public interface IAllGroups
    {
        public IEnumerable<Group> Groups { get; }
    }
}
