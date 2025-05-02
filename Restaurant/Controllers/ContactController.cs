using Microsoft.AspNetCore.Mvc;
using Restaurant.Extensions;
using Restaurant.Helpers.Email;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;
using System.Text;

namespace Restaurant.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRepository<MasterContactUsInformation> masterContactUsInformationRepository;
        IRepository<TransactionContactU> transactionContactURepository;
        IEmailHelper emailHelper;
        public ContactController(ILogger<HomeController> logger, IRepository<TransactionContactU> transactionContactURepository, IEmailHelper emailHelper, IRepository<MasterContactUsInformation> masterContactUsInformationRepository)
        {
            _logger=logger;
            this.transactionContactURepository=transactionContactURepository;
            this.emailHelper=emailHelper;
            this.masterContactUsInformationRepository=masterContactUsInformationRepository;
        }


        public IActionResult Index()
        {
            var obj = new ContactViewModel { 
                
                MasterContactUsInformationList = GetInformationLink(),

            };
            return View(obj);
        }


        private List<MasterContactUsInformationViewModel> GetInformationLink() {

            return masterContactUsInformationRepository.ViewClient().ToListViewModel();

        }







        // POST: TransactionContentUsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContactUsSave(ContactViewModel collection)
        {
            try
            {
                var FullName = collection.TransactionContactUss.TransactionContactUsFullName;
                var Subject = collection.TransactionContactUss.TransactionContactUsSubject;
                var Email = collection.TransactionContactUss.TransactionContactUsEmail;


                StringBuilder sb = new StringBuilder();
                sb.Append($"<h1> Hello  {FullName} {Subject} </h1>");
                sb.Append("<h4> Sent Using Html </h4>");

                transactionContactURepository.Add(collection.TransactionContactUss.ToModel());
                emailHelper.SendEmail(Email, "Message Received", sb.ToString());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }











    }
}
