using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FinalProject.Clinic.Core.DTO
{
   public class ReservationsDTO
   {
       public int? ClinicID;
       public int? PatientID;

       public DateTime? ReservationDate;
       public DateTime? ReservationFrom;
       public DateTime? ReservationTo;
       

    }
}
