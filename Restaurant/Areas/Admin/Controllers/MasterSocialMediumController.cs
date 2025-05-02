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
    public class MasterSocialMediumController : Controller
    {
        IRepository<MasterSocialMedium> SocialRepo;

        public MasterSocialMediumController(IRepository<MasterSocialMedium> socialRepo)
        {
            SocialRepo = socialRepo;
        }

        public ActionResult Index()
        {
            var data = SocialRepo.View().ToViewModelList();
            var obj = new MasterSocialMediumFullViewModel
            {
                MasterSocialMediaList = data

            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult Save(MasterSocialMediumFullViewModel model)
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
        public void Create(MasterSocialMediumFullViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterSocialMedium
            {
                Id = model.Id,
                MasterSocialMediaImageUrl = model.MasterSocialMediaImageUrl,
                MasterSocialMediaUrl = model.MasterSocialMediaUrl,
               
                CreateId =userId,

            };
            SocialRepo.Add(obj);
        }
        public void Edit(MasterSocialMediumFullViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterSocialMedium
            {
                Id = model.Id,
                MasterSocialMediaImageUrl=model.MasterSocialMediaImageUrl,
                MasterSocialMediaUrl = model.MasterSocialMediaUrl,
               

                EditId = userId,
            };
            SocialRepo.Update(model.Id, obj);
        }
        public IActionResult Delete(MasterSocialMediumFullViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterSocialMedium
            {
                Id = model.Id,
                DeleteId =userId,
            };
            SocialRepo.Delete(model.Id, obj);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult ChangeStatus(MasterSocialMediumFullViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new MasterSocialMedium
            {
                Id = model.Id,
                EditId =userId,
            };
            SocialRepo.ChangeStatus(model.Id, obj);
            return RedirectToAction(nameof(Index));
        }
    }








}
