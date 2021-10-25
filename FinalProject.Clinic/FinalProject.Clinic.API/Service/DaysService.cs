using System;
using System.Collections.Generic;
using System.Text;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;

namespace FinalProject.Clinic.Infra.Service
{
   public class DaysService :IDaysService
   {
       public  readonly  IDaysRepository daysRepository;

       public DaysService(IDaysRepository daysRepository)
       {
           this.daysRepository = daysRepository;
       }

        public List<Days> Days_Get()
        {
           return this.daysRepository.Days_Get();
        }
    }
}
