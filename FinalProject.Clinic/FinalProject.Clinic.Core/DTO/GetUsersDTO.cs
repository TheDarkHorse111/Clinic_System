using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.DTO
{
    public class GetUsersDTO
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }

    }
}
