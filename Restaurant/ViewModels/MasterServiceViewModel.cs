namespace Restaurant.ViewModels
{
    public class MasterServiceViewModel
    {

        public int Id { get; set; }


        public string? MasterServicesTitle { get; set; }

        public string? MasterServicesDesc { get; set; }

        public string? MasterServicesImage { get; set; }


        public bool IsActivate { get; set; }

    }

    public class MasterFullServiceViewModel
    {

        public int Id { get; set; }


        public string? MasterServicesTitle { get; set; }

        public string? MasterServicesDesc { get; set; }

        public string? MasterServicesImage { get; set; }


        public bool IsActivate { get; set; }

        public List<MasterServiceViewModel> MasterServiceViewModelss { get; set; }


    }
}
