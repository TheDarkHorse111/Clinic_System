using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Clinic.Core
{
    public  class Days
    {
        public Days()
        {
            
        }

        public int DayId { get; set; }
        public string DayName { get; set; }

        public virtual ICollection<WorkingHours> WorkingHours { get; set; }
    }
}
