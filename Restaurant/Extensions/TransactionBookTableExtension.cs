using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{
    public static class TransactionBookTableExtension
    {



        public static TransactionBookTableViewModel ToViewModel(this TransactionBookTable TransactionBookTable)
        {

            return new TransactionBookTableViewModel
            {
                Id = TransactionBookTable.Id,
                TransactionBookTableFullName = TransactionBookTable.TransactionBookTableFullName,
                TransactionBookTableEmail = TransactionBookTable.TransactionBookTableEmail, 
                TransactionBookTableMobileNumber = TransactionBookTable.TransactionBookTableMobileNumber,
                TransactionBookTableDate = TransactionBookTable.TransactionBookTableDate,   

            };

        }

        public static TransactionBookTable ToModel(this TransactionBookTableViewModel TransactionBookTable)
        {

            return new TransactionBookTable
            {
               Id =  TransactionBookTable.Id,
               TransactionBookTableFullName =  TransactionBookTable.TransactionBookTableFullName,
               TransactionBookTableEmail =  TransactionBookTable.TransactionBookTableEmail,
               TransactionBookTableMobileNumber =  TransactionBookTable.TransactionBookTableMobileNumber,
               TransactionBookTableDate =  TransactionBookTable.TransactionBookTableDate,

            };

        }



        public static List<TransactionBookTableViewModel> TolListViewMode(this List<TransactionBookTable> TransactionBookTable)
        {

            return TransactionBookTable.Select(s => s.ToViewModel()).ToList();
        }



        public static List<TransactionBookTable> ToListModel(this List<TransactionBookTableViewModel> TransactionBookTable)
        {

            return TransactionBookTable.Select(x => x.ToModel()).ToList();

        }




    }
}
