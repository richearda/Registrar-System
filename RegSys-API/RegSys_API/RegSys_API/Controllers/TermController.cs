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
    public class TermController : ControllerBase
    {
        private ITermService _termService;

        public TermController(ITermService termService)
        {
            _termService = termService;
        }

        [HttpGet("GetCurrentTerm")]
        public IActionResult GetCurrentActiveTerm()
        {
           var result = _termService.GetCurrentActiveTerm();
            return Ok(result);
        }
        [HttpGet(Routes.Get + "/TermName")]
        public IActionResult GetTermByName(string termName)
        {
            var result = _termService.GetTermByName(termName);
            return Ok(result);
        }
        [HttpGet(Routes.GetList)]
        public IActionResult GetTerms()
        {
            var result = _termService.GetTerms();
            return Ok(result);
        }


    }
}
