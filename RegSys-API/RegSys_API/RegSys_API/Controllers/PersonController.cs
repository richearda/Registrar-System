using ISMS_API.DTOs;
using ISMS_API.Helpers;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ISMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PersonController : Controller
    {
        private IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpPost("AddPerson")]
        public IActionResult AddPerson([FromBody] PersonDto personDto)
        {
            _personService.AddPerson(personDto);
            return Ok(personDto);
        }
        [HttpGet("People")]
        public IEnumerable<PersonDto> GetPeople()
        {
            var people = _personService.GetPeople();
            return people;
        }
        [HttpDelete(Routes.Delete)]
        public IActionResult DeletePerson(int id)
        {
            var result = _personService.DeletePerson(id);
            return Ok(result);
        }
    }
}
