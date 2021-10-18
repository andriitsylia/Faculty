using Faculty.DAL.Entities;
using System.Collections.Generic;

namespace Faculty.BLL.Interface
{
    public interface IGroupsServices
    {
        public IEnumerable<Group> GetAll();
        public Group GetById(int groupId); 
        public IEnumerable<Group> GetByCourseId(int courseId);
        public void Save(Group entity);
        public bool Delete(Group entity);
    }
}