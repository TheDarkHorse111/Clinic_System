using System;
using System.Collections.Generic;
using System.Text;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.DTO;
using FinalProject.Clinic.Core.Repository;
using FinalProject.Clinic.Core.Service;

namespace FinalProject.Clinic.Infra.Service
{
    public class VacationsService:IVacationsService
    {
        public readonly IVacationsRepository vacationsRepository;

        public VacationsService(IVacationsRepository vacationsRepository)
        {
            this.vacationsRepository = vacationsRepository;
        }

        public bool Vacations_Update(Vacations vacation)
        {
            return this.vacationsRepository.Vacations_Update(vacation);
        }

        public bool Vacations_Insert(Vacations vacations)
        {
            return this.vacationsRepository.Vacations_Insert(vacations);
        }

        public bool Vacations_Delete(int id)
        {
            return this.vacationsRepository.Vacations_Delete(id);
        }

        public List<Vacations> Vacations_Get(VacationsDTO vacationsDto)
        {
            return this.vacationsRepository.Vacations_Get(vacationsDto);
        }
    }
}
