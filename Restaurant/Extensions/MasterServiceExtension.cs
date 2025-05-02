using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{
    public static class MasterServiceExtension
    {




        public static MasterServiceViewModel ToViewModel(this MasterService MasterService)
        {

            return new MasterServiceViewModel
            {
                Id = MasterService.Id,
                MasterServicesTitle = MasterService.MasterServicesTitle,    
                MasterServicesDesc = MasterService.MasterServicesDesc,
                MasterServicesImage = MasterService.MasterServicesImage,
                
                IsActivate = MasterService.IsActivate,

            };

        }

        public static MasterService ToModel(this MasterServiceViewModel MasterService)
        {

            return new MasterService
            {
                Id = MasterService.Id,
                MasterServicesTitle = MasterService.MasterServicesTitle,
                MasterServicesDesc = MasterService.MasterServicesDesc,
                MasterServicesImage = MasterService.MasterServicesImage,

                IsActivate = MasterService.IsActivate,


            };

        }
        public static List<MasterServiceViewModel> ToListViewModel(this List<MasterService> MasterService)
        {

            return MasterService.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterService> ToListModel(this List<MasterServiceViewModel> MasterService)
        {

            return MasterService.Select(x => x.ToModel()).ToList();

        }







    }
}
