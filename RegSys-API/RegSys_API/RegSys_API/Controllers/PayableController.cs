using ISMS_API.DTOs;
using ISMS_API.Helpers;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PayableController : ControllerBase
    {
        private IPayableService _payableService;

        public PayableController(IPayableService payableService)
        {
            _payableService = payableService;
        }

        [HttpPost(Routes.Add)]
        public IActionResult AddPayable(PayableDto payableDto)
        {
            var result = _payableService.AddPayable(payableDto);
            return Ok(result);
        }

        [HttpPost(Routes.Add + "/Payables")]
        public IActionResult AddPayables([FromBody] PayableDto payablesDto)
        {
            var result = _payableService.AddPayables(payablesDto);
            return Ok(result);
        }

        [HttpPut(Routes.Edit)]
        public IActionResult UpdatePayable(Payable payable)
        {
            var result = _payableService.UpdatePayable(payable);
            return Ok(result);
        }

        [HttpDelete(Routes.Delete)]
        public IActionResult DeletePayable(int payableId)
        {
            var result = _payableService.DeletePayable(payableId);
            return Ok(result);
        }

        [HttpGet(Routes.GetList)]
        public IActionResult GetPayables()
        {
            var result = _payableService.GetPayables();
            return Ok(result);
        }

        [HttpGet(Routes.Get)]
        public IActionResult GetPayable(int payableId)
        {
            var result = _payableService.GetPayable(payableId);
            return Ok(result);
        }

        [HttpGet("StudentPayables")]
        public IActionResult GetStudentPayables(int Id, int termId, int semesterId)
        {
            var result = _payableService.GetStudentPayables(Id, termId, semesterId);
            return Ok(result);
        }
    }
}