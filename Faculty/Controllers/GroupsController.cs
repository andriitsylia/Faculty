using Microsoft.AspNetCore.Mvc;
using Faculty.BLL.Interface;
using Faculty.WEB.ViewModel;
using Faculty.BLL.DTO;
using System.Collections.Generic;

namespace Faculty.WEB.Controllers
{
    public class GroupsController : Controller
    {
        private const int AllGroups = 0;
        private readonly IGroupsServices _groupsServices;
        private readonly IStudentsServices _studentsServices;

        public GroupsController(IGroupsServices groupsServices,
                                IStudentsServices studentsServices)
        {
            _groupsServices = groupsServices;
            _studentsServices = studentsServices;
        }

        public IActionResult Index()
        {
            var model = CreateModel(AllGroups);

            return View(model);
        }

        public IActionResult ChooseGroup(int groupId)
        {
            var model = CreateModel(groupId);

            return View(model);
        }

        public IActionResult EditGroup(int groupId)
        {
            if (groupId != 0)
            {
                var model = CreateModel(groupId);
                return View(model);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult SaveGroup(GroupDTO model)
        {
            _groupsServices.Save(model);
            return RedirectToAction("Index", "Home");
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

        public FullListViewModel CreateModel(int groupId)
        {
            FullListViewModel model = new();

            if (groupId != 0)
            {
                model.Groups = new List<GroupDTO> { _groupsServices.GetById(groupId) };
                model.Students = _studentsServices.GetByGroupId(groupId);
            }
            else
            {
                model.Groups = _groupsServices.GetAll();
                model.Students = _studentsServices.GetAll();
            }

            return model;
        }


    }
}
