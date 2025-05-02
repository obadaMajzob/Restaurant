using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Extensions;
using Restaurant.Helpers.Email;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class FullTransactionContactUController : Controller
    {
        IRepository<TransactionContactU> ContactURepository;
        IEmailHelper EmailHelper;

        public FullTransactionContactUController(IRepository<TransactionContactU> contactURepository, IEmailHelper emailHelper)
        {
            ContactURepository=contactURepository;
            EmailHelper=emailHelper;
        }




        public IActionResult Index()
        {
            var data = ContactURepository.View();
            var dataVm = data.TolListViewMode();

            var obj = new TransactionFullContactUViewModel { 
            
                TransactionContactUViewModelss = dataVm,
            };
       
            return View(obj);
        }

        public IActionResult Delete(TransactionFullContactUViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new TransactionContactU();
            obj.DeleteId=userId;
            ContactURepository.Delete(model.Id, obj);
            return RedirectToAction(nameof(Index));

        }


            ///////////////** Reply **//////////////

        public IActionResult Reply(int id)
        {
            var data = ContactURepository.Find(id);
            var obj = new TransactionContactUsReplyViewModel
            {
                Email = data.TransactionContactUsEmail
            };
            return View(obj);
        }

        [HttpPost]
        public IActionResult Reply(int id, TransactionContactUsReplyViewModel model)
        {
            var message = model.Message;
            EmailHelper.SendEmail(model.Email, model.Subject, message);
            return View();
        }





























    }
}
