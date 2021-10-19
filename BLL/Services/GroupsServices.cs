using Faculty.DAL.Entities;
using Faculty.DAL.Interfaces;
using Faculty.BLL.Interface;
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
    public class GroupsServices : IGroupsServices
    {
        private readonly IGroupsRepository _groupsRepository;

        public GroupsServices(IGroupsRepository groupsRepository)
        {
            _groupsRepository = groupsRepository;
        }

        public IEnumerable<GroupDTO> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var groupsDTO = mapper.Map<List<GroupDTO>>(_groupsRepository.GetAll());
            return groupsDTO;

            //List<GroupDTO> groups = new();
            //foreach (var group in _groupsRepository.GetAll())
            //{
            //    GroupDTO item = new();
            //    item.GroupId = group.GroupId;
            //    item.Name = group.Name;
            //    item.CourseId = group.CourseId;
            //    groups.Add(item);
            //}
            //return groups;
        }

        public GroupDTO GetById(int groupId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var groupDTO = mapper.Map<GroupDTO>(_groupsRepository.GetById(groupId));
            return groupDTO;

            //GroupDTO item = new();
            //Group group = _groupsRepository.GetById(groupId);
            //item.GroupId = group.GroupId;
            //item.Name = group.Name;
            //item.CourseId = group.CourseId;
            //return item;
        }

        public IEnumerable<GroupDTO> GetByCourseId(int courseId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var groupsDTO = mapper.Map<List<GroupDTO>>(_groupsRepository.GetByCourseId(courseId));
            return groupsDTO;

            //List<GroupDTO> groups = new();
            //foreach (var group in _groupsRepository.GetByCourseId(courseId))
            //{
            //    GroupDTO item = new();
            //    item.GroupId = group.GroupId;
            //    item.Name = group.Name;
            //    item.CourseId = group.CourseId;
            //    groups.Add(item);
            //}
            //return groups;
        }

        public void Save(GroupDTO entity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<GroupDTO, Group>());
            var mapper = new Mapper(config);
            var group = mapper.Map<Group>(entity);
            _groupsRepository.Save(group);

            //Group group = new();
            //group.GroupId = entity.GroupId;
            //group.Name = entity.Name;
            //group.CourseId = entity.CourseId;
            //_groupsRepository.Save(group);
        }

        public bool Delete(GroupDTO entity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<GroupDTO, Group>());
            var mapper = new Mapper(config);
            var group = mapper.Map<Group>(entity);
            return _groupsRepository.Delete(group);

            //Group group = new();
            //group.GroupId = entity.GroupId;
            //group.Name = entity.Name;
            //group.CourseId = entity.CourseId;
            //return _groupsRepository.Delete(group);
        }
    }
}
