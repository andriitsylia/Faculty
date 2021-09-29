using Faculty.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Repositories
{
    public class GroupsRepository
    {
        private readonly AppContext _appContext;

        public GroupsRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IQueryable<Group> GetGroups()
        {
            return _appContext.Groups;
        }

        public IQueryable<Group> GetGroupsByCourseId(int courseId)
        {
            return _appContext.Groups.Where(g => g.CourseId == courseId);
        }

        public Group GetGroupById(int groupId)
        {
            return _appContext.Groups.Single(g => g.GroupId == groupId);
        }

        public int SaveGroup(Group group)
        {
            return 1;
        }

        public void DeleteGroup(Group group)
        {
            if (_appContext.Groups
                .Where(g => g.GroupId == group.GroupId)
                .Include(s => s.Students)
                .Any())
            {
                //do not remove group
            }
            else
            {
                _appContext.Groups.Remove(group);
                _appContext.SaveChanges();
            }
            
        }
    }
}
