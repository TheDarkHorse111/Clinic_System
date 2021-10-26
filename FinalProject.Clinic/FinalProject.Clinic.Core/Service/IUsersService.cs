using FinalProject.Clinic.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.Service
{
    public interface IUsersService
    {
        bool Users_Insert(Users users);
        List<Users> Users_Get(Users users);
        bool Users_Update(Users users);
        bool Users_Delete(int id);
        string Authentication(Users login);
        bool Users_UpdatePassword(UsersUpdatePasswordDTO users);
    }
}
