using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public  class MasterService : BaseEntity
{
    //public int MasterServicesId { get; set; }

    public string? MasterServicesTitle { get; set; }

    public string? MasterServicesDesc { get; set; }

    public string? MasterServicesImage { get; set; }
}
