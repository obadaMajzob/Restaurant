using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{
    public static class MasterPartnerExtension
    {





        public static MasterPartnerViewModel ToViewModel(this MasterPartner MasterPartner)
        {

            return new MasterPartnerViewModel
            {
                Id =  MasterPartner.Id,
                MasterPartnerName = MasterPartner.MasterPartnerName,
                MasterPartnerWebsiteUrl = MasterPartner.MasterPartnerWebsiteUrl,  
                MasterPartnerLogoImageUrl = MasterPartner.MasterPartnerLogoImageUrl,    


                IsActivate =  MasterPartner.IsActivate,

            };

        }

        public static MasterPartner ToModel(this MasterPartnerViewModel MasterPartner)
        {

            return new MasterPartner
            {
                Id =  MasterPartner.Id,
                MasterPartnerName = MasterPartner.MasterPartnerName,
                MasterPartnerWebsiteUrl = MasterPartner.MasterPartnerWebsiteUrl,
                MasterPartnerLogoImageUrl = MasterPartner.MasterPartnerLogoImageUrl,


                IsActivate =  MasterPartner.IsActivate,


            };

        }
        public static List<MasterPartnerViewModel> ToListViewModel(this List<MasterPartner> MasterPartner)
        {

            return MasterPartner.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterPartner> ToListModel(this List<MasterPartnerViewModel> MasterPartner)
        {

            return MasterPartner.Select(x => x.ToModel()).ToList();

        }






    }
}
