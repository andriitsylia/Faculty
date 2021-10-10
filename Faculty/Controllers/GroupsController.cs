using WEB.Interfaces;
using WEB.Repositories;
using WEB.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Controllers
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
