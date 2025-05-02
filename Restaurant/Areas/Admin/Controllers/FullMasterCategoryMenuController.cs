using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Extensions;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class FullMasterCategoryMenuController : Controller
    {
        IRepository<MasterCategoryMenu> CategoryMenuRepository;

        public FullMasterCategoryMenuController(IRepository<MasterCategoryMenu> categoryMenuRepository)
        {
            CategoryMenuRepository=categoryMenuRepository;
        }



        public IActionResult Index()
        {
            var data = CategoryMenuRepository.View();
            var dataVm = data.ToListViewModel();

            var obj = new MasterFullCategoryMenuViewModel
            {

                MasterCategoryMenuViewModelss = dataVm,

            };
            return View(obj);
        }





        [HttpPost]
        public IActionResult Save(MasterFullCategoryMenuViewModel model)
        {
            if (model.Id == 0)
            {
                Creat(model);
            }
            else
            {
                Edit(model);
            }
            return RedirectToAction(nameof(Index));

        }






        public void Creat(MasterFullCategoryMenuViewModel model)
        {
            var userId = User.Identity.Name;



            var obj = new MasterCategoryMenu
            {
                Id = model.Id,
                MasterCategoryMenuName = model.MasterCategoryMenuName,


                CreateId=userId,
            };

            CategoryMenuRepository.Add(obj);


        }


        public void Edit(MasterFullCategoryMenuViewModel model)
        {
            var userId = User.Identity.Name;


            var obj = new MasterCategoryMenu
            {
                Id = model.Id,
                MasterCategoryMenuName = model.MasterCategoryMenuName,
               

                EditId=userId,
            };

            CategoryMenuRepository.Update(model.Id, obj);


        }

        public IActionResult Delete(MasterFullCategoryMenuViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterCategoryMenu();
            obj.DeleteId=userId;

            CategoryMenuRepository.Delete(model.Id, obj);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult ChangeStatus(int id, IFormCollection collection)
        {
            var userId = User.Identity.Name;
            var obj = new MasterCategoryMenu();
            obj.EditId=userId;

            CategoryMenuRepository.ChangeStatus(id, obj);

            return RedirectToAction(nameof(Index));

        }








    }
}
