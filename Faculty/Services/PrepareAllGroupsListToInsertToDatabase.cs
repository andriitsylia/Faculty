using Faculty.Interfaces;
using Faculty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Services
{
    public class PrepareAllGroupsListToInsertToDatabase : IAllGroups
    {
        public IEnumerable<Group> Groups 
        {
            get
            {
                return new List<Group> {
                            new Group { CourseId = 3, Name ="SR-01"},
                            new Group { CourseId = 2, Name ="SR-02"},
                            new Group { CourseId = 1, Name ="SR-03"},
                            new Group { CourseId = 3, Name ="SR-04"},
                            new Group { CourseId = 2, Name ="SR-05"},
                            new Group { CourseId = 1, Name ="SR-06"}};
            }
        }
    }
}