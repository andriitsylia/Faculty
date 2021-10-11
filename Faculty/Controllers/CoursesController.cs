using Faculty.Services.Interfaces;
using Faculty.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faculty.Services.Repositories;

namespace Faculty.Controllers
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
