using Microsoft.AspNetCore.Mvc;
using Restaurant.Extensions;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;

namespace Restaurant.Components
{
    public class AboutViewComponent : ViewComponent 
    {

        IRepository<MasterAbout> AboutRepository;

        public AboutViewComponent(IRepository<MasterAbout> aboutRepository)
        {
            AboutRepository=aboutRepository;
        }



        //////InvokeAsync()  IViewComponentResult

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var obj = new ComponentViewModel
            {

                MasterAbout = GetAboutLink(),

            };
            return View(obj);
        }

        private MasterAboutViewModel GetAboutLink()
        {
            return AboutRepository.ViewClient().ToListViewModel().FirstOrDefault();
        }

    }
}
