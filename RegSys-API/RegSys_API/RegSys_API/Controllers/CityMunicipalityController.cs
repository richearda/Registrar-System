using ISMS_API.Helpers;
using ISMS_API.Models;
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
    public class CityMunicipalityController : Controller
    {
        private ICityMunicipalityService _cityMunicipalityService;
        public CityMunicipalityController(ICityMunicipalityService cityMunicipalityService)
        {
            _cityMunicipalityService = cityMunicipalityService;
        }
        [HttpGet("citymunicipalitybyname")]
        public IActionResult GetCityMunicipalityByName(string cityMunicipalityName)
        {
            var result = _cityMunicipalityService.GetCityMunicipalityByName(cityMunicipalityName);
            return Ok(result);
        }
        [HttpGet(Routes.GetList)]
        public IActionResult GetCityMunicipalities()
        {
            var result = _cityMunicipalityService.GetCityMunicipalities();
            return Ok(result);
        }
    }
}
