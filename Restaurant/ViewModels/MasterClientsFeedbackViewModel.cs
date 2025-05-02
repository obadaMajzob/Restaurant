namespace Restaurant.ViewModels
{
    public class MasterClientsFeedbackViewModel
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public string? Name { get; set; }
        public string? ImageURL { get; set; }

        public IFormFile ImageFile { get; set; }

        public bool IsActivate { get; set; }

    }






    public class MasterFullClientsFeedbackViewModel
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public string? Name { get; set; }
        public string? ImageURL { get; set; }

        public IFormFile ImageFile { get; set; }

        public bool IsActivate { get; set; }
        public List<MasterClientsFeedbackViewModel> masterClientsFeedbackViewModelss { get; set; }
    }






}
