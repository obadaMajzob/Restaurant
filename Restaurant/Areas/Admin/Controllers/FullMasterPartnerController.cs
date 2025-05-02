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
    public class FullMasterPartnerController : Controller
    {
        IFileHelper FileHelper;
        IRepository<MasterPartner> PartnerRepository;

        public FullMasterPartnerController(IRepository<MasterPartner> partnerRepository, IFileHelper fileHelper)
        {
            PartnerRepository=partnerRepository;
            FileHelper=fileHelper;
        }




        public IActionResult Index()
        {
            var data = PartnerRepository.View();
            var datapVm = data.ToListViewModel();

            var obj = new MasterFullPartnerViewModel
            {
                masterPartnerViewModelss = datapVm,
            };

            return View(obj);
        }




        [HttpPost]
        public IActionResult Save(MasterFullPartnerViewModel model)
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



        public void Creat(MasterFullPartnerViewModel model)
        {
            var userId = User.Identity.Name;

            var imageName = FileHelper.SaveImage(model.ImageFile, "", "Images");

            var obj = new MasterPartner
            {
                Id = model.Id,
                MasterPartnerName = model.MasterPartnerName,
                MasterPartnerWebsiteUrl = model.MasterPartnerWebsiteUrl,

                MasterPartnerLogoImageUrl = imageName,

                CreateId=userId,
            };
            if (imageName != "Error")
            {
                PartnerRepository.Add(obj);

            }

        }


        public void Edit(MasterFullPartnerViewModel model)
        {
            var userId = User.Identity.Name;
            var imageName = FileHelper.SaveImage(model.ImageFile, model.MasterPartnerLogoImageUrl, "Images");

            var obj = new MasterPartner
            {

                Id = model.Id,
                MasterPartnerName = model.MasterPartnerName,
                MasterPartnerWebsiteUrl = model.MasterPartnerWebsiteUrl,

                MasterPartnerLogoImageUrl = imageName,

                CreateId=userId,

                EditId=userId,
            };
            if (imageName != "Error")
            {
                PartnerRepository.Update(model.Id, obj);

            }

        }

        public IActionResult Delete(MasterFullPartnerViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterPartner();
            obj.DeleteId=userId;
            PartnerRepository.Delete(model.Id, obj);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult ChangeStatus(int id, IFormCollection collection)
        {
            var userId = User.Identity.Name;
            var obj = new MasterPartner();
            obj.EditId=userId;
            PartnerRepository.ChangeStatus(id, obj);

            return RedirectToAction(nameof(Index));

        }

























    }
}
