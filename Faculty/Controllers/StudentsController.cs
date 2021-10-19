using Faculty.WEB.Interfaces;
using Faculty.WEB.Models;
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
    public class StudentsController : Controller
    {
        private readonly IStudentsServices _studentsServices;

        public StudentsController(IStudentsServices studentsServices)
        {
            _studentsServices = studentsServices;
        }

        public IActionResult Index()
        {
            return View(_studentsServices.GetAll());
        }
    }
}
