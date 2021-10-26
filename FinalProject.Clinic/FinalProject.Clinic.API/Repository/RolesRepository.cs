using Dapper;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Common;
using FinalProject.Clinic.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject.Clinic.Infra.Repository
{
    public class RolesRepository : IRolesRepository
    {
        private readonly IDbContext dbContext;
        public RolesRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Roles> Roles_Get()
        {
            IEnumerable<Roles> result = dbContext.Connection.Query<Roles>("Roles_Get", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
