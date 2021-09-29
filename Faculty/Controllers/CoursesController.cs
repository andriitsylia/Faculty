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
    public class CoursesController: Controller
    {
        private readonly CoursesRepository _coursesRepository;

        public CoursesController(CoursesRepository coursesRepositpry)
        {
            _coursesRepository = coursesRepositpry;
        }

        public IActionResult Index()
        {
            return View(_coursesRepository.GetCourses());
        }
    }
}
