using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Clinic.Core
{
    public class SiteSettings
    {
        [Key]
        public int SiteId { get; set; }
        public string SiteLogo { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public string AboutUs { get; set; }
        public string TelNumber { get; set; }
        public string MobileNumber { get; set; }
        public string FaxNumber { get; set; }
        public string WhatsApp { get; set; }
        public string FaceBook { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public string Instagram { get; set; }

        public virtual ICollection<ContactUs> ContactUs { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
        public virtual ICollection<Testimonials> Testimonials { get; set; }
    }
}
