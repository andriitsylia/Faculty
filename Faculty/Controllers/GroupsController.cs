using Faculty.Interfaces;
using Faculty.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Controllers
{
    public class GroupsController : Controller
    {
        private readonly IAllGroups _groups;

        public GroupsController(IAllGroups groups)
        {
            _groups = groups;
        }

        public ViewResult GroupsList()
        {
            GroupsListViewModel groupsList = new GroupsListViewModel();
            groupsList.Groups = _groups.Groups;
            return View(groupsList);
        }
    }
}
