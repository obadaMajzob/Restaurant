using Restaurant.Models;
using Restaurant.ViewModels;

namespace Restaurant.Extensions
{

    public static class MasterWorkingHourExtension
    {





        public static MasterWorkingHourViewModel ToViewModel(this MasterWorkingHour workingHour)
        {
            return new MasterWorkingHourViewModel
            {
                Id = workingHour.Id,
                MasterWorkingHoursIdName = workingHour.MasterWorkingHoursIdName,
                MasterWorkingHoursIdTimeFormTo=workingHour.MasterWorkingHoursIdTimeFormTo,
                IsActivate = workingHour.IsActivate,

            };

        }
        public static MasterWorkingHour ToModel(this MasterWorkingHourViewModel workingHour)
        {
            return new MasterWorkingHour
            {
                Id = workingHour.Id,
                MasterWorkingHoursIdName = workingHour.MasterWorkingHoursIdName,
                MasterWorkingHoursIdTimeFormTo = workingHour.MasterWorkingHoursIdTimeFormTo,
                IsActivate = workingHour.IsActivate,

            };

        }
        public static List<MasterWorkingHourViewModel> ToViewModelList(this List<MasterWorkingHour> workingHourList)
        {
            var myList = workingHourList.Select(x => x.ToViewModel()).ToList();
            return myList;
        }





    }

}
