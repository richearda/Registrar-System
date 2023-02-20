using ISMS_API.Helpers;
using ISMS_API.Models;
using ISMS_API.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ISMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class BarangayController : Controller
    {
        private IBarangayService _barangayService;

        public BarangayController(IBarangayService barangayService)
        {
            _barangayService = barangayService;
        }
        [HttpGet("BarangayByName")]
        public IActionResult GetBarangayByName(string barangayName)
        {
           var result = _barangayService.GetBarangayByName(barangayName);
            return Ok(result);
        }
        [HttpGet(Routes.GetList)]
        public IActionResult GetBarangays()
        {
           var result = _barangayService.GetBarangays();
            return Ok(result);
        }
        [HttpGet(Routes.GetList + "/CityMunicipalityBarangays")]
        public IActionResult GetBarangaysByCityMunicipalityName(string cityMunicipalityName) {
           var result =  _barangayService.GetBarangaysByCityMunicipalityName(cityMunicipalityName);
            return Ok(result);
        }

        
    }
}
