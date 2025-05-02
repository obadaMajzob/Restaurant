namespace Restaurant.ViewModels
{
    public class MasterAboutViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Paragraph { get; set; }
        public string? Brief { get; set; }
        public string? ImageURL { get; set; }

        public IFormFile ImageFile { get; set; }
        public bool IsActivate { get; set; }

    }
    public class MasterFullAboutViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Paragraph { get; set; }
        public string? Brief { get; set; }
        public string? ImageURL { get; set; }

        public IFormFile ImageFile { get; set; }
        public bool IsActivate { get; set; }

        public List<MasterAboutViewModel> MasterAboutViewModelss { get; set; }
    }
}
