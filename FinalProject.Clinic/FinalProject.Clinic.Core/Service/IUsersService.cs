using FinalProject.Clinic.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Service
{
    public interface IUsersService
    {
        bool CreateUsers(Users users);
        List<Users> GetUsers(GetUsersDTO users);
        bool UpdateUsers(Users users);
        bool DeleteUsers(int id);
    }
}
