namespace Restaurant.ViewModels
{
    public class MasterCategoryMenuViewModel
    {

        public int Id { get; set; }
        public string? MasterCategoryMenuName { get; set; }

        public bool IsActivate { get; set; }


    }

    public class MasterFullCategoryMenuViewModel
    {

        public int Id { get; set; }

        public string? MasterCategoryMenuName { get; set; }

        public bool IsActivate { get; set; }

        public List<MasterCategoryMenuViewModel> MasterCategoryMenuViewModelss { get; set; }

    }


}
