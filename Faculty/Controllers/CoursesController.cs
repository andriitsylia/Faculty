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
    public class CoursesController: Controller
    {
        private readonly CoursesRepository _coursesRepository;

        public CoursesController(CoursesRepository coursesRepository)
        {
            _coursesRepository = coursesRepository;
        }

        public IActionResult Index()
        {
            return View(_coursesRepository.GetCourses());
        }
    }
}
