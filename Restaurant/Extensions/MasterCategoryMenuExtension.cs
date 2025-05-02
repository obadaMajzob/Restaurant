using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{
    public static class MasterCategoryMenuExtension
    {



        public static MasterCategoryMenuViewModel ToViewModel(this MasterCategoryMenu MasterCategoryMenu)
        {

            return new MasterCategoryMenuViewModel
            {
                Id = MasterCategoryMenu.Id,
                MasterCategoryMenuName = MasterCategoryMenu.MasterCategoryMenuName,
                IsActivate = MasterCategoryMenu.IsActivate,
            };

        }

        public static MasterCategoryMenu ToModel(this MasterCategoryMenuViewModel MasterCategoryMenu)
        {

            return new MasterCategoryMenu
            {
                Id = MasterCategoryMenu.Id,
                MasterCategoryMenuName = MasterCategoryMenu.MasterCategoryMenuName,
                IsActivate = MasterCategoryMenu.IsActivate,

            };

        }
        public static List<MasterCategoryMenuViewModel> ToListViewModel(this List<MasterCategoryMenu> MasterCategoryMenu)
        {

            return MasterCategoryMenu.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterCategoryMenu> ToListModel(this List<MasterCategoryMenuViewModel> MasterCategoryMenu)
        {

            return MasterCategoryMenu.Select(x => x.ToModel()).ToList();

        }










    }
}
