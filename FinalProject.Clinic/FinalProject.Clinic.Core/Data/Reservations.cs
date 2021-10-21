using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalProject.Clinic.Core
{
    public class Reservations
    {
        public int ReservationId { get; set; }
        public int ClinicId { get; set; }
        public int PatientId { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime ReservationFrom { get; set; }
        public DateTime ReservationTo { get; set; }

        public virtual Clinics Clinic { get; set; }
        public virtual Users ClinicNavigation { get; set; }
    }
}
