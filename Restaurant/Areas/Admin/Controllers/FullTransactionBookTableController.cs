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
    public class FullTransactionBookTableController : Controller
    {

        IRepository<TransactionBookTable> BookTableRepository;
        IEmailHelper EmailHelper;

        public FullTransactionBookTableController(IRepository<TransactionBookTable> bookTableRepository, IEmailHelper emailHelper)
        {
            BookTableRepository=bookTableRepository;
            EmailHelper=emailHelper;
        }


        public IActionResult Index()
        {
            var data = BookTableRepository.View();
            var dataVm = data.TolListViewMode();

            var obj = new TransactionFullBookTableViewModel
            {
                TransactionBookTableViewModelss = dataVm,
            };
            return View(obj);
        }


        public IActionResult Delete(TransactionFullBookTableViewModel model)
        {
            var userId = User.Identity.Name;
            var obj = new TransactionBookTable();
            obj.DeleteId=userId;
            BookTableRepository.Delete(model.Id, obj);
            return RedirectToAction(nameof(Index));

        }






    }
}
