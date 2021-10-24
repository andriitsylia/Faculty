using Faculty.DAL.Entities;
using Faculty.DAL.Interfaces;
using Faculty.BLL.Interfaces;
using Faculty.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faculty.BLL.DTO;
using AutoMapper;

namespace Faculty.BLL.Services
{
    public class GroupsServices : IFacultyServices<GroupDTO>
    {
        private readonly IFacultyRepository<Group> _groupsRepository;

        public GroupsServices(IFacultyRepository<Group> groupsRepository)
        {
            _groupsRepository = groupsRepository;
        }

        public IEnumerable<GroupDTO> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var groupsDTO = mapper.Map<List<GroupDTO>>(_groupsRepository.Get());
            return groupsDTO;
        }

        public GroupDTO GetById(int groupId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var groupDTO = mapper.Map<GroupDTO>(_groupsRepository.GetById(groupId));
            return groupDTO;
        }

        public IEnumerable<GroupDTO> GetByKeyId(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var groupsDTO = mapper.Map<List<GroupDTO>>(_groupsRepository.Get(filter: c => c.CourseId == id));
            return groupsDTO;
        }

        public void Save(GroupDTO entity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<GroupDTO, Group>());
            var mapper = new Mapper(config);
            var group = mapper.Map<Group>(entity);
            _groupsRepository.Update(group);
        }

        public bool Delete(GroupDTO entity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<GroupDTO, Group>());
            var mapper = new Mapper(config);
            var group = mapper.Map<Group>(entity);
            _groupsRepository.Delete(group);
            return true;
        }
    }
}
