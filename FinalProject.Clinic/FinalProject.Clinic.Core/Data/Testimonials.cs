using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Clinic.Core
{
    public class Testimonials
    {
        [Key]
        public int TestimonialId { get; set; }
        public int PatientId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SiteId { get; set; }
        public DateTime? TestimonialDate { get; set; }
        public bool ViewIt { get; set; }

        public virtual Users Patient { get; set; }
        public virtual SiteSettings Site { get; set; }
    }
}
