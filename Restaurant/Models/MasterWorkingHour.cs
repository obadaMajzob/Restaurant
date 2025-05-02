using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public  class MasterWorkingHour : BaseEntity
{
    //public int MasterWorkingHoursId { get; set; }

    public string? MasterWorkingHoursIdName { get; set; }

    public string? MasterWorkingHoursIdTimeFormTo { get; set; }
}
