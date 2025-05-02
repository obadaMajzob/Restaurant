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
    public class FullMasterSliderController : Controller
    {
        IRepository<MasterSlider> SliderRepository;
        IFileHelper FileHelper;
        public FullMasterSliderController(IRepository<MasterSlider> sliderRepository, IFileHelper fileHelper)
        {
            SliderRepository=sliderRepository;
            FileHelper=fileHelper;
        }




        public IActionResult Index()
        {
            var data = SliderRepository.View();
            var datapVm = data.ToListViewModel();

            var obj = new MasterFullSliderViewModel
            {
                MasterSliderViewModelss = datapVm,
            };

            return View(obj);
        }




        [HttpPost]
        public IActionResult Save(MasterFullSliderViewModel model)
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



        public void Creat(MasterFullSliderViewModel model)
        {
            var userId = User.Identity.Name;

            var imageName = FileHelper.SaveImage(model.ImageFile, "", "Images");

            var obj = new MasterSlider
            {
                Id = model.Id,
                MasterSliderTitle = model.MasterSliderTitle,
                MasterSliderBreef = model.MasterSliderBreef,
                MasterSliderDesc = model.MasterSliderDesc,
                MasterSliderUrl = imageName,

                CreateId=userId,
            };
            if (imageName != "Error")
            {
                SliderRepository.Add(obj);

            }

        }


        public void Edit(MasterFullSliderViewModel model)
        {
            var userId = User.Identity.Name;
            var imageName = FileHelper.SaveImage(model.ImageFile, model.MasterSliderUrl, "Images");

            var obj = new MasterSlider
            {
                Id = model.Id,
                MasterSliderTitle = model.MasterSliderTitle,
                MasterSliderBreef = model.MasterSliderBreef,
                MasterSliderDesc = model.MasterSliderDesc,
                MasterSliderUrl = imageName,

                EditId=userId,
            };
            if (imageName != "Error")
            {
                SliderRepository.Update(model.Id, obj);

            }

        }

        public IActionResult Delete(MasterFullSliderViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterSlider();
            obj.DeleteId=userId;
            SliderRepository.Delete(model.Id, obj);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult ChangeStatus(int id, IFormCollection collection)
        {
            var userId = User.Identity.Name;
            var obj = new MasterSlider();
            obj.EditId=userId;
            SliderRepository.ChangeStatus(id, obj);

            return RedirectToAction(nameof(Index));

        }















    }
}
