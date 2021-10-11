using Faculty.Data.Entities;
using Faculty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Services.Interfaces
{
    public interface IGroups
    {
        public IEnumerable<Group> Groups { get; }
    }
}
