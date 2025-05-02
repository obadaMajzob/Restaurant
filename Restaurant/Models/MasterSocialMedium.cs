using System;
using System.Collections.Generic;

namespace Restaurant.Models;

public  class MasterSocialMedium : BaseEntity
{
    //public int MasterSocialMediaId { get; set; }

    public string MasterSocialMediaImageUrl { get; set; } = null!;

    public string MasterSocialMediaUrl { get; set; } = null!;
}
