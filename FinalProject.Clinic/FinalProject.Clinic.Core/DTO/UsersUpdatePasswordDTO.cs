using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Core.DTO
{
    public class UsersUpdatePasswordDTO
    {
        public int UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
