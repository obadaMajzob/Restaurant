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
    public class FullMasterClientsFeedbackController : Controller
    {
        IRepository<MasterClientsFeedback> ClientsFeedbackRepository;
        IFileHelper FileHelper;

        public FullMasterClientsFeedbackController(IRepository<MasterClientsFeedback> clientsFeedbackRepository, IFileHelper fileHelper)
        {
            ClientsFeedbackRepository=clientsFeedbackRepository;
            FileHelper=fileHelper;
        }







        public IActionResult Index()
        {
            var data = ClientsFeedbackRepository.View();
            var datapVm = data.ToListViewModel();

            var obj = new MasterFullClientsFeedbackViewModel
            {
                masterClientsFeedbackViewModelss = datapVm,
            };

            return View(obj);
        }




        [HttpPost]
        public IActionResult Save(MasterFullClientsFeedbackViewModel model)
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



        public void Creat(MasterFullClientsFeedbackViewModel model)
        {
            var userId = User.Identity.Name;

            var imageName = FileHelper.SaveImage(model.ImageFile, "", "Images");

            var obj = new MasterClientsFeedback
            {
                Id = model.Id,
                Text = model.Text,
                Name = model.Name,
                
                ImageURL = imageName,

                CreateId=userId,
            };
            if (imageName != "Error")
            {
                ClientsFeedbackRepository.Add(obj);

            }

        }


        public void Edit(MasterFullClientsFeedbackViewModel model)
        {
            var userId = User.Identity.Name;
            var imageName = FileHelper.SaveImage(model.ImageFile, model.ImageURL, "Images");

            var obj = new MasterClientsFeedback
            {

                Id = model.Id,
                Text = model.Text,
                Name = model.Name,

                ImageURL = imageName,

                CreateId=userId,

                EditId=userId,
            };
            if (imageName != "Error")
            {
                ClientsFeedbackRepository.Update(model.Id, obj);

            }

        }

        public IActionResult Delete(MasterFullClientsFeedbackViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterClientsFeedback();
            obj.DeleteId=userId;
            ClientsFeedbackRepository.Delete(model.Id, obj);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult ChangeStatus(int id, IFormCollection collection)
        {
            var userId = User.Identity.Name;
            var obj = new MasterClientsFeedback();
            obj.EditId=userId;
            ClientsFeedbackRepository.ChangeStatus(id, obj);

            return RedirectToAction(nameof(Index));

        }














    }
}
