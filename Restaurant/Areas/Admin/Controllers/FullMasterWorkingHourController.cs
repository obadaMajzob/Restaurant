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
    public class FullMasterWorkingHourController : Controller
    {



        IRepository<MasterWorkingHour> WorkingHoursrepository;

        public FullMasterWorkingHourController(IRepository<MasterWorkingHour> workingHoursrepository)
        {
            WorkingHoursrepository = workingHoursrepository;
        }

        public ActionResult Index()
        {
            var data = WorkingHoursrepository.View().ToViewModelList();
            var obj = new MasterWorkingHourFullPageViewModel
            {
                MasterWorkingHoursList = data

            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult Save(MasterWorkingHourFullPageViewModel model)
        {
            if (model.Id == 0)
            {
                Create(model);

            }
            else
            {
                Edit(model);
            }
            return RedirectToAction(nameof(Index));
        }
        public void Create(MasterWorkingHourFullPageViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterWorkingHour
            {
                MasterWorkingHoursIdName=model.MasterWorkingHoursIdName,
                MasterWorkingHoursIdTimeFormTo=model.MasterWorkingHoursIdTimeFormTo,
               

                CreateId =userId,


            };
            WorkingHoursrepository.Add(obj);
        }
        public void Edit(MasterWorkingHourFullPageViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterWorkingHour
            {
                Id = model.Id,
                MasterWorkingHoursIdName=model.MasterWorkingHoursIdName,
                MasterWorkingHoursIdTimeFormTo=model.MasterWorkingHoursIdTimeFormTo,
               

                EditId =userId,
            };
            WorkingHoursrepository.Update(model.Id, obj);
        }
        public IActionResult Delete(MasterWorkingHourFullPageViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterWorkingHour
            {
                Id = model.Id,
                DeleteId = userId,
            };
            WorkingHoursrepository.Delete(model.Id, obj);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult ChangeStatus(MasterWorkingHourFullPageViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterWorkingHour
            {
                Id = model.Id,
                EditId =userId,
            };
            WorkingHoursrepository.ChangeStatus(model.Id, obj);
            return RedirectToAction(nameof(Index));
        }





    }
}
