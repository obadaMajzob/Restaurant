using Microsoft.AspNetCore.Mvc;
using Restaurant.Extensions;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;

namespace Restaurant.Controllers
{
    public class AboutController : Controller
    {
        private readonly ILogger<AboutController> _logger;
        IRepository<MasterAbout> masterAboutRepository;
        IRepository<MasterService> masterServiceRepository;

        public AboutController(ILogger<AboutController> logger, IRepository<MasterAbout> masterAboutRepository, IRepository<MasterService> masterServiceRepository)
        {
            _logger=logger;
            this.masterAboutRepository=masterAboutRepository;
            this.masterServiceRepository=masterServiceRepository;
        }

        public IActionResult Index()
        {
            var obj = new AboutViewModel
            {
                MasterAbout = GetAboutLink(),
                MasterServiceList = GetServiceLink(),

            };
            return View(obj);
        }

        private MasterAboutViewModel GetAboutLink()
        {
            return masterAboutRepository.ViewClient().ToListViewModel().FirstOrDefault();
        }
        private List<MasterServiceViewModel> GetServiceLink()
        {
            return masterServiceRepository.ViewClient().ToListViewModel();
        }
    }
}
