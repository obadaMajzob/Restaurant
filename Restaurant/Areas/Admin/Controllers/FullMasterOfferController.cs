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
    public class FullMasterOfferController : Controller
    {
        IFileHelper FileHelper;
        IRepository<MasterOffer> OfferRepository;

        public FullMasterOfferController(IRepository<MasterOffer> offerRepository, IFileHelper fileHelper)
        {
            OfferRepository=offerRepository;
            FileHelper=fileHelper;
        }





        public IActionResult Index()
        {
            var data = OfferRepository.View();
            var datapVm = data.ToListViewModel();

            var obj = new MasterFullOfferViewModel
            {
                masterOfferViewModelss = datapVm,
            };

            return View(obj);
        }




        [HttpPost]
        public IActionResult Save(MasterFullOfferViewModel model)
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



        public void Creat(MasterFullOfferViewModel model)
        {
            var userId = User.Identity.Name;

            var imageName = FileHelper.SaveImage(model.ImageFile, "", "Images");

            var obj = new MasterOffer
            {
                Id = model.Id,
                MasterOfferTitle = model.MasterOfferTitle,  
                MasterOfferBreef = model.MasterOfferBreef,
                MasterOfferDesc = model.MasterOfferDesc,    
                
                MasterOfferImageUrl = imageName,

                CreateId=userId,
            };
            if (imageName != "Error")
            {
                OfferRepository.Add(obj);

            }

        }


        public void Edit(MasterFullOfferViewModel model)
        {
            var userId = User.Identity.Name;
            var imageName = FileHelper.SaveImage(model.ImageFile, model.MasterOfferImageUrl, "Images");

            var obj = new MasterOffer
            {

                Id = model.Id,
                MasterOfferTitle = model.MasterOfferTitle,
                MasterOfferBreef = model.MasterOfferBreef,
                MasterOfferDesc = model.MasterOfferDesc,

                MasterOfferImageUrl = imageName,

                CreateId=userId,

                EditId=userId,
            };
            if (imageName != "Error")
            {
                OfferRepository.Update(model.Id, obj);

            }

        }

        public IActionResult Delete(MasterFullOfferViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterOffer();
            obj.DeleteId=userId;
            OfferRepository.Delete(model.Id, obj);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult ChangeStatus(int id, IFormCollection collection)
        {
            var userId = User.Identity.Name;
            var obj = new MasterOffer();
            obj.EditId=userId;
            OfferRepository.ChangeStatus(id, obj);

            return RedirectToAction(nameof(Index));

        }










    }
}
