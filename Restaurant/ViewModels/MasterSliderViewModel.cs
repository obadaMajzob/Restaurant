namespace Restaurant.ViewModels
{
    public class MasterSliderViewModel
    {
        public int Id { get; set; }
        public string? MasterSliderTitle { get; set; }

        public string? MasterSliderBreef { get; set; }

        public string? MasterSliderDesc { get; set; }


        public string? MasterSliderUrl { get; set; }
        public IFormFile ImageFile { get; set; }

        public bool IsActivate { get; set; }
    }


    public class MasterFullSliderViewModel
    {
        public int Id { get; set; }
        public string? MasterSliderTitle { get; set; }

        public string? MasterSliderBreef { get; set; }

        public string? MasterSliderDesc { get; set; }


        public string? MasterSliderUrl { get; set; }
        public IFormFile ImageFile { get; set; }

        public bool IsActivate { get; set; }
        public List<MasterSliderViewModel> MasterSliderViewModelss { get; set; }
    }


}
