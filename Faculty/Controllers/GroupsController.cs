using Faculty.Interfaces;
using Faculty.Repositories;
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
        private readonly GroupsRepository _groupsRepository;

        public GroupsController(GroupsRepository groupsRepository)
        {
            _groupsRepository = groupsRepository;
        }

        public IActionResult Index()
        {
            return View(_groupsRepository.GetGroups());
        }
    }
}
