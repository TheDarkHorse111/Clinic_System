using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Clinic.Core
{
    public class Reviews
    {
        public int ReviewId { get; set; }
        public int SiteId { get; set; }
        public double? Rate { get; set; }
        public DateTime? ReviewDate { get; set; }

        public virtual SiteSettings Site { get; set; }
    }
}
