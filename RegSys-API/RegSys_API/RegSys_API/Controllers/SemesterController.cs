using ISMS_API.Helpers;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class SemesterController : ControllerBase
    {
        private ISemesterService _semesterService;

        public SemesterController(ISemesterService semesterService)
        {
            _semesterService = semesterService;
        }

        [HttpGet("CurrentSemester")]
        public IActionResult GetCurrentActiveSemester()
        {
            var result =_semesterService.GetCurrentActiveSemester();
            return Ok(result);
        }
        [HttpGet(Routes.GetList)]
        public IActionResult GetSemesters()
        {
            var result = _semesterService.GetSemesters();
            return Ok(result);
        }
    }
}
