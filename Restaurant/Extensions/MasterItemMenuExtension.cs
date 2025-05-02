using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{
    public static class MasterItemMenuExtension
    {




        public static MasterItemMenuViewModel ToViewModel(this MasterItemMenu MasterItemMenu)
        {

            return new MasterItemMenuViewModel
            {
                Id = MasterItemMenu.Id,
                MasterItemMenuTitle = MasterItemMenu.MasterItemMenuTitle,
                MasterItemMenuBreef = MasterItemMenu.MasterItemMenuBreef,
                MasterItemMenuDesc = MasterItemMenu.MasterItemMenuDesc, 
                MasterItemMenuPrice = MasterItemMenu.MasterItemMenuPrice,   
                MasterItemMenuImageUrl = MasterItemMenu.MasterItemMenuImageUrl,

                MasterItemMenuDate = DateTime.Now,

                MasterCategoryMenuId = MasterItemMenu.MasterCategoryMenuId,

                IsActivate = MasterItemMenu.IsActivate,

            };

        }

        public static MasterItemMenu ToModel(this MasterItemMenuViewModel MasterItemMenu)
        {

            return new MasterItemMenu
            {
                Id = MasterItemMenu.Id,
                MasterItemMenuTitle = MasterItemMenu.MasterItemMenuTitle,
                MasterItemMenuBreef = MasterItemMenu.MasterItemMenuBreef,
                MasterItemMenuDesc = MasterItemMenu.MasterItemMenuDesc,
                MasterItemMenuPrice = MasterItemMenu.MasterItemMenuPrice,
                MasterItemMenuImageUrl = MasterItemMenu.MasterItemMenuImageUrl,

                MasterItemMenuDate = DateTime.Now,

                MasterCategoryMenuId = MasterItemMenu.MasterCategoryMenuId,

                IsActivate = MasterItemMenu.IsActivate,

            };

        }
        public static List<MasterItemMenuViewModel> ToListViewModel(this List<MasterItemMenu> MasterItemMenu)
        {

            return MasterItemMenu.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterItemMenu> ToListModel(this List<MasterItemMenuViewModel> MasterItemMenu)
        {

            return MasterItemMenu.Select(x => x.ToModel()).ToList();

        }












    }
}
