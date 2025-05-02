using Microsoft.AspNetCore.Mvc.Rendering;
using Restaurant.Models;

namespace Restaurant.ViewModels
{
    public class MasterItemMenuViewModel
    {

        public int Id { get; set; }

        public int? MasterCategoryMenuId { get; set; }

        public virtual MasterCategoryMenu? MasterCategoryMenu { get; set; }

        public string? MasterItemMenuTitle { get; set; }

        public string? MasterItemMenuBreef { get; set; }

        public string? MasterItemMenuDesc { get; set; }

        public double? MasterItemMenuPrice { get; set; }

        public string? MasterItemMenuImageUrl { get; set; }
        public IFormFile? ImageFile { get; set; }

        public DateTime? MasterItemMenuDate { get; set; }

        public bool IsActivate { get; set; }


        public SelectList ListOfCategory { get; set; }


    }





    public class MasterFullItemMenuViewModel
    {

        public int Id { get; set; }

        public int? MasterCategoryMenuId { get; set; }

        public virtual MasterCategoryMenu? MasterCategoryMenu { get; set; }

        public string? MasterItemMenuTitle { get; set; }

        public string? MasterItemMenuBreef { get; set; }

        public string? MasterItemMenuDesc { get; set; }

        public double? MasterItemMenuPrice { get; set; }

        public string? MasterItemMenuImageUrl { get; set; }
        public IFormFile? ImageFile { get; set; }

        public DateTime? MasterItemMenuDate { get; set; }

        public bool IsActivate { get; set; }

        public SelectList ListOfCategory { get; set; }


        public List<MasterItemMenuViewModel> MasterItemMenuViewModelss { get; set; }

    }










}
