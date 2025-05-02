using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{
    public static class MasterClientsFeedbackExtension
    {




        public static MasterClientsFeedbackViewModel ToViewModel(this MasterClientsFeedback MasterClientsFeedback)
        {

            return new MasterClientsFeedbackViewModel
            {
                Id = MasterClientsFeedback.Id,
                Text = MasterClientsFeedback.Text,
                Name = MasterClientsFeedback.Name,  
                ImageURL = MasterClientsFeedback.ImageURL,

                IsActivate = MasterClientsFeedback.IsActivate,

            };

        }

        public static MasterClientsFeedback ToModel(this MasterClientsFeedbackViewModel MasterClientsFeedback)
        {

            return new MasterClientsFeedback
            {
                Id = MasterClientsFeedback.Id,
                Text = MasterClientsFeedback.Text,
                Name = MasterClientsFeedback.Name,
                ImageURL = MasterClientsFeedback.ImageURL,

                IsActivate = MasterClientsFeedback.IsActivate,


            };

        }
        public static List<MasterClientsFeedbackViewModel> ToListViewModel(this List<MasterClientsFeedback> MasterClientsFeedback)
        {

            return MasterClientsFeedback.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterClientsFeedback> ToListModel(this List<MasterClientsFeedbackViewModel> MasterClientsFeedback)
        {

            return MasterClientsFeedback.Select(x => x.ToModel()).ToList();

        }








    }
}
