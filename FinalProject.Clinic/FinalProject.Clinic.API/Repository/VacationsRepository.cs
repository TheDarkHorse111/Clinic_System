using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Common;
using FinalProject.Clinic.Core.DTO;
using FinalProject.Clinic.Core.Repository;

namespace FinalProject.Clinic.Infra.Repository
{
    public class VacationsRepository :IVacationsRepository
    {

        private readonly IDbContext dbContext;
        public VacationsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public bool Vacations_Update(Vacations vacation)
        {
            var p = new DynamicParameters();
            p.Add("@VacationId", vacation.VacationId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@StartDate", vacation.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndDate", vacation.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Description", vacation.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("Vacations_Update", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Vacations_Insert(Vacations vacation)
        {
            var p = new DynamicParameters();
            p.Add("@ClinicId", vacation.ClinicId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@StartDate", vacation.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndDate", vacation.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Description", vacation.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("Vacations_Update", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Vacations_Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@VacationId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("Vacations_Delete", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Vacations> Vacations_Get(VacationsDTO vacationsDto)
        {
            var p = new DynamicParameters();
            p.Add("@StartDate", vacationsDto.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndDate", vacationsDto.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            
            IEnumerable<Vacations> result = dbContext.Connection.Query<Vacations>("Vacations_Get", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
