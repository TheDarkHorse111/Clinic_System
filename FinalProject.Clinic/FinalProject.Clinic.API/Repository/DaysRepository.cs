using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Common;
using FinalProject.Clinic.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Clinic.Infra.Repository
{
   public class DaysRepository: IDaysRepository
    {
       private readonly IDbContext dbContext;
       public DaysRepository(IDbContext dbContext)
       {
           this.dbContext = dbContext;
       }

       public List<Days> Days_Get()
       {
           IEnumerable<Days> result = dbContext.Connection.Query<Days>("Days_Get", commandType: CommandType.StoredProcedure);
           return result.ToList();
       }


    }
}
