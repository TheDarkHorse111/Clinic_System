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
    public class ReservationsRepository: IReservationsRepository
    {

        private readonly IDbContext dbContext;
        public ReservationsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool Reservation_Insert(Reservations reservations)
        {
            var p = new DynamicParameters();

            p.Add("@ClinicId", reservations.ClinicId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("@PatientId", reservations.PatientId, dbType: DbType.Int32, direction: ParameterDirection.Input);

   
            p.Add("@ReservationDate", reservations.ReservationDate.Date, dbType: DbType.Date, direction: ParameterDirection.Input);

     
            p.Add("@ReservationFrom", reservations.ReservationFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@ReservationTo", reservations.ReservationTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);


            var result = dbContext.Connection.ExecuteAsync("Reservation_Insert", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool Reservation_Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@ReservationID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("Reservation_Delete", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Reservations> Reservation_Get(ReservationsDTO reservationsDto)
        {
            var p = new DynamicParameters();
            p.Add("@ClinicID", reservationsDto.ClinicID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@PatientID", reservationsDto.PatientID, dbType: DbType.Int32, direction: ParameterDirection.Input);


            p.Add("@ReservationDate", reservationsDto.ReservationDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@ReservationFrom", reservationsDto.ReservationFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@ReservationTo", reservationsDto.ReservationTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            IEnumerable<Reservations> result = dbContext.Connection.Query<Reservations>("Reservation_Get", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}
