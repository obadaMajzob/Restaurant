namespace Restaurant.ViewModels
{
    public class MasterPartnerViewModel
    {

        public int Id { get; set; }

        public string? MasterPartnerName { get; set; }

        public string? MasterPartnerLogoImageUrl { get; set; }

        public string? MasterPartnerWebsiteUrl { get; set; }


        public IFormFile ImageFile { get; set; }

        public bool IsActivate { get; set; }

    }




    public class MasterFullPartnerViewModel
    {

        public int Id { get; set; }

        public string? MasterPartnerName { get; set; }

        public string? MasterPartnerLogoImageUrl { get; set; }

        public string? MasterPartnerWebsiteUrl { get; set; }


        public IFormFile ImageFile { get; set; }

        public bool IsActivate { get; set; }


        public List<MasterPartnerViewModel> masterPartnerViewModelss { get; set; }

    }









}
