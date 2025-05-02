namespace Restaurant.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string? CreateId { get; set; }    
        public DateTime? CreateDate { get; set; }
        public string? EditId { get; set; }
        public DateTime? EditDate { get; set; }
        public string? DeleteId { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsActivate { get; set; }
    }
}
