using ISMS_API.DTOs;
using ISMS_API.Helpers;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProgramController : Controller
    {
        private IProgramService _programService;

        public ProgramController(IProgramService programService)
        {
            _programService = programService;
        }
        [HttpGet(Routes.GetList)]
        public IEnumerable<ProgramDto> GetPrograms()
        {
            return _programService.GetPrograms();           
        }

        [HttpGet(Routes.GetList + "/Majors")]
        public IEnumerable<ProgramMajorDto> GetProgramMajors([FromQuery] string programName)
        {
            return _programService.GetProgramMajors(programName);
        }
    }
}
