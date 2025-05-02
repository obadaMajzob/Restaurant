using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{
    public static class MasterSocialMediumExtension
    {

        public static MasterSocialMediumViewModel ToViewModel(this MasterSocialMedium masterSocialMedium)
        {
            return new MasterSocialMediumViewModel
            {
                MasterSocialMediaImageUrl = masterSocialMedium.MasterSocialMediaImageUrl,

                MasterSocialMediaUrl = masterSocialMedium.MasterSocialMediaUrl,
                Id = masterSocialMedium.Id,
                IsActive = masterSocialMedium.IsActivate,

            };


        }
        public static MasterSocialMedium ToModel(this MasterSocialMediumViewModel masterSocialMedium)
        {
            return new MasterSocialMedium
            {
                MasterSocialMediaImageUrl = masterSocialMedium.MasterSocialMediaImageUrl,
                MasterSocialMediaUrl = masterSocialMedium.MasterSocialMediaUrl,
                Id = masterSocialMedium.Id,
                IsActivate = masterSocialMedium.IsActive,

            };


        }
        public static List<MasterSocialMediumViewModel> ToViewModelList(this List<MasterSocialMedium> masterSocialMedium)
        {
            var list = masterSocialMedium.Select(x => x.ToViewModel()).ToList();
            return list;

        }

    }
}
