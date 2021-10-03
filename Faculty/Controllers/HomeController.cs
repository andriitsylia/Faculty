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
using Faculty.ViewModel;

namespace Faculty.Controllers
{
    public class HomeController : Controller
    {
        private readonly CoursesRepository _coursesRepository;
        private readonly GroupsRepository _groupsRepository;
        private readonly StudentsRepository _studentsRepository;

        private int _activeCourse = 0;
        private int _activeGroup = 0;
        private int _activeStudent = 0;
        private FullListViewModel _model;
        public HomeController(CoursesRepository coursesRepository, 
                              GroupsRepository groupsRepository,
                              StudentsRepository studentsRepository)
        {
            _coursesRepository = coursesRepository;
            _groupsRepository = groupsRepository;
            _studentsRepository = studentsRepository;
            _model = Create(_activeCourse, _activeGroup, _activeStudent);
        }

        public FullListViewModel Create(int course, int group, int student)
        {
            FullListViewModel model = new();

            if (course != 0)
            {
                model.Courses = new List<Course> { _coursesRepository.GetCourseById(course) };
            }
            else
            {
                model.Courses = _coursesRepository.GetCourses();
            }

            if (group != 0)
            {
                if (course != 0)
                {
                    model.Groups = _groupsRepository.GetGroupsByCourseId(course);
                }
                else
                {
                    model.Groups = new List<Group> { _groupsRepository.GetGroupById(group) };
                }
            }
            else
            {
                if (course != 0)
                {
                    model.Groups = _groupsRepository.GetGroupsByCourseId(course);
                }
                else
                {
                    model.Groups = _groupsRepository.GetGroups();
                }
            }

            if (student != 0)
            {
                if (group != 0)
                {
                    model.Students = _studentsRepository.GetStudentsByGroupId(group);
                }
                else
                {
                    model.Students = new List<Student> { _studentsRepository.GetStudentById(student) };
                }
            }
            else
            {
                if (group != 0)
                {
                    model.Students = _studentsRepository.GetStudentsByGroupId(group);
                }
                else
                {
                    model.Students = _studentsRepository.GetStudents();
                }
            }

            _activeCourse = course;
            _activeGroup = group;
            _activeStudent = student;

            return model;
        }
        public IActionResult Index()
        {
            return View(_model);
        }

        [HttpPost]
        public IActionResult DeleteGroup(int group)
        {
            if (!_groupsRepository.DeleteGroup(new Group() { GroupId = group }))
            {
                ViewBag.DeleteGroup = "The group has students. Can't delete.";
            }
            else
            {
                ViewBag.DeleteGroup = "The group hasn't students. Can delete.";
            }
            return View();
        }

        [HttpPost]
        public IActionResult ChooseCourse(int course)
        {
            _model = Create(course, _activeGroup, _activeStudent);
            return View(_model);
        }

        public IActionResult ChooseGroup(int group)
        {
            _model = Create(_activeCourse, group, _activeStudent);
            return View(_model);
        }

        public IActionResult EditGroup(int group)
        {
            Group model = _groupsRepository.GetGroupById(group);
            return View(model);
        }

        public IActionResult SaveGroup(Group model)
        {
            _groupsRepository.SaveGroup(model);
             return RedirectToAction("Index");
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
