using Faculty.BLL.DTO;
using Faculty.DAL.Entities;
using System.Collections.Generic;

namespace Faculty.BLL.Interface
{
    public interface IGroupsServices
    {
        public IEnumerable<GroupDTO> GetAll();
        public GroupDTO GetById(int groupId); 
        public IEnumerable<GroupDTO> GetByCourseId(int courseId);
        public void Save(GroupDTO entity);
        public bool Delete(GroupDTO entity);
    }
}