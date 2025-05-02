using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{
    public static class MasterSliderExtension
    {




        public static MasterSliderViewModel ToViewModel(this MasterSlider MasterSlider)
        {

            return new MasterSliderViewModel
            {
                Id = MasterSlider.Id,
                MasterSliderTitle = MasterSlider.MasterSliderTitle,
                MasterSliderBreef = MasterSlider.MasterSliderBreef, 
                MasterSliderDesc = MasterSlider.MasterSliderDesc,   
                MasterSliderUrl = MasterSlider.MasterSliderUrl, 

                IsActivate = MasterSlider.IsActivate,

            };

        }

        public static MasterSlider ToModel(this MasterSliderViewModel MasterSlider)
        {

            return new MasterSlider
            {
                Id = MasterSlider.Id,
                MasterSliderTitle = MasterSlider.MasterSliderTitle,
                MasterSliderBreef = MasterSlider.MasterSliderBreef,
                MasterSliderDesc = MasterSlider.MasterSliderDesc,
                MasterSliderUrl = MasterSlider.MasterSliderUrl,

                IsActivate = MasterSlider.IsActivate,


            };

        }
        public static List<MasterSliderViewModel> ToListViewModel(this List<MasterSlider> MasterSlider)
        {

            return MasterSlider.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterSlider> ToListModel(this List<MasterSliderViewModel> MasterSlider)
        {

            return MasterSlider.Select(x => x.ToModel()).ToList();

        }








    }
}
