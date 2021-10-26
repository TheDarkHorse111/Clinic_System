using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.DTO;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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

        public bool Users_Insert(Users users)
        {
            return usersRepository.Users_Insert(users);
        }

        public List<Users> Users_Get(Users users)
        {
            return usersRepository.Users_Get(users);
        }

        public bool Users_Update(Users users)
        {
            return usersRepository.Users_Update(users);
        }

        public bool Users_Delete(int id)
        {
            return usersRepository.Users_Delete(id);
        }

        public string Authentication(Users login)
        {
            var result = usersRepository.Users_Login(login);
            if (result == null)
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOEKN, IT CAN BE ANY STRING]");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(
                        new Claim[]
                        {
                            new Claim(ClaimTypes.Name, result.Username)
                        }
                    ),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }

        }

        public bool Users_UpdatePassword(UsersUpdatePasswordDTO users) 
        {
            return usersRepository.Users_UpdatePassword(users);
        }
    }
}
