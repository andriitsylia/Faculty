using Faculty.WEB.Interfaces;
using Faculty.WEB.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faculty.DAL.Repositories;
using Faculty.BLL.Interface;

namespace Faculty.WEB.Controllers
{
    public class GroupsController : Controller
    {
        private readonly IGroupsServices _groupsServices;

        public GroupsController(IGroupsServices groupsServices)
        {
            _groupsServices = groupsServices;
        }

        public IActionResult Index()
        {
            return View(_groupsServices.GetAll());
        }
    }
}
