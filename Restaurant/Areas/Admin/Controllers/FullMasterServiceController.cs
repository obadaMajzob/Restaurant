using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Extensions;
using Restaurant.Helpers.File;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class FullMasterServiceController : Controller
    {
        IRepository<MasterService> ServiceRepository;


        public FullMasterServiceController(IRepository<MasterService> serviceRepository)
        {
            ServiceRepository=serviceRepository;

        }





        public IActionResult Index()
        {
            var data = ServiceRepository.View();
            var datapVm = data.ToListViewModel();

            var obj = new MasterFullServiceViewModel
            {
                MasterServiceViewModelss = datapVm,
            };

            return View(obj);
        }




        [HttpPost]
        public IActionResult Save(MasterFullServiceViewModel model)
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



        public void Creat(MasterFullServiceViewModel model)
        {
            var userId = User.Identity.Name;

            

            var obj = new MasterService
            {
                Id = model.Id,
                MasterServicesTitle = model.MasterServicesTitle,
                MasterServicesDesc = model.MasterServicesDesc,
                MasterServicesImage = model.MasterServicesImage,

                CreateId=userId,
            };
       
                ServiceRepository.Add(obj);


        }


        public void Edit(MasterFullServiceViewModel model)
        {
            var userId = User.Identity.Name;
            

            var obj = new MasterService
            {
                Id = model.Id,
                MasterServicesTitle = model.MasterServicesTitle,
                MasterServicesDesc = model.MasterServicesDesc,
                MasterServicesImage = model.MasterServicesImage,

                EditId=userId,
            };
     
                ServiceRepository.Update(model.Id, obj);


        }

        public IActionResult Delete(MasterFullServiceViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterService();
            obj.DeleteId=userId;

            ServiceRepository.Delete(model.Id, obj);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult ChangeStatus(int id, IFormCollection collection)
        {
            var userId = User.Identity.Name;
            var obj = new MasterService();
            obj.EditId=userId;

            ServiceRepository.ChangeStatus(id, obj);

            return RedirectToAction(nameof(Index));

        }










    }
}
