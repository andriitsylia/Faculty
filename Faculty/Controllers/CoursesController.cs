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
    public class CoursesController: Controller
    {
        private readonly ICoursesServices _coursesServices;

        public CoursesController(ICoursesServices coursesServices)
        {
            _coursesServices = coursesServices;
        }

        public IActionResult Index()
        {
            return View(_coursesServices.GetAll());
        }
    }
}
