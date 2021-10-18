using Faculty.WEB.Interfaces;
using Faculty.WEB.Models;
using Faculty.WEB.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faculty.DAL.Repositories;

namespace Faculty.WEB.Controllers
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
            return View(_studentsRepository.GetAll());
        }
    }
}
