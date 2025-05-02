using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Extensions;
using Restaurant.Helpers.File;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;
using System.Runtime.InteropServices;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]

    public class FullMasterAboutController : Controller
    {
        IRepository<MasterAbout> AboutRepository;
        IFileHelper FileHelper;
        public FullMasterAboutController(IRepository<MasterAbout> aboutRepository, IFileHelper fileHelper)
        {
            AboutRepository=aboutRepository;
            FileHelper=fileHelper;
        }

        public IActionResult Index()
        {
            var data = AboutRepository.View();
            var datapVm = data.ToListViewModel();

            var obj = new MasterFullAboutViewModel
            {
                MasterAboutViewModelss = datapVm,
            };

            return View(obj);
        }




        [HttpPost]
        public IActionResult Save(MasterFullAboutViewModel model)
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



        public void Creat(MasterFullAboutViewModel model)
        {
            var userId = User.Identity.Name;

            var imageName = FileHelper.SaveImage(model.ImageFile, "", "Images");

            var obj = new MasterAbout
            {
                Id = model.Id,
                Title = model.Title,    
                Description = model.Description,    
                Paragraph = model.Paragraph,
                Brief = model.Brief,
                ImageURL = imageName,
                CreateId=userId,
            };
            if (imageName != "Error" )
            {
                AboutRepository.Add(obj);

            }

        }


        public void Edit(MasterFullAboutViewModel model)
        {
            var userId = User.Identity.Name;
            var imageName = FileHelper.SaveImage(model.ImageFile, model.ImageURL, "Images");
           
            var obj = new MasterAbout
            {
                Id = model.Id,

                Title = model.Title,
                Description = model.Description,
                Paragraph = model.Paragraph,
                Brief = model.Brief,
                ImageURL = imageName,
                EditId=userId,
            };
            if (imageName != "Error")
            {
                AboutRepository.Update(model.Id, obj);

            }

        }

        public IActionResult Delete(MasterFullAboutViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterAbout();
            obj.DeleteId=userId;
            AboutRepository.Delete(model.Id, obj);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult ChangeStatus(int id, IFormCollection collection)
        {
            var userId = User.Identity.Name;
            var obj = new MasterAbout();
            obj.EditId=userId;
            AboutRepository.ChangeStatus(id,obj);

            return RedirectToAction(nameof(Index));

        }




    }
}
