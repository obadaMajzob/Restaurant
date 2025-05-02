using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Restaurant.Extensions;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels;

namespace Restaurant.Components
{
    public class WorkingHourViewComponent : ViewComponent
    {
        IRepository<MasterWorkingHour> WorkingHourRepository;

        public WorkingHourViewComponent(IRepository<MasterWorkingHour> workingHourRepository)
        {
            WorkingHourRepository=workingHourRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync() {

            var obj = new ComponentViewModel
            {
                MasterWorkingHourList = GetWorkingHour()
            };

            return View(obj);
        }

        private List<MasterWorkingHourViewModel> GetWorkingHour() {

            return WorkingHourRepository.ViewClient().ToViewModelList();
        }




    }
}
