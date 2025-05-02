namespace Restaurant.ViewModels
{
    public class MasterSocialMediumViewModel
    {
        public int Id { get; set; }
        public string MasterSocialMediaImageUrl { get; set; }

        public string MasterSocialMediaUrl { get; set; }
        public bool IsActive { get; set; }

    }
    public class MasterSocialMediumFullViewModel
    {
        public int Id { get; set; }
        public string MasterSocialMediaImageUrl { get; set; }

        public string MasterSocialMediaUrl { get; set; }
        public bool IsActive { get; set; }

        public List<MasterSocialMediumViewModel> MasterSocialMediaList { get; set; }
    }
}
