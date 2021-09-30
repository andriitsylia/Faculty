using Faculty.Interfaces;
using Faculty.Models;
using Faculty.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Faculty.Repositories;

namespace Faculty.Controllers
{
    public class HomeController : Controller
    {
        //private readonly AppContext _dbContext;
        private readonly CoursesRepository _courseRepository;
        public HomeController(CoursesRepository courseRepository)
        {
            _courseRepository = courseRepository;
            //_dbContext = dbContext;
            //if (!_dbContext.Courses.Any())
            //{
            //    IAllCourses allCourses = new CourseConfiguration();
            //    _dbContext.Courses.AddRange(allCourses.Courses);
            //}

            //if (!_dbContext.Groups.Any())
            //{
            //    IAllGroups allGroups = new GroupConfiguration();
            //    _dbContext.Groups.AddRange(allGroups.Groups);
            //}

            //if (!_dbContext.Students.Any())
            //{
            //    IAllStudents allStudents = new StudentConfiguration();
            //    _dbContext.Students.AddRange(allStudents.Students);
            //}

            //_dbContext.SaveChanges();
        }

        public IActionResult Index()
        {
            var model = _courseRepository.GetCourses();
            return View(model);
        }

        [HttpPost]
        public IActionResult ChooseCourse(int courseId)
        {
            if (courseId != 0)
            {
                var model = new List<Course> { _courseRepository.GetCourseById(courseId) };
                return View(model);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
