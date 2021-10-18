using Faculty.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty.DAL.Interfaces
{
    public interface IGroupsRepository
    {
        public IEnumerable<Group> GetAll();
        public Group GetById(int id);
        public IEnumerable<Group> GetByCourseId(int id);
        public void Save(Group entity);
        public bool Delete(Group entity);

    }
}
