using Microsoft.AspNetCore.Mvc;
using Restaurant.Extensions;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;

namespace Restaurant.Components
{
    public class SocialMediaViewComponent : ViewComponent
    {
        IRepository<MasterSocialMedium> SocialMediaRepo;


        public SocialMediaViewComponent(IRepository<MasterSocialMedium> socialMediaRepo)
        {
            SocialMediaRepo = socialMediaRepo;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var obj = new ComponentViewModel
            {
                MasterSocialMediaList=GetSocials(),
            };
            return View(obj);

        }
        private List<MasterSocialMediumViewModel> GetSocials()
        {
            return SocialMediaRepo.ViewClient().ToViewModelList();

        }



    }
}
