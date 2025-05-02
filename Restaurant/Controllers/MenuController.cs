using Microsoft.AspNetCore.Mvc;
using Restaurant.Extensions;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;

namespace Restaurant.Controllers
{
    public class MenuController : Controller
    {
        private readonly ILogger<MenuController> _logger;
        IRepository<MasterCategoryMenu> masterCategoryMenuRepository;


        IRepository<MasterPartner> masterPartnerRepository;


        public MenuController(ILogger<MenuController> logger, IRepository<MasterCategoryMenu> masterCategoryMenuRepository, IRepository<MasterPartner> masterPartnerRepository)
        {
            _logger=logger;
            this.masterCategoryMenuRepository=masterCategoryMenuRepository;
            this.masterPartnerRepository=masterPartnerRepository;
        }


        public IActionResult Index()
        {
            var obj = new MenuViewModel
            {

                MasterCategoryMenuList = GetCategoryMenuLink(),


                MasterPartnerList = GetPartnerLink(),


            };
            return View(obj);
        }


        private List<MasterCategoryMenuViewModel> GetCategoryMenuLink()
        {
            return masterCategoryMenuRepository.ViewClient().ToListViewModel();
        }






        private List<MasterPartnerViewModel> GetPartnerLink()
        {
            return masterPartnerRepository.ViewClient().ToListViewModel();
        }






    }
}
