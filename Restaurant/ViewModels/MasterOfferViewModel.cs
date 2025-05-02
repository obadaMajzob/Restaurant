namespace Restaurant.ViewModels
{
    public class MasterOfferViewModel
    {
        public int Id { get; set; }

        public string? MasterOfferTitle { get; set; }

        public string? MasterOfferBreef { get; set; }

        public string? MasterOfferDesc { get; set; }

        public string? MasterOfferImageUrl { get; set; }


        public IFormFile ImageFile { get; set; }

        public bool IsActivate { get; set; }

    }



    public class MasterFullOfferViewModel
    {
        public int Id { get; set; }

        public string? MasterOfferTitle { get; set; }

        public string? MasterOfferBreef { get; set; }

        public string? MasterOfferDesc { get; set; }

        public string? MasterOfferImageUrl { get; set; }


        public IFormFile ImageFile { get; set; }

        public bool IsActivate { get; set; }

        public List<MasterOfferViewModel> masterOfferViewModelss { get; set; }

    }




}
