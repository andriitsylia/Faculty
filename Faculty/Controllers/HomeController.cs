using Faculty.Interfaces;
using Faculty.Models;
using Faculty.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppContext _dbContext;
        public HomeController(AppContext dbContext)
        {
            _dbContext = dbContext;
            if (_dbContext.Courses.Count() == 0)
            {
                IAllCourses allCourses = new PrepareAllCoursesListToInsertToDatabase();
                _dbContext.Courses.AddRange(allCourses.Courses);
                _dbContext.SaveChanges();
            }

            if (_dbContext.Groups.Count() == 0)
            {
                IAllGroups allGroups = new PrepareAllGroupsListToInsertToDatabase();
                _dbContext.Groups.AddRange(allGroups.Groups);
                _dbContext.SaveChanges();
            }

            if (_dbContext.Students.Count() == 0)
            {
                IAllStudents allStudents = new PrepareAllStudentsListToInsertToDatabase();
                _dbContext.Students.AddRange(allStudents.Students);
                _dbContext.SaveChanges();
            }

            
        }

        public IActionResult Index()
        {
            return View();
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
