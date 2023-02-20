using ISMS_API.DTOs;
using ISMS_API.Helpers;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ISMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class FeeController : Controller
    {
        private IFeeService _feeService;
        public FeeController(IFeeService feeService)
        {
            _feeService = feeService;
        }
        [HttpPost(Routes.Add)]
        public IActionResult AddFee(Fee fee)
        {
            var result = _feeService.AddFee(fee);
            return Ok(result);
        }
        [HttpPut(Routes.Edit)]
        public IActionResult UpdateFee(Fee fee)
        {
            var result = _feeService.UpdateFee(fee);
            return Ok(result);
        }
        [HttpGet(Routes.GetList + "/ActiveFees")]
        public IActionResult GetActiveFees()
        {
            var result = _feeService.GetActiveFees();
            return Ok(result);
        }
        [HttpGet(Routes.GetList + "/InActiveFees")]
        public IActionResult GetInActiveFees()
        {
            var result = _feeService.GetInactiveFees();
            return Ok(result);
        }
        [HttpGet(Routes.GetList + "/GetFeeByFeeType")]
        public IActionResult GetFeeByFeeTypeName(string feeTypeName)
        {
            var result = _feeService.GetFeeByFeeTypeName(feeTypeName);
            return Ok(result);
        }
        [HttpGet("GetFeeByName")]
        public IActionResult GetFeeByName(string feeName)
        { 
        var result = _feeService.GetFeeByName(feeName);
            return Ok(result);
        }
        [HttpPut(Routes.Activate)]
        public IActionResult ActivateFee(int ID)
        { 
        var result = _feeService.ActivateFee(ID);
            return Ok(result);
        }
        [HttpPut(Routes.Deactivate)]
        public IActionResult DeactivateFee(int ID)
        {
            var result = _feeService.DeactivateFee(ID);
            return Ok(result);
        }
        [HttpDelete(Routes.Delete)]
        public IActionResult Delete(int ID)
        {
            var result = _feeService.DeleteFee(ID);
            return Ok(result);
        }
    }
}
