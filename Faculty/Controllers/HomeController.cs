using Faculty.BLL.Interface;
using Faculty.WEB.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Faculty.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoursesServices _coursesServices;
        private readonly IGroupsServices _groupsServices;
        private readonly IStudentsServices _studentsServices;

        public HomeController(ICoursesServices coursesService,
                              IGroupsServices groupsServices,
                              IStudentsServices studentsServices)
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
