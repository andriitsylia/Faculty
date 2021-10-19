using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Faculty.WEB.ViewModel;
using Faculty.DAL.Repositories;
using Faculty.DAL.Entities;
using Faculty.BLL.Services;
using Faculty.BLL.Interface;
using Faculty.BLL.DTO;

namespace Faculty.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoursesServices _coursesServices;
        private readonly IGroupsServices _groupsServices;
        private readonly IStudentsServices _studentsServices;

        private int _activeCourse = 0;
        private int _activeGroup = 0;
        private int _activeStudent = 0;
        private FullListViewModel _model;
        public HomeController(ICoursesServices coursesService,
                              IGroupsServices groupsServices,
                              IStudentsServices studentsServices)
        {
            _coursesServices = coursesService;
            _groupsServices = groupsServices;
            _studentsServices = studentsServices;
            _model = CreateModel(_activeCourse, _activeGroup, _activeStudent);
        }

        public IActionResult Index()
        {
            return View(_model);
        }

        public IActionResult ChooseCourse(int courseId)
        {
            _model = CreateModel(courseId, _activeGroup, _activeStudent);
            return View(_model);
        }

        public IActionResult ChooseGroup(int groupId)
        {
            _model = CreateModel(_activeCourse, groupId, _activeStudent);
            return View(_model);
        }

        public IActionResult EditGroup(int groupId)
        {
            if (groupId != 0)
            {
                GroupDTO model = _groupsServices.GetById(groupId);
                return View(model);
            }
            return RedirectToAction("Index");
        }

        public IActionResult SaveGroup(GroupDTO model)
        {
            _groupsServices.Save(model);
             return RedirectToAction("Index");
        }

        public IActionResult DeleteGroup(int groupId)
        {
            if (!_groupsServices.Delete(new GroupDTO() { GroupId = groupId }))
            {
                ViewBag.DeleteGroup = "There are students in this group. I can't delete this group.";
            }
            else
            {
                ViewBag.DeleteGroup = "There are no students in this group. I can delete this group.";
            }
            return View();
        }

        public IActionResult EditStudent(int studentId)
        {
            if (studentId != 0)
            {
                StudentDTO model = _studentsServices.GetById(studentId);
                return View(model);
            }
            return RedirectToAction("Index");
        }

        public IActionResult SaveStudent(StudentDTO student)
        {
            _studentsServices.Save(student);
            return RedirectToAction("Index");
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        public FullListViewModel CreateModel(int course, int group, int student)
        {
            FullListViewModel model = new();

            if (course != 0)
            {
                model.Courses = new List<CourseDTO> { _coursesServices.GetById(course) };
            }
            else
            {
                model.Courses = _coursesServices.GetAll();
            }

            if (group != 0)
            {
                if (course != 0)
                {
                    model.Groups = _groupsServices.GetByCourseId(course);
                }
                else
                {
                    model.Groups = new List<GroupDTO> { _groupsServices.GetById(group) };
                }
            }
            else
            {
                if (course != 0)
                {
                    model.Groups = _groupsServices.GetByCourseId(course);
                }
                else
                {
                    model.Groups = _groupsServices.GetAll();
                }
            }

            if (student != 0)
            {
                if (group != 0)
                {
                    model.Students = _studentsServices.GetByGroupId(group);
                }
                else
                {
                    model.Students = new List<StudentDTO> { _studentsServices.GetById(student) };
                }
            }
            else
            {
                if (group != 0)
                {
                    model.Students = _studentsServices.GetByGroupId(group);
                }
                else
                {
                    model.Students = _studentsServices.GetAll();
                }
            }

            _activeCourse = course;
            _activeGroup = group;
            _activeStudent = student;

            return model;
        }
    }
}
