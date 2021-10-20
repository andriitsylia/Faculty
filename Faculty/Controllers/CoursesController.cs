using Microsoft.AspNetCore.Mvc;
using Faculty.BLL.Interface;
using Faculty.WEB.ViewModel;
using Faculty.BLL.DTO;
using System.Collections.Generic;

namespace Faculty.WEB.Controllers
{
    public class CoursesController : Controller
    {
        private const int AllCourses = 0;
        private readonly ICoursesServices _coursesServices;
        private readonly IGroupsServices _groupsServices;

        public CoursesController(ICoursesServices coursesServices,
                                 IGroupsServices groupsServices)
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
                model.Groups = _groupsServices.GetByCourseId(courseId);
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
