using Microsoft.AspNetCore.Mvc;
using Faculty.WEB.ViewModel;
using Faculty.BLL.DTO;
using System.Collections.Generic;
using Faculty.BLL.Interfaces;

namespace Faculty.WEB.Controllers
{
    public class CoursesController : Controller
    {
        private const int AllCourses = 0;
        private readonly IFacultyServices<CourseDTO> _coursesServices;
        private readonly IFacultyServices<GroupDTO> _groupsServices;

        public CoursesController(IFacultyServices<CourseDTO> coursesServices,
                                 IFacultyServices<GroupDTO> groupsServices)
        {
            _coursesServices = coursesServices;
            _groupsServices = groupsServices;
        }

        public IActionResult Index()
        {
            var model = CreateModel(AllCourses);

            return View(model);
        }

        public IActionResult ChooseCourse(int courseId)
        {
            var model = CreateModel(courseId);

            return View(model);
        }

        public FullListViewModel CreateModel(int courseId)
        {
            FullListViewModel model = new();

            if (courseId != 0)
            {
                model.Courses = new List<CourseDTO> { _coursesServices.GetById(courseId) };
                model.Groups = _groupsServices.GetByKeyId(courseId);
            }
            else
            {
                model.Courses = _coursesServices.GetAll();
                model.Groups = _groupsServices.GetAll();
            }

            return model;
        }
    }
}
