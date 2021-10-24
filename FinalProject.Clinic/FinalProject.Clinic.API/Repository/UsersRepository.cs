using Dapper;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Common;
using FinalProject.Clinic.Core.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject.Clinic.Infra.Repository
{
    public class UsersRepository
    {
        private readonly IDbContext dbContext;
        public UsersRepository(IDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        public bool CreateUser(Users users)
        {
            var p = new DynamicParameters();
            p.Add("@RoleID", users.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Username", users.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", users.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@FullName", users.FullName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@BirthDay", users.BirthDay, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@Address", users.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", users.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MobileNumber", users.MobileNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@WhatsAppNumber", users.WhatsAppNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserImage", users.UserImage, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("Users_Insert", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<Users> GetUsers(GetUsersDTO users)
        {
            var p = new DynamicParameters();
            p.Add("@UserID", users.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@RoleID", users.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Username", users.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@FullName", users.FullName, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Users> result = dbContext.Connection.Query<Users>("Users_Get", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateCourse(Users users)
        {
            var p = new DynamicParameters();
            p.Add("@UserID", users.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@FullName", users.FullName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@BirthDay", users.BirthDay, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@Address", users.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", users.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@MobileNumber", users.MobileNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@WhatsAppNumber", users.WhatsAppNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserImage", users.UserImage, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("Users_Update", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCourse(int id)
        {
            var p = new DynamicParameters();
            p.Add("@UserID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("Users_Delete", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
