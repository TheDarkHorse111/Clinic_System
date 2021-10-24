using FinalProject.Clinic.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Repository
{
    public interface IUsersRepository
    {
        bool CreateUsers(Users users);
        List<Users> GetUsers(GetUsersDTO users);
        bool UpdateUsers(Users users);
        bool DeleteUsers(int id);
    }
}
