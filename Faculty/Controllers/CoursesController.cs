using Faculty.Interfaces;
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

        private readonly IAllCourses _courses;

        public CoursesController(IAllCourses courses)
        {
            _courses = courses;
        }

        public ViewResult CoursesList()
        {
            CoursesListViewModel coursesList = new CoursesListViewModel();
            coursesList.Courses = _courses.Courses;
            return View(coursesList);
        }
    }
}
