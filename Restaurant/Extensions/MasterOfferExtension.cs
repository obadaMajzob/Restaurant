using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{
    public static class MasterOfferExtension
    {



        public static MasterOfferViewModel ToViewModel(this MasterOffer MasterOffer)
        {

            return new MasterOfferViewModel
            {
                Id = MasterOffer.Id,
                MasterOfferTitle = MasterOffer.MasterOfferTitle,    
                MasterOfferBreef= MasterOffer.MasterOfferBreef,
                MasterOfferDesc= MasterOffer.MasterOfferDesc,
                MasterOfferImageUrl = MasterOffer.MasterOfferImageUrl,

                IsActivate = MasterOffer.IsActivate,

            };

        }

        public static MasterOffer ToModel(this MasterOfferViewModel MasterOffer)
        {

            return new MasterOffer
            {
                Id = MasterOffer.Id,
                MasterOfferTitle = MasterOffer.MasterOfferTitle,
                MasterOfferBreef= MasterOffer.MasterOfferBreef,
                MasterOfferDesc= MasterOffer.MasterOfferDesc,
                MasterOfferImageUrl = MasterOffer.MasterOfferImageUrl,

                IsActivate = MasterOffer.IsActivate,


            };

        }
        public static List<MasterOfferViewModel> ToListViewModel(this List<MasterOffer> MasterOffer)
        {

            return MasterOffer.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterOffer> ToListModel(this List<MasterOfferViewModel> MasterOffer)
        {

            return MasterOffer.Select(x => x.ToModel()).ToList();

        }






    }
}
