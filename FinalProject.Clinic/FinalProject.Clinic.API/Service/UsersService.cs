using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.DTO;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Infra.Service
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository usersRepository;
        public UsersService(IUsersRepository usersRepository) 
        {
            this.usersRepository = usersRepository;
        }

        public bool CreateUsers(Users users)
        {
            return usersRepository.CreateUsers(users);
        }

        public List<Users> GetUsers(GetUsersDTO users)
        {
            return usersRepository.GetUsers(users);
        }

        public bool UpdateUsers(Users users)
        {
            return usersRepository.UpdateUsers(users);
        }

        public bool DeleteUsers(int id)
        {
            return usersRepository.DeleteUsers(id);
        }
    }
}
