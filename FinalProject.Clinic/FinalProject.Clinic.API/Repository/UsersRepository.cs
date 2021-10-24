using FinalProject.Clinic.Core.Common;
using System;
using System.Collections.Generic;
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


    }
}
