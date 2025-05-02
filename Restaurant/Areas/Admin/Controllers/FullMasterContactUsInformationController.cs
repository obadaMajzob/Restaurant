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
    public class FullMasterContactUsInformationController : Controller
    {
        IRepository<MasterContactUsInformation> ContactUsInformationRepository;

        public FullMasterContactUsInformationController(IRepository<MasterContactUsInformation> contactUsInformationRepository)
        {
            ContactUsInformationRepository=contactUsInformationRepository;
        }

        public IActionResult Index()
        {
            var data = ContactUsInformationRepository.View();
            var datapVm = data.ToListViewModel();

            var obj = new MasterFullContactUsInformationViewModel
            {
                MasterContactUsInformationViewModelss = datapVm,
            };

            return View(obj);
        }




        [HttpPost]
        public IActionResult Save(MasterFullContactUsInformationViewModel model)
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



        public void Creat(MasterFullContactUsInformationViewModel model)
        {
            var userId = User.Identity.Name;



            var obj = new MasterContactUsInformation
            {
                Id = model.Id,
                MasterContactUsInformationIdesc = model.MasterContactUsInformationIdesc,
                MasterContactUsInformationRedirect = model.MasterContactUsInformationRedirect,
                MasterContactUsInformationImageUrl = model.MasterContactUsInformationImageUrl,

                CreateId=userId,
            };

            ContactUsInformationRepository.Add(obj);


        }


        public void Edit(MasterFullContactUsInformationViewModel model)
        {
            var userId = User.Identity.Name;


            var obj = new MasterContactUsInformation
            {
                Id = model.Id,
                MasterContactUsInformationIdesc = model.MasterContactUsInformationIdesc,
                MasterContactUsInformationRedirect = model.MasterContactUsInformationRedirect,
                MasterContactUsInformationImageUrl = model.MasterContactUsInformationImageUrl,

                EditId=userId,
            };

            ContactUsInformationRepository.Update(model.Id, obj);


        }

        public IActionResult Delete(MasterFullContactUsInformationViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterContactUsInformation();
            obj.DeleteId=userId;

            ContactUsInformationRepository.Delete(model.Id, obj);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult ChangeStatus(int id, IFormCollection collection)
        {
            var userId = User.Identity.Name;
            var obj = new MasterContactUsInformation();
            obj.EditId=userId;

            ContactUsInformationRepository.ChangeStatus(id, obj);

            return RedirectToAction(nameof(Index));

        }












    }
}
