using Restaurant.Models;

namespace Restaurant.ViewModels
{
    public class HomeViewModel
    {


        public MasterAboutViewModel MasterAbout { get; set; }
        public List<MasterSliderViewModel> MasterSliderList { get; set; }
        public List<MasterClientsFeedbackViewModel> MasterClientsFeedbackList { get; set; }
        public MasterOfferViewModel MasterOfferr { get; set; }


        public TransactionBookTableViewModel BookTables { get; set; }
        public List<MasterPartnerViewModel> MasterPartnerList { get; set; }



    }
}
