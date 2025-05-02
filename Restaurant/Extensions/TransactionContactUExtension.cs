using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{
    public static class TransactionContactUExtension
    {



        public static TransactionContactUViewModel ToViewModel(this TransactionContactU TransactionContactU)
        {

            return new TransactionContactUViewModel
            {
                Id = TransactionContactU.Id,
                TransactionContactUsFullName = TransactionContactU.TransactionContactUsFullName,
                TransactionContactUsEmail = TransactionContactU.TransactionContactUsEmail,
                TransactionContactUsSubject = TransactionContactU.TransactionContactUsSubject,
                TransactionContactUsMessage = TransactionContactU.TransactionContactUsMessage,
            };

        }


        public static TransactionContactU ToModel(this TransactionContactUViewModel TransactionContactU)
        {

            return new TransactionContactU
            {
                Id = TransactionContactU.Id,
                TransactionContactUsFullName = TransactionContactU.TransactionContactUsFullName,
                TransactionContactUsEmail = TransactionContactU.TransactionContactUsEmail,
                TransactionContactUsSubject = TransactionContactU.TransactionContactUsSubject,
                TransactionContactUsMessage = TransactionContactU.TransactionContactUsMessage,


            };

        }


        public static List<TransactionContactUViewModel> TolListViewMode(this List<TransactionContactU> TransactionContactU)
        {

            return TransactionContactU.Select(s => s.ToViewModel()).ToList();
        }


        public static List<TransactionContactU> ToListModel(this List<TransactionContactUViewModel> TransactionContactU)
        {

            return TransactionContactU.Select(x => x.ToModel()).ToList();

        }
    








}



}
