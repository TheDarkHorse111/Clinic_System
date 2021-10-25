using System.Collections.Generic;
using FinalProject.Clinic.Core.DTO;

namespace FinalProject.Clinic.Core.Repository
{
    public interface IVacationsRepository
    {

      bool  Vacations_Update(Vacations vacation);
      bool Vacations_Insert(Vacations vacations);
      bool Vacations_Delete(int id);
      List<Vacations> Vacations_Get(VacationsDTO vacationsDto);


    }
}