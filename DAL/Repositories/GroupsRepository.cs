using Faculty.DAL.Entities;
using Faculty.DAL.EF;
using Faculty.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.DAL.Repositories
{
    public class GroupsRepository : IGroupsRepository
    {
        private readonly AppContext _appContext;

        public GroupsRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<Group> GetAll()
        {
            return _appContext.Groups;
        }

        public Group GetById(int id)
        {
            return _appContext.Groups.Single(g => g.GroupId == id);
        }

        public IEnumerable<Group> GetByCourseId(int id)
        {
            return _appContext.Groups.Where(g => g.CourseId == id);
        }

        public void Save(Group entity)
        {
            _appContext.Entry(entity).State = EntityState.Modified;
            _appContext.SaveChanges();
        }

        public bool Delete(Group entity)
        {
            if (!_appContext.Groups
                .Where(g => g.GroupId == entity.GroupId)
                .Include(s => s.Students)
                .Any())
            {
                //the group hasn't students, delete
                //_appContext.Groups.Remove(group);
                //_appContext.SaveChanges();
                return true;
            }
            //the group has students, do not delete
            return false;
        }
    }
}
