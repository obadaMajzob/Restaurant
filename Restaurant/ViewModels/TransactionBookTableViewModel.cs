namespace Restaurant.ViewModels
{
    public class TransactionBookTableViewModel
    {
        public int Id { get; set; }

        public string? TransactionBookTableFullName { get; set; }

        public string? TransactionBookTableEmail { get; set; }

        public string? TransactionBookTableMobileNumber { get; set; }

        public DateTime? TransactionBookTableDate { get; set; }
    }


    public class TransactionFullBookTableViewModel
    {
        public int Id { get; set; }

        public string? TransactionBookTableFullName { get; set; }

        public string? TransactionBookTableEmail { get; set; }

        public string? TransactionBookTableMobileNumber { get; set; }

        public DateTime? TransactionBookTableDate { get; set; }

        public List<TransactionBookTableViewModel> TransactionBookTableViewModelss { get; set; }

    }




}
