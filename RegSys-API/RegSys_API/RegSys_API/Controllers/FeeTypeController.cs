using ISMS_API.DTOs;
using ISMS_API.Helpers;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class FeeTypeController : ControllerBase
    {
        private readonly IFeeTypeService _feeTypeService;
        public FeeTypeController(IFeeTypeService feeTypeService)
        {
            _feeTypeService = feeTypeService;
        }
        [HttpGet(Routes.GetList)]
        public IActionResult GetFeeTypes()
        {
            var result = _feeTypeService.GetFeeTypes();
            return Ok(result);
        }
        [HttpPost(Routes.Add)]
        public IActionResult AddFeeType(FeeTypeDto feeTypeDto)
        {
            var result = _feeTypeService.AddFeeType(feeTypeDto);
            return Ok(result);
        }
        [HttpPut(Routes.Edit)]
        public IActionResult UpdateFeeType(FeeTypeDto feeTypeDto)
        {
            var result = _feeTypeService.UpdateFeeType(feeTypeDto);
            return Ok(result);
        }
        [HttpDelete(Routes.Delete)]
        public IActionResult DeleteFeeType(int ID)
        {
            var result =  _feeTypeService.DeleteFeeType(ID);
            return Ok(result);
        }
        [HttpPut(Routes.Activate)]
        public IActionResult ActiveFeeType(int ID)
        {
            var result = _feeTypeService.ActivateFeeType(ID);
            return Ok(result);
        }
        [HttpPut(Routes.Deactivate)]
        public IActionResult DeactiveFeeType(int ID)
        {
            var result = _feeTypeService.DeactivateFeeType(ID);
            return Ok(result);
        }
        [HttpGet(Routes.GetList + "/ActiveFeeTypes")]
        public IActionResult GetActiveFeeTypes()
        {
            var result = _feeTypeService.GetActiveFeeTypes();
            return Ok(result);
        }
        [HttpGet(Routes.GetList + "/InactiveFeeTypes")]
        public IActionResult GetInactiveFeeTypes()
        {
            var result = _feeTypeService.GetInactiveFeeTypes();
            return Ok(result);
        }

    }
}
