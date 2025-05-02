using Microsoft.AspNetCore.Mvc;
using Restaurant.Extensions;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;

namespace Restaurant.Components
{
    public class ContactUsViewComponent : ViewComponent
    {
        IRepository<MasterContactUsInformation> ContactUsInformationRepository;

        public ContactUsViewComponent(IRepository<MasterContactUsInformation> contactUsInformationRepository)
        {
            ContactUsInformationRepository=contactUsInformationRepository;
        }


        //////InvokeAsync()  IViewComponentResult

        public async Task<IViewComponentResult> InvokeAsync() {
            var obj = new ContactViewModel
            {

                MasterContactUsInformationList = GetInformationLink(),

            };
            return View(obj);
        }

        private List<MasterContactUsInformationViewModel> GetInformationLink()
        {

            return ContactUsInformationRepository.ViewClient().ToListViewModel();

        }

    }
}
