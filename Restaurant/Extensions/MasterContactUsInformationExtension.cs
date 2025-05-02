using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{
    public static class MasterContactUsInformationExtension
    {


        public static MasterContactUsInformationViewModel ToViewModel(this MasterContactUsInformation MasterContactUsInformation)
        {

            return new MasterContactUsInformationViewModel
            {
                Id = MasterContactUsInformation.Id,
                MasterContactUsInformationIdesc = MasterContactUsInformation.MasterContactUsInformationIdesc,
                MasterContactUsInformationRedirect = MasterContactUsInformation.MasterContactUsInformationRedirect,
                MasterContactUsInformationImageUrl = MasterContactUsInformation.MasterContactUsInformationImageUrl,

                IsActivate = MasterContactUsInformation.IsActivate,

            };

        }

        public static MasterContactUsInformation ToModel(this MasterContactUsInformationViewModel MasterContactUsInformation)
        {

            return new MasterContactUsInformation
            {
                Id = MasterContactUsInformation.Id,
                MasterContactUsInformationIdesc = MasterContactUsInformation.MasterContactUsInformationIdesc,
                MasterContactUsInformationRedirect = MasterContactUsInformation.MasterContactUsInformationRedirect,
                MasterContactUsInformationImageUrl = MasterContactUsInformation.MasterContactUsInformationImageUrl,

                IsActivate = MasterContactUsInformation.IsActivate,


            };

        }
        public static List<MasterContactUsInformationViewModel> ToListViewModel(this List<MasterContactUsInformation> MasterContactUsInformation)
        {

            return MasterContactUsInformation.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterContactUsInformation> ToListModel(this List<MasterContactUsInformationViewModel> MasterContactUsInformation)
        {

            return MasterContactUsInformation.Select(x => x.ToModel()).ToList();

        }






    }
}
