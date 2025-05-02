namespace Restaurant.ViewModels
{
    public class MasterContactUsInformationViewModel
    {

        public int Id { get; set; }

        public string? MasterContactUsInformationIdesc { get; set; }

        public string? MasterContactUsInformationImageUrl { get; set; }

        public string? MasterContactUsInformationRedirect { get; set; }

        public bool IsActivate { get; set; }

    }



    public class MasterFullContactUsInformationViewModel
    {

        public int Id { get; set; }

        public string? MasterContactUsInformationIdesc { get; set; }

        public string? MasterContactUsInformationImageUrl { get; set; }

        public string? MasterContactUsInformationRedirect { get; set; }

        public bool IsActivate { get; set; }

        public List<MasterContactUsInformationViewModel> MasterContactUsInformationViewModelss { get; set; }

    }








}
