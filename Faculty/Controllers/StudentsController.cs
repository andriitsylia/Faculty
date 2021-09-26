using Faculty.Interfaces;
using Faculty.Models;
using Faculty.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IAllStudents _students;

        public StudentsController(IAllStudents students)
        {
            _students = students;
        }

        public ViewResult StudentsList()
        {
            StudentsListViewModel studentsModel = new StudentsListViewModel();
            studentsModel.Students = _students.Students;
            return View(studentsModel);
        }
    }
}
