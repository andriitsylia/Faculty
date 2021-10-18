using Faculty.WEB.Interfaces;
using Faculty.WEB.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faculty.DAL.Repositories;

namespace Faculty.WEB.Controllers
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
            return View(_groupsRepository.GetAll());
        }
    }
}
