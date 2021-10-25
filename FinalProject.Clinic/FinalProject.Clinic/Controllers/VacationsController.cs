using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Clinic.Core;
using FinalProject.Clinic.Core.DTO;
using FinalProject.Clinic.Core.Service;

namespace FinalProject.Clinic.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VacationsController : Controller
    {

        public readonly IVacationsService vacationsService;

        public VacationsController(IVacationsService vacationsService)
        {
            this.vacationsService = vacationsService;
        }

        [HttpPut]
        [Route("Vacations_Update")]
        [ProducesResponseType(typeof(Vacations), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Vacations_Update(Vacations vacation)
        {
            return this.vacationsService.Vacations_Update(vacation);
        }


        [HttpPost]
        [ProducesResponseType(typeof(Vacations), StatusCodes.Status200OK)]
        [Route("Vacations_Insert")]
        public bool Vacations_Insert(Vacations vacations)
        {
            return this.vacationsService.Vacations_Insert(vacations);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        [ProducesResponseType(typeof(Vacations), StatusCodes.Status200OK)]
        public bool Vacations_Delete(int id)
        {
            return this.vacationsService.Vacations_Delete(id);
        }
        [HttpPost]
        [Route("Vacations_Get")]
        [ProducesResponseType(typeof(List<Vacations>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Vacations> Vacations_Get(VacationsDTO vacationsDto)
        {
            return this.vacationsService.Vacations_Get(vacationsDto);
        }





    }
}
