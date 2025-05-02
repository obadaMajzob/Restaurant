using Microsoft.AspNetCore.Mvc;
using Restaurant.Extensions;
using Restaurant.Helpers.Email;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;
using System.Diagnostics;
using System.Text;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRepository<MasterAbout> masterAboutRepository;
        IRepository<MasterSlider> masterSliderRepository;
        IRepository<MasterClientsFeedback> masterClientsFeedbackRepository;
        IRepository<MasterOffer> masterOfferRepository;
        IRepository<MasterPartner> masterPartnerRepository;

        IRepository<TransactionBookTable> BookTableRepository;
        IEmailHelper emailHelper;
        public HomeController(ILogger<HomeController> logger, IRepository<MasterAbout> masterAboutRepository, IRepository<MasterSlider> masterSliderRepository, IRepository<MasterClientsFeedback> masterClientsFeedbackRepository, IRepository<MasterOffer> masterOfferRepository, IEmailHelper emailHelper, IRepository<TransactionBookTable> bookTableRepository, IRepository<MasterPartner> masterPartnerRepository)
        {
            _logger = logger;
            this.masterAboutRepository=masterAboutRepository;
            this.masterSliderRepository=masterSliderRepository;
            this.masterClientsFeedbackRepository=masterClientsFeedbackRepository;
            this.masterOfferRepository=masterOfferRepository;
            this.emailHelper=emailHelper;
            BookTableRepository=bookTableRepository;
            this.masterPartnerRepository=masterPartnerRepository;
        }

        public IActionResult Index()
        {
            var obj = new HomeViewModel
            {
                MasterAbout = GetAboutLink(),
                MasterSliderList = GetSliderLink(),
                MasterClientsFeedbackList = GetClientsFeedbackLink(),
                MasterOfferr = GetOfferLink(),
                MasterPartnerList = GetPartnerLink(),
            };
            return View(obj);
        }

        //private List<MasterAboutViewModel> GetMenuList() {
        //    return masterAboutRepository.ViewClient()
        //        .ToListViewModel().OrderByDescending(x=>x.Paragraph).Take(5).ToList() ;
        //}

        private MasterAboutViewModel GetAboutLink() {
            return masterAboutRepository.ViewClient().ToListViewModel().FirstOrDefault();
        }

        private List<MasterSliderViewModel> GetSliderLink() {
            return masterSliderRepository.ViewClient().ToListViewModel();
        }

        private List<MasterClientsFeedbackViewModel> GetClientsFeedbackLink() {
            return masterClientsFeedbackRepository.ViewClient().ToListViewModel();
        }
        private MasterOfferViewModel GetOfferLink() {
            return masterOfferRepository.ViewClient().ToListViewModel().FirstOrDefault();
        }

        private List<MasterPartnerViewModel> GetPartnerLink() {
            return masterPartnerRepository.ViewClient().ToListViewModel();
        }











        // POST: TransactionContentUsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookTableSave(HomeViewModel collection)
        {
            try
            {


                BookTableRepository.Add(collection.BookTables.ToModel());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }












        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
