namespace Restaurant.ViewModels
{
    public class TransactionContactUViewModel
    {

        public int Id { get; set; }

        public string? TransactionContactUsFullName { get; set; }

        public string? TransactionContactUsEmail { get; set; }

        public string? TransactionContactUsSubject { get; set; }

        public string? TransactionContactUsMessage { get; set; }


    }




    public class TransactionFullContactUViewModel
    {

        public int Id { get; set; }

        public string? TransactionContactUsFullName { get; set; }

        public string? TransactionContactUsEmail { get; set; }

        public string? TransactionContactUsSubject { get; set; }

        public string? TransactionContactUsMessage { get; set; }

        public List<TransactionContactUViewModel> TransactionContactUViewModelss { get; set; }
    }


    /////////////////////////////////////////

    public class TransactionContactUsReplyViewModel
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }






}
