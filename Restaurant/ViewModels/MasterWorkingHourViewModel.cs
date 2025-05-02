namespace Restaurant.ViewModels
{


    public class MasterWorkingHourViewModel
    {
        public int Id { get; set; }
        public string? MasterWorkingHoursIdName { get; set; }

        public string? MasterWorkingHoursIdTimeFormTo { get; set; }
        public bool IsActivate { get; set; }

    }
    public class MasterWorkingHourFullPageViewModel
    {
        public int Id { get; set; }
        public string? MasterWorkingHoursIdName { get; set; }

        public string? MasterWorkingHoursIdTimeFormTo { get; set; }
        public bool IsActivate { get; set; }

        public List<MasterWorkingHourViewModel> MasterWorkingHoursList { get; set; }

    }



}
