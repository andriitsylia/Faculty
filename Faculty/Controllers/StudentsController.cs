using WEB.Interfaces;
using WEB.Models;
using WEB.Repositories;
using WEB.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentsRepository _studentsRepository;

        public StudentsController(StudentsRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }

        public IActionResult Index()
        {
            return View(_studentsRepository.GetStudents());
        }
    }
}
