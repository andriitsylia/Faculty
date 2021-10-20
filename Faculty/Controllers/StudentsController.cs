using Microsoft.AspNetCore.Mvc;
using Faculty.BLL.Interface;
using Faculty.WEB.ViewModel;
using Faculty.BLL.DTO;
using System.Collections.Generic;

namespace Faculty.WEB.Controllers
{
    public class StudentsController : Controller
    {
        private const int AllStudents = 0;

        private readonly IStudentsServices _studentsServices;
         

        public StudentsController(IStudentsServices studentsServices)
        {
            _studentsServices = studentsServices;
        }

        public IActionResult Index()
        {
            var model = CreateModel(AllStudents);

            return View(model);
        }

        public IActionResult EditStudent(int studentId)
        {
            if (studentId != 0)
            {
                var model = CreateModel(studentId);
                return View(model);
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult SaveStudent(StudentDTO student)
        {
            _studentsServices.Save(student);
            return RedirectToAction("Index", "Home");
        }

        public FullListViewModel CreateModel(int studentId)
        {
            FullListViewModel model = new();

            if (studentId != 0)
            {
                model.Students = new List<StudentDTO> { _studentsServices.GetById(studentId) };
            }
            else
            {
                model.Students = _studentsServices.GetAll();
            }

            return model;
        }
    }
}
