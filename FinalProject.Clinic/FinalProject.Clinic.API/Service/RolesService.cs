using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Clinic.Infra.Service
{
    public class RolesService : IRolesService
    {
        private readonly IRolesRepository rolesRepository;
        public RolesService(IRolesRepository rolesRepository) 
        {
            this.rolesRepository = rolesRepository;
        }
        public List<Roles> Roles_Get() 
        {
            return rolesRepository.Roles_Get();
        }
    }
}
