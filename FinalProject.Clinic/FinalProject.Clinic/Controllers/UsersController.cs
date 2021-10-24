using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.DTO;
using FinalProject.Clinic.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Clinic.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;
        public UsersController(IUsersService usersService) 
        {
            this.usersService = usersService;
        }

        public bool CreateUsers(Users users)
        {
            return usersService.CreateUsers(users);
        }

        public List<Users> GetUsers(GetUsersDTO users)
        {
            return usersService.GetUsers(users);
        }

        public bool UpdateUsers(Users users)
        {
            return usersService.UpdateUsers(users);
        }

        public bool DeleteUsers(int id)
        {
            return usersService.DeleteUsers(id);
        }
    }
}
