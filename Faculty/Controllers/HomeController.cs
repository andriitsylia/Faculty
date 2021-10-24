using Faculty.BLL.DTO;
using Faculty.BLL.Interfaces;
using Faculty.WEB.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Faculty.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFacultyServices<CourseDTO> _coursesServices;
        private readonly IFacultyServices<GroupDTO> _groupsServices;
        private readonly IFacultyServices<StudentDTO> _studentsServices;

        public HomeController(IFacultyServices<CourseDTO> coursesService,
                              IFacultyServices<GroupDTO> groupsServices,
                              IFacultyServices<StudentDTO> studentsServices)
        {
            _coursesServices = coursesService;
            _groupsServices = groupsServices;
            _studentsServices = studentsServices;

        }

        public IActionResult Index()
        {
            var model = CreateModel();
            return View(model);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        public FullListViewModel CreateModel()
        {
            FullListViewModel model = new();

            model.Courses = _coursesServices.GetAll();
            model.Groups = _groupsServices.GetAll();
            model.Students = _studentsServices.GetAll();

            return model;
        }
    }
}
