using Faculty.DAL.Entities;
using Faculty.DAL.Interfaces;
using Faculty.BLL.Interface;
using Faculty.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty.BLL.Services
{
    public class GroupsServices : IGroupsServices
    {
        private readonly IGroupsRepository _groupsRepository;

        public GroupsServices(IGroupsRepository groupsRepository)
        {
            _groupsRepository = groupsRepository;
        }

        public IEnumerable<Group> GetAll()
        {
            return _groupsRepository.GetAll();
        }

        public Group GetById(int groupId)
        {
            return _groupsRepository.GetById(groupId);
        }

        public IEnumerable<Group> GetByCourseId(int courseId)
        {
            return _groupsRepository.GetByCourseId(courseId);
        }

        public void Save(Group entity)
        {
            _groupsRepository.Save(entity);
        }

        public bool Delete(Group entity)
        {
            return _groupsRepository.Delete(entity);
        }
    }
}
