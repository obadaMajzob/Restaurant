using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{
    public static class MasterAboutExtension
    {


        public static MasterAboutViewModel ToViewModel(this MasterAbout MasterAbout)
        {

            return new MasterAboutViewModel
            {
                Id = MasterAbout.Id,
                Title = MasterAbout.Title,
                Description = MasterAbout.Description,
                Paragraph= MasterAbout.Paragraph,
                Brief = MasterAbout.Brief,
                ImageURL = MasterAbout.ImageURL,    

                IsActivate = MasterAbout.IsActivate,

            };

        }

        public static MasterAbout ToModel(this MasterAboutViewModel MasterAboutVM)
        {

            return new MasterAbout
            {
                Id = MasterAboutVM.Id,
                Title = MasterAboutVM.Title,
                Description = MasterAboutVM.Description,
                Paragraph= MasterAboutVM.Paragraph,
                Brief = MasterAboutVM.Brief,
                ImageURL = MasterAboutVM.ImageURL,

                IsActivate = MasterAboutVM.IsActivate,


            };

        }
        public static List<MasterAboutViewModel> ToListViewModel(this List<MasterAbout> MasterAbout)
        {

            return MasterAbout.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterAbout> ToListModel(this List<MasterAboutViewModel> MasterAboutVM)
        {

            return MasterAboutVM.Select(x => x.ToModel()).ToList();

        }



    }
}
